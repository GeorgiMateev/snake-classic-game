using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using SnakeClassLib;



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
   
 
        
        public Graphics MatrixGraphic
        {
            get { return matrixGraphic; }
            set { matrixGraphic = value; }
        }

        public GameGrapric(Form currentForm,int grLocX,int grLocY,int cols,int rows,int fieldSize)
        {
            this.fieldSize = fieldSize;
            this.graphicLocationX = grLocX;
            this.graphicLocationY = grLocY;
            this.width = cols*this.fieldSize;
            this.height = rows*this.fieldSize;
     
            this.currentForm = currentForm;

            this.matrixGraphic = this.currentForm.CreateGraphics();        
            
            SnakeField.SnakeFieldCreated += new SnakeField.SnakeFieldCreateEventHandler(SnakeField_SnakeFieldCreated);
            FoodField.FoodFieldCreated += new FoodField.FoodFieldCreateEventHandler(FoodField_FoodFieldCreated);
            EmptyField.EmptyFieldCreated += new EmptyField.EmptyFieldCreateEventHandler(EmptyField_EmptyFieldCreated);
            WallField.WallFieldCreated += new WallField.WallFieldCreateEventHandler(WallField_WallFieldCreated);
        }

        

       

        public void WallField_WallFieldCreated(WallField sender)
        {
            Brush wallFieldBrush = new SolidBrush(Color.Gray);
            int wallFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int wallFieldY = graphicLocationY + sender.Row * this.fieldSize;
            this.matrixGraphic.FillRectangle
                (wallFieldBrush, wallFieldX, wallFieldY, this.fieldSize, this.fieldSize);
            wallFieldBrush.Dispose();
        }       
        public void SnakeField_SnakeFieldCreated(SnakeField sender)
        {
            Brush snakeFieldBrush = new SolidBrush(Color.ForestGreen);   
            int snakeFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int snakeFieldY = graphicLocationY + sender.Row * this.fieldSize;
            this.matrixGraphic.FillRectangle
                (snakeFieldBrush,snakeFieldX,snakeFieldY, this.fieldSize,this.fieldSize);
            snakeFieldBrush.Dispose();
        }      
        public void FoodField_FoodFieldCreated(FoodField sender)
        {
            Brush FoodFieldBrush = new SolidBrush(Color.DarkGreen);
            int foodFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int foodFiledY = graphicLocationY + sender.Row * this.fieldSize;
            this.matrixGraphic.FillRectangle
                (FoodFieldBrush, foodFieldX, foodFiledY, this.fieldSize,this.fieldSize);
            FoodFieldBrush.Dispose();
        }
        public void EmptyField_EmptyFieldCreated(EmptyField sender)
        {
            Brush EmptyFieldBrush = new SolidBrush(Color.LightGoldenrodYellow);
            int emptyFieldX = graphicLocationX + sender.Col * this.fieldSize;
            int emptyFiledY = graphicLocationY + sender.Row * this.fieldSize;
            this.matrixGraphic.FillRectangle
                (EmptyFieldBrush, emptyFieldX, emptyFiledY, this.fieldSize, this.fieldSize);
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
