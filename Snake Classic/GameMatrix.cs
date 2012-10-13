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
        bool includeBorderWalls;

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

        public GameMatrix(int row, int col,bool includeWalls)
        {
            this.Rows = row;
            this.Colums = col;
            this.includeBorderWalls = includeWalls;
            matrix = new Field[Rows, Colums];

            this.SetCentreCordinates();
            this.FillWithEmptyFields();
            if (this.includeBorderWalls)
            {
                this.CreateBorderWalls();
            }
            this.GenerateFoodField();
        }

       
        private void SetCentreCordinates()
        {
            double doubleCopyRows = Convert.ToDouble(this.Rows);
            middleRow = Convert.ToInt32(Math.Floor(doubleCopyRows / 2));
            double doubleCopyColums = Convert.ToDouble(this.Colums);
            middleColum = Convert.ToInt32(Math.Floor(doubleCopyColums / 2));
        }
        private void CreateBorderWalls()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, 0] = new WallField(row, 0,Directions.Left);
                matrix[row, matrix.GetLength(1)-1] = new WallField(row, matrix.GetLength(1)-1,Directions.Left);
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[0, col] = new WallField(0, col,Directions.Left);
                matrix[matrix.GetLength(0)-1, col] = new WallField(matrix.GetLength(0)-1, col,Directions.Left);
            }
        }
        private void FillWithEmptyFields()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = new EmptyField(row, col);
                }
            }
        }
        internal void GenerateFoodField()
        {
            int randomRow=0;
            int randomCol=0;
            do
            {
                randomRow = this.RandomNumber(0, this.Rows - 1);
                randomCol = this.RandomNumber(0, this.Colums - 1);
                if (this.matrix[randomRow, randomCol] is EmptyField)
                {
                    this.matrix[randomRow, randomCol] = new FoodField(randomRow, randomCol,Directions.Left);
                }
            }
            while (this.matrix[randomRow, randomCol] is SnakeField || this.matrix[randomRow, randomCol] is WallField);	
           
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }

    public class Field
    {
        int row;
        int col;
        Directions drawDirection;

        public Directions DrawDirection
        {
            get { return drawDirection; }
            set { drawDirection = value; }
        }

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

        public Field(int row, int col,Directions drawDirection)
        {
            this.row = row;
            this.col = col;
            this.drawDirection = drawDirection;
        }
        public Field(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
    public class EmptyField : Field
    {
        public delegate void EmptyFieldCreateEventHandler(EmptyField sender);
        public static event EmptyFieldCreateEventHandler EmptyFieldCreated;

        public delegate void EmptyFieldSmoothCreationEventHandler(EmptyField sender);
        public static event EmptyFieldSmoothCreationEventHandler EmptyFieldSmoothCreation;

        public EmptyField(int row, int col)
            : base(row, col)
        {
            this.Row = row;
            this.Col = col;
            this.CallCreateEvent();
        }
        public EmptyField(int row, int col,Directions drawDirection)
            : base(row, col,drawDirection)
        {
            this.Row = row;
            this.Col = col;
            this.DrawDirection = drawDirection;
            this.CallSmoothCreationEvent();
        }

        public void CallSmoothCreationEvent()
        {
            if (EmptyFieldSmoothCreation!=null)
            {
                EmptyFieldSmoothCreation(this);
            }
        }

        public void CallCreateEvent()
        {
            if (EmptyFieldCreated != null)
            {
                EmptyFieldCreated(this);
            }
        }

    }
    public class SnakeField : Field
    {
        public delegate void SnakeFieldCreateEventHandler(SnakeField sender);
        public static event SnakeFieldCreateEventHandler SnakeFieldCreated;

        public delegate void SnakeFieldSmoothCreationEventHandler(SnakeField sender);
        public static event SnakeFieldSmoothCreationEventHandler SnakeFieldSmoothCreation;

        public DrawMethods DrawMethod { get; set; }

        public SnakeField(int row, int col,Directions drawDirection, DrawMethods drawMethod)
            : base(row, col,drawDirection)
        {
            this.Row = row;
            this.Col = col;
            this.DrawDirection = drawDirection;
            this.DrawMethod = drawMethod;

            this.CallCreateEvent();
        }

        //public void CallSmoothCreationEvent()
        //{
        //    if (SnakeFieldSmoothCreation !=null)
        //    {
        //        SnakeFieldSmoothCreation(this);
        //    }
        //}

        public void CallCreateEvent()
        {
            if (SnakeFieldCreated != null)
            {
                SnakeFieldCreated(this);
            }
        }
    }
    public class SnakeFieldHead : Field
    {
        public delegate void SnakeFieldHeadCreateEventArgs(SnakeFieldHead sender);
        public static event SnakeFieldHeadCreateEventArgs SnakeFieldHeadCreated;

        public delegate void SnakeFieldHeadSmoothCreationEventHandler(SnakeFieldHead sender);
        public static event SnakeFieldHeadSmoothCreationEventHandler SnakeFieldHeadSmoothCreation;

        public SnakeFieldHead(int row, int col, Directions drawDirection)
            : base(row, col, drawDirection)
        {
            this.Row = row;
            this.Col = col;
            this.CallSmoothCreationEvent();
        }

        public void CallCreateEvent()
        {
            if (SnakeFieldHeadCreated != null)
            {
                SnakeFieldHeadCreated(this);
            }
        }

        public void CallSmoothCreationEvent()
        {
            if (SnakeFieldHeadSmoothCreation != null)
            {
                SnakeFieldHeadSmoothCreation(this);
            }
        }
    }
    public class FoodField : Field
    {
        public delegate void FoodFieldCreateEventHandler(FoodField sender);
        public static event FoodFieldCreateEventHandler FoodFieldCreated;
        public FoodField(int row, int col,Directions drawDirection)
            : base(row, col,drawDirection)
        {
            this.Row = row;
            this.Col = col;
            this.CallCreateEvent();
        }

        public void CallCreateEvent()
        {
            if (FoodFieldCreated != null)
            {
                FoodFieldCreated(this);
            }
        }
    }
    public class WallField : Field
    {
        public delegate void WallFieldCreateEventHandler(WallField sender);
        public static event WallFieldCreateEventHandler WallFieldCreated;
        public WallField(int row, int col,Directions drawDirection)
            : base(row, col,drawDirection)
        {
            this.Row = row;
            this.Col = col;
            this.CallCreateEvent();
        }

        public void CallCreateEvent()
        {
            if (WallFieldCreated != null)
            {
                WallFieldCreated(this);
            }
        }
    }
    
}


   