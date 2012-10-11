using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SnakeClassLib;
using DataDealer;
using System.Threading;

namespace SnakeClassicGUI
{
    public partial class FormGameOver : Form
    {
        SnakeMainForm ownerForm;
        private int gameScore;
        private Result currentResult;

        public Result CurrentResult
        {
            get { return currentResult; }
            set { currentResult = value; }
        }

        public int GameScore
        {
            get
            {
                return gameScore = ownerForm.TheSnake.SnakeBody.Count
                    * ownerForm.FieldSizeIndex
                    * ownerForm.Speed[ownerForm.TheSnake.SnakeTimer.Interval]
                    * ownerForm.IncludeBorderIndex;
            }
            set { gameScore = value; }
        }
        
        public FormGameOver(SnakeMainForm ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            this.labelResult.Text = ownerForm.TheSnake.SnakeBody.Count.ToString();
            this.labelSpeed.Text = ownerForm.Speed[ownerForm.TheSnake.SnakeTimer.Interval]+"F/Sec";
            this.labelField.Text = ownerForm.GamePlatform.Rows + " X " + ownerForm.GamePlatform.Colums;
            this.labelScore.Text = this.GameScore.ToString();
            this.textBoxPlayerName.Text = SnakeClassicGUI.Properties.Game.Default.PlayerName;

            //this.buttonNewGame.Click += new EventHandler(buttonClose_Click);
            //this.buttonNewGame.Click += new EventHandler(this.ownerForm.newGameToolStripMenuItem_Click);

            CurrentResult = new Result(this.GameScore,ownerForm.TheSnake.SnakeBody.Count, ownerForm.Speed[ownerForm.TheSnake.SnakeTimer.Interval] + "F/Sec",
                ownerForm.FieldSize[ownerForm.FieldSizeIndex], ownerForm.IncludeBorderIndex);
            DisplayPlace();

            Result.DisplayResults(dataGridViewResult, 5);
            labelAllRecNumber.Text = "All records:" + Result.AllRecordsNumber().ToString();
        }

        

        private void ConfigureNewSnakeMainFormUsability()
        {
            this.ownerForm.StartPosition = FormStartPosition.CenterScreen;
            this.ownerForm.Width = 418;
            this.ownerForm.Height = 587;
            this.ownerForm.newGameToolStripMenuItem.Enabled = true;
            this.ownerForm.surrenderToolStripMenuItem.Enabled = false;
            this.ownerForm.toolStripStatusLabelRunning.Text = "Ready";
            this.ownerForm.toolStripStatusLabelElapsedTime.Text = "";
            this.ownerForm.toolStripStatusLabelResult.Text = "";
            this.ownerForm.BackgroundImage = SnakeClassicGUI.Properties.Resources.SnakeBG;
            this.ownerForm.buttonNewGame.Enabled = true;
            this.ownerForm.buttonOptions.Enabled = true;
            this.ownerForm.buttonExit.Enabled = true;
            this.ownerForm.buttonResults.Enabled = true;
            this.ownerForm.buttonResults.Visible = true;
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
            SnakeField.SnakeFieldSmoothCreation -= new SnakeField.SnakeFieldSmoothCreationEventHandler
                (ownerForm.GamePlatformGraphic.SnakeField_SnakeFieldSmoothCreation);
            EmptyField.EmptyFieldSmoothCreation -= new EmptyField.EmptyFieldSmoothCreationEventHandler
                (ownerForm.GamePlatformGraphic.EmptyField_EmptyFieldSmoothCreation);
            SnakeField.SnakeFieldSmoothCreation -= new SnakeField.SnakeFieldSmoothCreationEventHandler
                (ownerForm.GamePlatformGraphic.SnakeField_SnakeFieldCreated);
            EmptyField.EmptyFieldSmoothCreation -= new EmptyField.EmptyFieldSmoothCreationEventHandler
                (ownerForm.GamePlatformGraphic.EmptyField_EmptyFieldCreated);
            this.ownerForm.Paint -= new System.Windows.Forms.PaintEventHandler(this.ownerForm.SnakeMainForm_Paint);
            this.ownerForm.LostFocus -= new EventHandler(this.ownerForm.form_LostFocus);
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            this.CurrentResult.Owner = SnakeClassicGUI.Properties.Game.Default.PlayerName;
            bool isExecuted = CurrentResult.SaveResult();
            if (isExecuted)
            {
                 toolStripStatusLabel.Text = "The result is saved!";
                 buttonSaveResult.Enabled = false;
                 buttonChangeName.Enabled = false;
            }            
            Result.DisplayResults(dataGridViewResult,5);
        }

