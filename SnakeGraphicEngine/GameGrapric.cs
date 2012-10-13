using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using SnakeClassLib;
using DrawingExtensions;



namespace SnakeGraphicEngine
{
    public class GameGrapric
    {
        private Graphics matrixGraphic;
        private Form currentForm;
        private int fieldSize;
        private int graphicLocationX;
        private int graphicLocationY;
        private int width;
        private int height;
        private int timeInterval;
        private bool includeSmoothGraphic;
        private Dictionary<Directions,Direction> directionsDict;
     
        
        public Graphics MatrixGraphic
        {
            get { return matrixGraphic; }
            set { matrixGraphic = value; }
        }

        public GameGrapric(Form currentForm,int grLocX,int grLocY,int cols,int rows,int fieldSize,int timeInterval,bool smoothGraphic)
        {
            directionsDict = new Dictionary<Directions, Direction>();
            directionsDict.Add(Directions.Down, Direction.Down);
            directionsDict.Add(Directions.Up, Direction.Up);
            directionsDict.Add(Directions.Left, Direction.Left);
            directionsDict.Add(Directions.Right, Direction.Right);
            this.fieldSize = fieldSize;
            this.graphicLocationX = grLocX;
            this.graphicLocationY = grLocY;
            this.width = cols*this.fieldSize;
            this.height = rows*this.fieldSize;
            this.timeInterval = timeInterval;
            this.includeSmoothGraphic = smoothGraphic;
     
            this.currentForm = currentForm;

            this.matrixGraphic = this.currentForm.CreateGraphics();        
            
            SnakeField.SnakeFieldCreated += new SnakeField.SnakeFieldCreateEventHandler(SnakeField_SnakeFieldCreated);
            SnakeFieldHead.SnakeFieldHeadCreated += new SnakeFieldHead.SnakeFieldHeadCreateEventArgs(SnakeFieldHead_SnakeFieldHeadCreated);
            FoodField.FoodFieldCreated += new FoodField.FoodFieldCreateEventHandler(FoodField_FoodFieldCreated);
            EmptyField.EmptyFieldCreated += new EmptyField.EmptyFieldCreateEventHandler(EmptyField_EmptyFieldCreated);
            WallField.WallFieldCreated += new WallField.WallFieldCreateEventHandler(WallField_WallFieldCreated);

            if (includeSmoothGraphic)
            {
                //SnakeField.SnakeFieldSmoothCreation += new SnakeField.SnakeFieldSmoothCreationEventHandler
                //    (SnakeField_SnakeFieldSmoothCreation);
                SnakeFieldHead.SnakeFieldHeadSmoothCreation += new SnakeFieldHead.SnakeFieldHeadSmoothCreationEventHandler
                    (SnakeFieldHead_SnakeFieldHeadSmoothCreation);
                EmptyField.EmptyFieldSmoothCreation += new EmptyField.EmptyFieldSmoothCreationEventHandler
                    (EmptyField_EmptyFieldSmoothCreation);
            }
            else
            {
                //SnakeField.SnakeFieldSmoothCreation += new SnakeField.SnakeFieldSmoothCreationEventHandler
                //    (SnakeField_SnakeFieldCreated);
                SnakeFieldHead.SnakeFieldHeadSmoothCreation += new SnakeFieldHead.SnakeFieldHeadSmoothCreationEventHandler
                    (SnakeFieldHead_SnakeFieldHeadCreated);
                EmptyField.EmptyFieldSmoothCreation += new EmptyField.EmptyFieldSmoothCreationEventHandler
                    (EmptyField_EmptyFieldCreated);
            }
        }

        public void SnakeFieldHead_SnakeFieldHeadSmoothCreation(SnakeFieldHead sender)
        {
            Brush snakeHeadBrush = new SolidBrush(Properties.GraphicColorSettings.Default.CurrentSnakeHeadFieldColor);

            int snakeFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int snakeFieldY = graphicLocationY + sender.Row * this.fieldSize;
            this.matrixGraphic.SmoothFillRectangleMultithreading
                (snakeHeadBrush, new Point(snakeFieldX, snakeFieldY), new Size(this.fieldSize, this.fieldSize), directionsDict[sender.DrawDirection], this.timeInterval);
            snakeHeadBrush.Dispose();
        }       

        public void EmptyField_EmptyFieldSmoothCreation(EmptyField sender)
        {
            Brush EmptyFieldBrush = new SolidBrush(Properties.GraphicColorSettings.Default.CurrentEmptyFieldColor);
            int emptyFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int emptyFiledY = graphicLocationY + sender.Row * this.fieldSize;
           
                this.matrixGraphic.SmoothFillRectangleMultithreading
                    (EmptyFieldBrush,new Point( emptyFieldX, emptyFiledY),new Size( this.fieldSize, this.fieldSize),directionsDict[sender.DrawDirection], timeInterval);
            
            EmptyFieldBrush.Dispose();
        }

