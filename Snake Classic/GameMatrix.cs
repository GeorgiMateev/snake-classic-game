using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeClassLib
{
    public class GameMatrix
    {
        int rows;
        int colums;
        int middleRow;
        int middleColum;
        Field[,] matrix;

        public Field[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        public int MiddleRow
        {
            get { return middleRow; }
            set { middleRow = value; }
        }       
        public int MiddleColum
        {
            get { return middleColum; }
            set { middleColum = value; }
        }    
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }       
        public int Colums
        {
            get { return colums; }
            set { colums = value; }
        }

        public GameMatrix(int row, int col)
        {
            this.Rows = row;
            this.Colums = col;
            matrix = new Field[Rows, Colums];

            SetCentreCordinates();
            FillWithEmptyFields();            
        }
        
        private void SetCentreCordinates()
        {
            double doubleCopyRows = Convert.ToDouble(this.Rows);
            middleRow = Convert.ToInt32(Math.Floor(doubleCopyRows / 2));
            double doubleCopyColums = Convert.ToDouble(this.Colums);
            middleColum = Convert.ToInt32(Math.Floor(doubleCopyColums / 2));
        }
        private void FillWithEmptyFields()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col]=new EmptyField(row,col);
                }
            }
        }
            
    }

    public class Field
    {
        int row;
        int col;

        public int Col
        {
            get { return col; }
            set { col = value; }
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public Field(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
    public class EmptyField:Field
    {
        public EmptyField(int row, int col)
            : base(row, col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
    public class SnakeField:Field
    {
        public SnakeField(int row, int col)
            : base(row, col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
    public class FoodField:Field
    {
        public FoodField(int row, int col)
            : base(row, col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
    public class WallField:Field
    {
        public WallField(int row, int col)
            : base(row, col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
    
}