        private void DisplayPlace()
        {
            if (CurrentResult.Place == 1)
            {
                labelPlace.Text = "Congratulations! New First Record!";
                labelPlace.ForeColor = Color.Red;
                this.buttonSaveResult_Click(this, new EventArgs());
            }
            if (CurrentResult.Place <=5 && CurrentResult.Place > 1)
            {
                labelPlace.Text = "Your place is " + CurrentResult.CheckResultPlace()+"!";
                labelPlace.ForeColor = Color.Red;
                this.buttonSaveResult_Click(this, new EventArgs());
            }
            if (CurrentResult.Place > 5)
            {
                labelPlace.Text = "Your place is " + CurrentResult.CheckResultPlace();
                this.labelSavingInfo.Visible = true;
                this.buttonSaveResult.Visible = true;
            }
        }

        private void buttonShowTopResult_Click(object sender, EventArgs e)
        {
            try
            {
                string textBoxText = textBoxResultNumber.Text;
                int textBoxNumber = 0;
                if (!int.TryParse(textBoxText, out textBoxNumber))
                {
                    throw new FormatException("Enter only numbers");
                }
                if (textBoxNumber <= 0)
                {
                    throw new ArgumentOutOfRangeException("Enter numbers greater than zero!");
                }
                Result.DisplayResults(dataGridViewResult, textBoxNumber);
            }
           
            catch (FormatException err)
            {
                toolStripStatusLabel.Text = err.Message;
            }
            catch (ArgumentOutOfRangeException err)
            {
                toolStripStatusLabel.Text = err.Message;
            }
        }

        private void buttonDeteFrom_Click(object sender, EventArgs e)
        {
            try
            {
                string textBoxText = textBoxDeleteFrom.Text;
                int textBoxNumber = 0;
                if (!int.TryParse(textBoxText, out textBoxNumber))
                {
                    throw new FormatException("Enter only numbers");
                }
                if (textBoxNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("Enter numbers greater than ot equal to zero!");
                }
                Result.DeleteFrom(textBoxNumber);
                Result.DisplayResults(dataGridViewResult, 5);
                labelAllRecNumber.Text = "All records:" + Result.AllRecordsNumber().ToString();
            }
            catch (FormatException err)
            {
                toolStripStatusLabel.Text = err.Message;
            }
            catch (ArgumentOutOfRangeException err)
            {
                toolStripStatusLabel.Text = err.Message;
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            MessageBoxButtons deleteDialog = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Delete all records?", "Delete records", deleteDialog, MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                Result.DeleteFrom(0);
                toolStripStatusLabel.Text = "All records deleted!";
            }
            Result.DisplayResults(dataGridViewResult, 5);
            
            labelAllRecNumber.Text = "All records:" + Result.AllRecordsNumber().ToString();
        }

        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            FormGetName getPlayerName = new FormGetName();
            getPlayerName.ShowDialog();
            if (getPlayerName.isOkClicked)
            {
                SnakeClassicGUI.Properties.Game.Default.PlayerName = getPlayerName.GetName;
            }
            textBoxPlayerName.Text = SnakeClassicGUI.Properties.Game.Default.PlayerName;
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            Result.DisplayResults(dataGridViewResult);
        }

        private void buttonScoreInfo_MouseHover(object sender, EventArgs e)
        {
            this.textBoxScoreFormula.Visible = true;
        }

        private void buttonScoreInfo_MouseLeave(object sender, EventArgs e)
        {
            this.textBoxScoreFormula.Visible = false;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(FormGameOver_FormClosed);
            this.Close();                                   
        }

        void FormGameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ownerForm.newGameToolStripMenuItem_Click(this, new EventArgs());            
            this.FormClosed -= new FormClosedEventHandler(this.FormGameOver_FormClosed);
        }

        private void gameOverForm_Closing(object sender, EventArgs e)
        {
            this.ownerForm.Invalidate();

            DisconnectOldFormFromEvents();

            StartGUI.snakeMainForm = new SnakeMainForm();

            ConfigureNewSnakeMainFormUsability();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }                         
    }
}
