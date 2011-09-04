using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void currentForm_KeyDown(object sender, KeyEventArgs e)
        {
            try{
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        this.currentForm.TheSnake.Direction = Directions.Left; this.currentForm.TheSnake.ChangedDirectionCount++;
                        break;
                    case Keys.Right:
                        this.currentForm.TheSnake.Direction = Directions.Right; this.currentForm.TheSnake.ChangedDirectionCount++;
                        break;
                    case Keys.Up:
                        this.currentForm.TheSnake.Direction = Directions.Up; this.currentForm.TheSnake.ChangedDirectionCount++;
                        break;
                    case Keys.Down:
                        currentForm.TheSnake.Direction = Directions.Down; this.currentForm.TheSnake.ChangedDirectionCount++;
                        break;
                    case Keys.Space:
                        this.currentForm.TheSnake.StartOrStopSnakeTimer(); this.currentForm.StartOrStopGameDurationTimer();
                        break;
                    default:
                        throw new ApplicationException("Play only with the arrows and space bar");
                        break;
                }
	        }
            catch (ApplicationException err)
            {
                currentForm.textBoxError.Text = err.Message;
            }

        } 
       
        
                    
    }
}
