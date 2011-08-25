using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SnakeInterfaces;
using SnakeClassLib;
using System.Windows.Forms;

namespace SnakeClassicGUI
{
    public class UserControls
    {
        private SnakeMainForm currentForm;
        public UserControls(SnakeMainForm currentForm)
        {
            this.currentForm = currentForm;
            this.currentForm.KeyDown+=new KeyEventHandler(currentForm_KeyDown);
        }
        void currentForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
	        {
                case Keys.Left:
                    this.currentForm.TheSnake.Direction=Directions.Left;
                    break;
		        case Keys.Right:
                    this.currentForm.TheSnake.Direction = Directions.Right;
                    break;
                case Keys.Up:
                    this.currentForm.TheSnake.Direction = Directions.Up;
                    break;
                case Keys.Down:
                    currentForm.TheSnake.Direction = Directions.Down;
                    break;
                case Keys.Space:
                    this.currentForm.TheSnake.StartOrStopSnakeTimer();
                    break;
                default:
                    throw new ApplicationException("Play only with the arrows and space bar");
                    break;
	        }

        } 
       
        
                    
    }
}
