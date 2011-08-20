using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeInterfaces
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

        private void FillWithEmptyFields()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col]=new EmptyField();
                }
            }
        }

        private void SetCentreCordinates()
        {
            double doubleCopyRows = Convert.ToDouble(this.Rows);
            middleRow = Convert.ToInt32( Math.Floor(doubleCopyRows / 2));
            double doubleCopyColums = Convert.ToDouble( this.Colums);
            middleColum =Convert.ToInt32( Math.Floor(doubleCopyColums / 2));
        }
    }

    public class Field
    {
    }
    public class EmptyField:Field
    {
    }
    public class SnakeField:Field
    {
    }
    public class FoodField:Field
    {
    }
    public class WallField:Field
    {
    }
}
