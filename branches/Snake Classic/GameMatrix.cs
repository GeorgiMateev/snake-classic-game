using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Classic
{
    class GameMatrix
    {
        int rows;
        int colums;
        double middleRow;
        double middleColum;
        Field[,] matrix;

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

            double doubleCopyRow = this.Rows;
            middleRow = Math.Floor(doubleCopyRow / 2);
        }
    }

    class Field
    {
    }
}
