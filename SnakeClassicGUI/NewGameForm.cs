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
    public partial class NewGameForm : Form
    {
        private SnakeMainForm ownerForm;
        public NewGameForm(SnakeMainForm owner)
        {
            InitializeComponent();
            this.ownerForm = (SnakeMainForm)owner;

            ConfigureFormControls();
        }

        private void ConfigureFormControls()
        {
            comboBoxTimeInterval.DataSource = new BindingSource(this.ownerForm.Speed, null);
            comboBoxTimeInterval.DisplayMember = "Value";
            comboBoxTimeInterval.ValueMember = "Key";
            comboBoxTimeInterval.SelectedValue = SnakeClassicGUI.Properties.Game.Default.Speed;
            comboBoxPixelSize.SelectedItem = SnakeClassicGUI.Properties.Game.Default.PixelSize;
            if (SnakeClassicGUI.Properties.Game.Default.Walls)
            {
                checkBoxBorderWalls.Checked = true;
            }
            if (SnakeClassicGUI.Properties.Game.Default.SmoothGraphics)
            {
                checkBoxSmoothGraphic.Checked = true;
            }
            switch (SnakeClassicGUI.Properties.Game.Default.Field)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
                default:
                    break;
            }
            textBoxPlayerName.Text = SnakeClassicGUI.Properties.Game.Default.PlayerName;
        }       

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            int snakeTimeInterval;
            int fieldSize;
            int rows;
            int cols;
            bool tooSmall;
            bool includeBorderWalls;
            bool includeSmoothGraphics;
            gatherFormInformation(out snakeTimeInterval, out fieldSize, out rows, out cols,out tooSmall,out includeBorderWalls,out includeSmoothGraphics);

            int ownerFormSizeX = 30 + cols * fieldSize; 
            int ownerFormSizeY = 85 + rows * fieldSize; //offset from the menuToolStrip and statusToolStrip

            ownerForm.ConfigureForm(ownerFormSizeX, ownerFormSizeY,tooSmall);
                     
            Close();
           
            ownerForm.UserSnakeControl = new UserControls(ownerForm);
            ownerForm.CreateGraphic(ownerForm,cols, rows, fieldSize,snakeTimeInterval,includeSmoothGraphics);

            ownerForm.GamePlatform = new GameMatrix(rows, cols,includeBorderWalls);
            ownerForm.TheSnake = new Snake(ownerForm.GamePlatform,snakeTimeInterval);
            ownerForm.TheSnake.CreateBasicSnake();

            ownerForm.TheSnake.GameOver += new Snake.GameOverEventHandler(ownerForm.theSnake_GameOver);
            ownerForm.TheSnake.RunChange += new Snake.SnakeRunningChangeEventHandler(ownerForm.theSnake_RunChange);
            ownerForm.Paint += new System.Windows.Forms.PaintEventHandler(ownerForm.SnakeMainForm_Paint);
            ownerForm.LostFocus += new EventHandler(ownerForm.form_LostFocus);
          

            ownerForm.newGameToolStripMenuItem.Visible = false;
            ownerForm.surrenderToolStripMenuItem.Visible = true;
            ownerForm.ElapsedTime = new DateTime(1,1,1,0,0,0);

            if (checkBoxDefGameOptions.Checked)
            {
                SaveGameSettings(snakeTimeInterval, fieldSize, includeBorderWalls, includeSmoothGraphics);
            }
        }

       

        private void SaveGameSettings(int snakeTimeInterval, int fieldSize, bool includeBorderWalls, bool includeSmoothGraphics)
        {
            SnakeClassicGUI.Properties.Game.Default.Speed = snakeTimeInterval;
            SnakeClassicGUI.Properties.Game.Default.PixelSize = (fieldSize / 5).ToString();
            SnakeClassicGUI.Properties.Game.Default.Walls = includeBorderWalls;
            SnakeClassicGUI.Properties.Game.Default.SmoothGraphics = includeSmoothGraphics;
            if (radioButton1.Checked)
            {
                SnakeClassicGUI.Properties.Game.Default.Field = 1;
            }
            if (radioButton2.Checked)
            {
                SnakeClassicGUI.Properties.Game.Default.Field = 2;
            }
            if (radioButton3.Checked)
            {
                SnakeClassicGUI.Properties.Game.Default.Field = 3;
            }
            SnakeClassicGUI.Properties.Game.Default.Save();
        }

        private void gatherFormInformation
            (out int timeInterval, out int fieldSize, out int rows, out int cols,out bool tooSmall,out bool includeBorderWalls,out bool includeSmoothGraphics)
        {
            timeInterval = int.Parse(comboBoxTimeInterval.SelectedValue.ToString());
            fieldSize = int.Parse(comboBoxPixelSize.Text)*5;
            tooSmall = false;
            includeBorderWalls = false;
            includeSmoothGraphics = true;

            rows = 0;
            cols = 0;

            if (radioButton1.Checked)
            {
                rows = 25;
                cols = 40;
                ownerForm.FieldSizeIndex = 1;
            }
            if (radioButton2.Checked)
            {
                rows = 20;
                cols = 35;
                ownerForm.FieldSizeIndex = 2;
            }
            if (radioButton3.Checked)
            {
                rows = 15;
                cols = 25;
                ownerForm.FieldSizeIndex = 3;
                if (fieldSize == 10) { tooSmall = true; }
            }

            if (checkBoxBorderWalls.Checked)
            {
                includeBorderWalls = true;
                ownerForm.IncludeBorderIndex = 3;
            }
            else
            {
                ownerForm.IncludeBorderIndex = 1;
            }

            if (checkBoxSmoothGraphic.Checked)
            {
                includeSmoothGraphics = true;
            }
            else
            {
                includeSmoothGraphics = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxSmoothGraphic_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox realSender = (CheckBox)sender;
            if (realSender.Checked)
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning2.ForeColor = Color.Red;
            }
            else
            {
                labelWarning.ForeColor = Color.Black;
                labelWarning2.ForeColor = Color.Black;
            }
        }

        private void buttonPlayerNameChange_Click(object sender, EventArgs e)
        {
            FormGetName getPlayerName = new FormGetName();
            getPlayerName.ShowDialog();
            if (getPlayerName.isOkClicked)
            {
                SnakeClassicGUI.Properties.Game.Default.PlayerName = getPlayerName.GetName;
            }
            textBoxPlayerName.Text = SnakeClassicGUI.Properties.Game.Default.PlayerName;
        }

    }
}