        //public void SnakeField_SnakeFieldSmoothCreation(SnakeField sender)
        //{
        //    Brush snakeFieldBrush = new SolidBrush(Properties.GraphicColorSettings.Default.CurrentSnakeFieldColor);
        //    int snakeFieldX = graphicLocationX + sender.Col * this.fieldSize;
        //    int snakeFieldY = graphicLocationY + sender.Row * this.fieldSize;
        //    this.matrixGraphic.SmoothFillRectangleMultithreading
        //        (snakeFieldBrush, new Point(snakeFieldX, snakeFieldY), new Size(this.fieldSize, this.fieldSize), directionsDict[sender.DrawDirection], this.timeInterval);
        //    snakeFieldBrush.Dispose();
        //}

        public void WallField_WallFieldCreated(WallField sender)
        {
            Brush wallFieldBrush = new SolidBrush(Properties.GraphicColorSettings.Default.CurrentWallFieldColor);
            int wallFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int wallFieldY = graphicLocationY + sender.Row * this.fieldSize;
            lock (this.matrixGraphic)
            {
                this.matrixGraphic.FillRectangle
                    (wallFieldBrush, wallFieldX, wallFieldY, this.fieldSize, this.fieldSize);
            }
            wallFieldBrush.Dispose();
        }       
        public void SnakeField_SnakeFieldCreated(SnakeField sender)
        {
            Brush snakeFieldBrush;
            snakeFieldBrush = new SolidBrush(Properties.GraphicColorSettings.Default.CurrentSnakeFieldColor);
            int snakeFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int snakeFieldY = graphicLocationY + sender.Row * this.fieldSize;

            if (this.includeSmoothGraphic)
            {
                this.matrixGraphic.SmoothFillRectangleMultithreading
                (snakeFieldBrush, new Point(snakeFieldX, snakeFieldY),
                new Size(this.fieldSize, this.fieldSize), directionsDict[sender.DrawDirection], this.timeInterval);
            }
            else
            {
                lock (this.matrixGraphic)
                {
                    this.matrixGraphic.FillRectangle
                        (snakeFieldBrush, snakeFieldX, snakeFieldY, this.fieldSize, this.fieldSize);
                }
            }
            
            snakeFieldBrush.Dispose();
        }
        public void SnakeFieldHead_SnakeFieldHeadCreated(SnakeFieldHead sender)
        {
            Brush snakeHeadBrush = new SolidBrush(Properties.GraphicColorSettings.Default.DefaultSnakeHeadFieldColor);
            int snakeFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int snakeFieldY = graphicLocationY + sender.Row * this.fieldSize;
            lock (this.matrixGraphic)
            {
                this.matrixGraphic.FillRectangle
                    (snakeHeadBrush, snakeFieldX, snakeFieldY, this.fieldSize, this.fieldSize);
            }
            snakeHeadBrush.Dispose();
        }
        public void FoodField_FoodFieldCreated(FoodField sender)
        {
            Brush FoodFieldBrush = new SolidBrush(Properties.GraphicColorSettings.Default.CurrentFoodFieldColor);
            int foodFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int foodFiledY = graphicLocationY + sender.Row * this.fieldSize;
            lock (this.matrixGraphic)
            {
                this.matrixGraphic.FillRectangle
                    (FoodFieldBrush, foodFieldX, foodFiledY, this.fieldSize, this.fieldSize);
            }
            FoodFieldBrush.Dispose();
        }
        public void EmptyField_EmptyFieldCreated(EmptyField sender)
        {
            Brush EmptyFieldBrush = new SolidBrush(Properties.GraphicColorSettings.Default.CurrentEmptyFieldColor);
            int emptyFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int emptyFiledY = graphicLocationY + sender.Row * this.fieldSize;
            lock (this.matrixGraphic)
            {
            this.matrixGraphic.FillRectangle
                (EmptyFieldBrush, emptyFieldX, emptyFiledY, this.fieldSize, this.fieldSize);
            }
            EmptyFieldBrush.Dispose();
        }


        public void RePaintPlatform(Field[,] currentMatrix)
        {
            foreach (var item in currentMatrix)
            {
                if (item is EmptyField)
                {
                    EmptyField unpackedItem = (EmptyField)item;
                    unpackedItem.CallCreateEvent();
                }
                if (item is SnakeField)
                {
                    SnakeField unpackedItem = (SnakeField)item;
                    unpackedItem.CallCreateEvent();
                }
                if (item is SnakeFieldHead)
                {
                    SnakeFieldHead unpackedItem = (SnakeFieldHead)item;
                    unpackedItem.CallCreateEvent();
                }
                if (item is FoodField)
                {
                    FoodField unpackedItem = (FoodField)item;
                    unpackedItem.CallCreateEvent();
                }
                if (item is WallField)
                {
                    WallField unpackedItem = (WallField)item;
                    unpackedItem.CallCreateEvent();
                }
            }
        }
    }
}
