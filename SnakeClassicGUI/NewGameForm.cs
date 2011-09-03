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
        private Dictionary<int,string> speed;

        public Dictionary<int,string> Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private SnakeMainForm ownerForm;
        public NewGameForm(SnakeMainForm owner)
        {
            InitializeComponent();
            this.ownerForm = (SnakeMainForm)owner;
           
            speed = new Dictionary<int,string>();
            speed.Add(500, "2 Fields/Sec");
            speed.Add(200,"5 Fields/Sec");
            speed.Add( 125,"8 Fields/Sec");
            speed.Add(100,"10 Fields/Sec");
            speed.Add(75,"13 Fields/Sec");
            speed.Add(65,"15 Fields/Sec");
            speed.Add(50,"20 Fields/Sec");
            speed.Add(30,"30 Fields/Sec");
            speed.Add(25,"40 Fields/Sec");
            speed.Add(20,"50 Fields/Sec");
            speed.Add(15,"70 Fields/Sec");
            speed.Add(10,"100 Fields/Sec");

            comboBoxTimeInterval.DataSource = new BindingSource(Speed,null);
            comboBoxTimeInterval.DisplayMember = "Value";
            comboBoxTimeInterval.ValueMember = "Key";
            comboBoxTimeInterval.SelectedValue = 50;
            comboBoxPixelSize.SelectedIndex = 1;
        }       

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            int snakeTimeInterval;
            int fieldSize;
            int rows;
            int cols;
            bool tooSmall;
            bool includeBorderWalls;
            gatherFormInformation(out snakeTimeInterval, out fieldSize, out rows, out cols,out tooSmall,out includeBorderWalls);

            int ownerFormSizeX = 30 + cols * fieldSize;
            int ownerFormSizeY = 110 + rows * fieldSize;

            ownerForm.ConfigureForm(ownerFormSizeX, ownerFormSizeY,tooSmall);
                     
            Close();
           
            ownerForm.UserSnakeControl = new UserControls(ownerForm);
            ownerForm.CreateGraphic(ownerForm,cols, rows, fieldSize);

            ownerForm.GamePlatform = new GameMatrix(rows, cols,includeBorderWalls);
            ownerForm.TheSnake = new Snake(ownerForm.GamePlatform,snakeTimeInterval);
            ownerForm.TheSnake.CreateBasicSnake();
            ownerForm.TheSnake.GameOver += new Snake.GameOverEventHandler(ownerForm.theSnake_GameOver);
            ownerForm.TheSnake.RunChange += new Snake.SnakeRunningChangeEventHandler(ownerForm.theSnake_RunChange);
            ownerForm.Paint += new System.Windows.Forms.PaintEventHandler(ownerForm.SnakeMainForm_Paint);
          

            ownerForm.newGameToolStripMenuItem.Enabled = false;
            ownerForm.surrenderToolStripMenuItem.Enabled = true;
            ownerForm.ElapsedTime = new DateTime(1,1,1,0,0,0);
        }

        private void gatherFormInformation
            (out int timeInterval, out int fieldSize, out int rows, out int cols,out bool tooSmall,out bool includeBorderWalls)
        {
            timeInterval = int.Parse(comboBoxTimeInterval.SelectedValue.ToString());
            fieldSize = int.Parse(comboBoxPixelSize.Text)*5;
            tooSmall = false;
            includeBorderWalls = false;

            rows = 0;
            cols = 0;

            if (radioButton1.Checked)
            {
                rows = 25;
                cols = 40;
                
            }
            if (radioButton2.Checked)
            {
                rows = 20;
                cols = 35;
                
            }
            if (radioButton3.Checked)
            {
                rows = 15;
                cols = 25;
                if (fieldSize == 10) { tooSmall = true; }
            }
            if (checkBoxBorderWalls.Checked)
            {
                includeBorderWalls = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
