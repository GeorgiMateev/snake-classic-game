using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataDealer
{
    public class Result
    {
        private int score;
        private string speed;
        private string owner;
        private int snakeLenght;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        private string fieldSize;
        private int includeBorders;
        private int place;
        private static OleDbConnection dbConn;

        public int Place
        {
            get { return place; }
        }
        
        public static OleDbConnection DbConn
        {
            get { return dbConn; }
            set { dbConn = value; }
        }
        private Dictionary<int, bool> boolDict;
        private const string DbConnString = @"Provider =Microsoft.ACE.OLEDB.12.0; Data Source =ResultDB.mdb; User Id =admin; Password =;";

        
        public Result(int score,int snLenght, string speed, string fieldSize, int borders)
        {
            this.score = score;
            this.snakeLenght = snLenght;
            this.speed = speed;
            this.fieldSize = fieldSize;
            this.includeBorders = borders;
            this.place = this.CheckResultPlace();
            boolDict = new Dictionary<int, bool>();
            boolDict.Add(3, true);
            boolDict.Add(1, false);
        }

        public bool SaveResult()
        {
            Result.DbConn = new OleDbConnection(Result.DbConnString);
            OleDbCommand saveRecord = new OleDbCommand(
                "INSERT INTO [Results] (Score,Owner,[Snake Lenght],Speed,FieldSize,Borders,CreatedOn)"+
                "VALUES (@Score,@Owner,@SnakeLenght,@Speed,@FieldSize,@Borders,@CreatedOn)",Result.DbConn);
            saveRecord.Parameters.Add(new OleDbParameter("@Score", this.score));
            saveRecord.Parameters.Add(new OleDbParameter("@Owner", this.owner));
            saveRecord.Parameters.Add(new OleDbParameter("@SnakeLenght", this.snakeLenght));
            saveRecord.Parameters.Add(new OleDbParameter("@Speed", this.speed));
            saveRecord.Parameters.Add(new OleDbParameter("@FieldSize", this.fieldSize));
            saveRecord.Parameters.Add(new OleDbParameter("@Borders",boolDict[ this.includeBorders]));
            saveRecord.Parameters.Add(new OleDbParameter("@CreatedOn", DateTime.Now.Date));
            Result.DbConn.Open();
            using (Result.DbConn)
            {
                int executed = (int)saveRecord.ExecuteNonQuery();
                if (executed==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public int CheckResultPlace()
        {
            Result.DbConn = new OleDbConnection(Result.DbConnString);
            OleDbCommand getScore = new OleDbCommand(
                "SELECT [Score] FROM [Results] ORDER BY [Score] DESC",DbConn);
            Result.DbConn.Open();
            int countPlace = 1;
            using (Result.DbConn)
            {
                OleDbDataReader dataScore = getScore.ExecuteReader();
                using (dataScore)
                {
                    bool isFalse = dataScore.Read();
                    if (isFalse == false)
                    {
                        return 1;
                    }
                    else
                    {
                        do
                        {
                            if (this.score > (int)dataScore[0])
                            {
                                return countPlace;
                            }
                            countPlace++;
                        } 
                        while (dataScore.Read());
                    }
                    return countPlace;
                }
            }    
        }

        public static void DeleteFrom(int clearNumber)
        {
            Result.DbConn = new OleDbConnection(Result.DbConnString);
            OleDbCommand getCount = new OleDbCommand("SELECT COUNT(Score) FROM Results",Result.DbConn);
            OleDbCommand deleteLast = new OleDbCommand
                ("DELETE FROM [Results]"
                +"WHERE [ID]="
                +"(SELECT TOP 1 [ID]"
                +"FROM (SELECT [ID],[Score] FROM [Results] ORDER BY [Score] ASC))",Result.DbConn);
            Result.DbConn.Open();
            using (Result.DbConn)
            {
                int countScores = (int)getCount.ExecuteScalar();
                while (countScores > clearNumber)
                {
                    deleteLast.ExecuteNonQuery();
                    countScores = (int)getCount.ExecuteScalar();
                }
            }
        }

        public static void DisplayResults(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            Result.DbConn = new OleDbConnection(Result.DbConnString);
            OleDbCommand getResults = new OleDbCommand(
                 "SELECT *"
                 + "FROM [Results]"
                 + "ORDER BY [Score] DESC", Result.DbConn);
            Result.DbConn.Open();
            using (Result.DbConn)
            {
                OleDbDataReader resultsData = getResults.ExecuteReader();
                using (resultsData)
                {
                    while (resultsData.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();

                        DataGridViewTextBoxCell cellScore = new DataGridViewTextBoxCell();
                        cellScore.Value = (int)resultsData["Score"];
                        DataGridViewTextBoxCell cellOwner = new DataGridViewTextBoxCell();
                        cellOwner.Value = (string)resultsData["Owner"];
                        DataGridViewTextBoxCell cellLenght = new DataGridViewTextBoxCell();
                        cellLenght.Value = (int)resultsData["Snake Lenght"];
                        DataGridViewTextBoxCell cellSpeed = new DataGridViewTextBoxCell();
                        cellSpeed.Value = (string)resultsData["Speed"];
                        DataGridViewTextBoxCell cellField = new DataGridViewTextBoxCell();
                        cellField.Value = (string)resultsData["FieldSize"];
                        DataGridViewCheckBoxCell cellBorders = new DataGridViewCheckBoxCell();
                        cellBorders.Value = (bool)resultsData["Borders"];
                        DataGridViewTextBoxCell cellDate = new DataGridViewTextBoxCell();
                        DateTime onlyDate = (DateTime)resultsData["CreatedOn"];
                        cellDate.Value = onlyDate.Date.ToShortDateString();

                        row.Cells.Add(cellScore);
                        row.Cells.Add(cellOwner);
                        row.Cells.Add(cellLenght);
                        row.Cells.Add(cellSpeed);
                        row.Cells.Add(cellField);
                        row.Cells.Add(cellBorders);
                        row.Cells.Add(cellDate);

                        dataGridView.Rows.Add(row);
                    }
                }
            }           
        }
        public static void DisplayResults(DataGridView dataGridView,int numberResults)
        {
            dataGridView.Rows.Clear();
            Result.DbConn = new OleDbConnection(Result.DbConnString);
            OleDbCommand getResults = new OleDbCommand(
                 "SELECT TOP "+ numberResults +" *"
                 + "FROM [Results]"
                 + "ORDER BY [Score] DESC", Result.DbConn);
            Result.DbConn.Open();
            using (Result.DbConn)
            {
                OleDbDataReader resultsData = getResults.ExecuteReader();
                using (resultsData)
                {
                    while (resultsData.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();

                        DataGridViewTextBoxCell cellScore = new DataGridViewTextBoxCell();
                        cellScore.Value = (int)resultsData["Score"];
                        DataGridViewTextBoxCell cellOwner = new DataGridViewTextBoxCell();
                        cellOwner.Value = (string)resultsData["Owner"];
                        DataGridViewTextBoxCell cellLenght = new DataGridViewTextBoxCell();
                        cellLenght.Value = (int)resultsData["Snake Lenght"];
                        DataGridViewTextBoxCell cellSpeed = new DataGridViewTextBoxCell();
                        cellSpeed.Value = (string)resultsData["Speed"];
                        DataGridViewTextBoxCell cellField = new DataGridViewTextBoxCell();
                        cellField.Value = (string)resultsData["FieldSize"];
                        DataGridViewCheckBoxCell cellBorders = new DataGridViewCheckBoxCell();
                        cellBorders.Value = (bool)resultsData["Borders"];
                        DataGridViewTextBoxCell cellDate = new DataGridViewTextBoxCell();
                        DateTime onlyDate = (DateTime)resultsData["CreatedOn"];
                        cellDate.Value = onlyDate.Date.ToShortDateString();

                        row.Cells.Add(cellScore);
                        row.Cells.Add(cellOwner);
                        row.Cells.Add(cellLenght);
                        row.Cells.Add(cellSpeed);
                        row.Cells.Add(cellField);
                        row.Cells.Add(cellBorders);
                        row.Cells.Add(cellDate);

                        dataGridView.Rows.Add(row);
                    }
                }
            }
        }

        public static int AllRecordsNumber()
        {
            Result.DbConn = new OleDbConnection(Result.DbConnString);
            OleDbCommand getCount = new OleDbCommand(
                "SELECT COUNT(*) FROM [Results]",Result.DbConn);
            Result.DbConn.Open();
            using (Result.DbConn)
            {
                int count = (int)getCount.ExecuteScalar();
                return count;
            }
        }
    }   
}
