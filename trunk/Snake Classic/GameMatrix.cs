using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Classic
{
    public class GameMatrix
    {
        int rows;
        int colums;
        double middleRow;
        double middleColum;
        Field[,] matrix;

        public Field[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
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

        }

        private void SetCentreCordinates()
        {
            double doubleCopyRows = this.Rows;
            middleRow = Math.Floor(doubleCopyRows / 2);
            double doubleCopyColums = this.Colums;
            middleColum = Math.Floor(doubleCopyColums / 2);
        }
    }

    class Field
    {
    }
}
