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

        public Graphics MatrixGraphic
        {
            get { return matrixGraphic; }
            set { matrixGraphic = value; }
        }
        public GameGrapric(Form currentForm)
        {
            this.currentForm = currentForm;
            this.matrixGraphic = this.currentForm.CreateGraphics();
            this.matrixGraphic.PageUnit = GraphicsUnit.Millimeter;
            SnakeField.SnakeFieldCreated += new SnakeField.SnakeFieldCreateEventHandler(SnakeField_SnakeFieldCreated);
            DrawEmptyField();
        }       

        private void DrawEmptyField()
        {           
            Brush emptyFieldBrush = new SolidBrush(Color.WhiteSmoke);
            Rectangle borderRectangle = new Rectangle(50, 35, 150, 150);
            this.matrixGraphic.Clip = new Region(borderRectangle);            
            this.matrixGraphic.FillRectangle(emptyFieldBrush, this.matrixGraphic.ClipBounds);                       
        }
        void SnakeField_SnakeFieldCreated(object sender)
        {
            SnakeField unPackedSender = (SnakeField)sender;            
            Brush snakeFieldBrush = new SolidBrush(Color.GreenYellow);
            this.matrixGraphic.FillRectangle
                (snakeFieldBrush, unPackedSender.Col * 5 - 5, unPackedSender.Row * 5 - 5, 5, 5);
        }
        
    }
}
