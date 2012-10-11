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
                        if(this.currentForm.TheSnake.Direction != Directions.Right)
                            this.currentForm.TheSnake.Direction = Directions.Left;
                        break;
                    case Keys.Right:
                        if(this.currentForm.TheSnake.Direction != Directions.Left)
                            this.currentForm.TheSnake.Direction = Directions.Right;
                        break;
                    case Keys.Up:
                        if (this.currentForm.TheSnake.Direction != Directions.Down)
                            this.currentForm.TheSnake.Direction = Directions.Up;
                        break;
                    case Keys.Down:
                        if (this.currentForm.TheSnake.Direction != Directions.Up)
                            currentForm.TheSnake.Direction = Directions.Down;
                        break;
                    case Keys.Space:
                        this.currentForm.TheSnake.StartOrStopSnakeTimer();
                        this.currentForm.StartOrStopGameDurationTimer();
                        break;
                    default:
                        throw new ApplicationException("Play only with the arrows and space bar");
                        break;
                }
	        }
            catch (ApplicationException err)
            {
                currentForm.toolStripStatusLabelRunning.Text = err.Message;
                currentForm.toolStripStatusLabelElapsedTime.Visible = false;
                currentForm.toolStripStatusLabelResult.Visible = false;

                Timer errorTimer = new Timer();
                errorTimer.Tick += new EventHandler(errorTimer_Tick);
                errorTimer.Interval = 4000;                
                errorTimer.Start();
            }

        }

        void errorTimer_Tick(object sender, EventArgs e)
        {
            currentForm.toolStripStatusLabelRunning.Text = "Ready";
            currentForm.toolStripStatusLabelElapsedTime.Visible = true;
            currentForm.toolStripStatusLabelResult.Visible = true;
            ((Timer)sender).Stop();
            ((Timer)sender).Tick -= new EventHandler(errorTimer_Tick);
        }                    
    }
}
