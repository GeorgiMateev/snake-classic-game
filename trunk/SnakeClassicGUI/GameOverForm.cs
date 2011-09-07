using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SnakeClassLib;

namespace SnakeClassicGUI
{
    public partial class FormGameOver : Form
    {
        SnakeMainForm ownerForm;
        public FormGameOver(SnakeMainForm ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            this.labelResult.Text = ownerForm.TheSnake.SnakeBody.Count.ToString();
            this.labelChangedDirection.Text = ownerForm.TheSnake.ChangedDirectionCount.ToString();
            this.labelSpeed.Text = ownerForm.NewGameForm.Speed[ownerForm.TheSnake.SnakeTimer.Interval];
            this.labelField.Text = ownerForm.GamePlatform.Rows + " X " + ownerForm.GamePlatform.Colums;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
           this.Close();

           this.ownerForm.Invalidate();
           
           DisconnectOldFormFromEvents();
          
           StartGUI.snakeMainForm = new SnakeMainForm();

           ConfigureNewFormUsability();
        }

        private void ConfigureNewFormUsability()
        {
            this.ownerForm.StartPosition = FormStartPosition.CenterScreen;
            this.ownerForm.Width = 418;
            this.ownerForm.Height = 587;
            this.ownerForm.newGameToolStripMenuItem.Enabled = true;
            this.ownerForm.surrenderToolStripMenuItem.Enabled = false;
            this.ownerForm.toolStripStatusLabelRunning.Text = "Ready";
            this.ownerForm.toolStripStatusLabelElapsedTime.Text = "";
            this.ownerForm.toolStripStatusLabelResult.Text = "";
            this.ownerForm.toolStripStatusLabelTurn.Text = "";
            this.ownerForm.textBoxError.Text = "";
            this.ownerForm.BackgroundImage = SnakeClassicGUI.Properties.Resources._1086_Snake;
            this.ownerForm.buttonNewGame.Enabled = true;
            this.ownerForm.buttonOptions.Enabled = true;
            this.ownerForm.buttonExit.Enabled = true;
            this.ownerForm.buttonNewGame.Visible = true;
            this.ownerForm.buttonOptions.Visible = true;
            this.ownerForm.buttonExit.Visible = true;
        }

        private void DisconnectOldFormFromEvents()
        {
            this.ownerForm.KeyDown -= new KeyEventHandler(ownerForm.UserSnakeControl.currentForm_KeyDown);
            EmptyField.EmptyFieldCreated -= new EmptyField.EmptyFieldCreateEventHandler
                (ownerForm.GamePlatformGraphic.EmptyField_EmptyFieldCreated);
            SnakeField.SnakeFieldCreated -= new SnakeField.SnakeFieldCreateEventHandler
                (ownerForm.GamePlatformGraphic.SnakeField_SnakeFieldCreated);
            FoodField.FoodFieldCreated -= new FoodField.FoodFieldCreateEventHandler
                (ownerForm.GamePlatformGraphic.FoodField_FoodFieldCreated);
            WallField.WallFieldCreated -= new WallField.WallFieldCreateEventHandler
                (ownerForm.GamePlatformGraphic.WallField_WallFieldCreated);
            this.ownerForm.Paint -= new System.Windows.Forms.PaintEventHandler(this.ownerForm.SnakeMainForm_Paint);
        }

 
    }
}
