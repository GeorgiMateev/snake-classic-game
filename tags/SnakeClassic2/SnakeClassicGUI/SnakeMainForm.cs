using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SnakeClassLib;
using SnakeGraphicEngine;


namespace SnakeClassicGUI
{
    public partial class SnakeMainForm : Form
    {                 
        
        private Snake theSnake;
        private UserControls userSnakeControl;
        private GameMatrix gamePlatform;
        private GameGrapric gamePlatformGraphic;
        private NewGameForm newGameForm;
        private FormGameOver gameOverForm;
        private FormColors formColors;
        private DateTime elapsedTime;
        private Dictionary<int, int> speed;
        private Dictionary<int, string> fieldSize;
        private int fieldSizeIndex;
        private int includeBorderIndex;

        public int IncludeBorderIndex
        {
            get { return includeBorderIndex; }
            set { includeBorderIndex = value; }
        }        
        public int FieldSizeIndex
        {
            get { return fieldSizeIndex; }
            set { fieldSizeIndex = value; }
        }

        public Dictionary<int, string> FieldSize
        {
            get { return fieldSize; }
            set { fieldSize = value; }
        }
        public Dictionary<int, int> Speed
        {
            get { return speed; }
            set { speed = value; }
        }   
  
        public FormGameOver GameOverForm
        {
            get { return gameOverForm; }
            set { gameOverForm = value; }
        }
        public NewGameForm NewGameForm
        {
            get { return newGameForm; }
            set { newGameForm = value; }
        }
        public FormColors FormColors
        {
            get { return formColors; }
            set { formColors = value; }
        }

        public GameGrapric GamePlatformGraphic
        {
            get { return gamePlatformGraphic; }
            set { gamePlatformGraphic = value; }
        }
        public GameMatrix GamePlatform
        {
            get { return gamePlatform; }
            set { gamePlatform = value; }
        }
        public UserControls UserSnakeControl
        {
            get { return userSnakeControl; }
            set { userSnakeControl = value; }
        }
        public Snake TheSnake
        {
            get { return theSnake; }
            set { theSnake = value; }
        }
        public DateTime ElapsedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; }
        }


        public SnakeMainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            ConfigureDictionaries();
        }

        private void ConfigureDictionaries()
        {
            speed = new Dictionary<int, int>();
            speed.Add(500, 2);
            speed.Add(200, 5);
            speed.Add(125, 8);
            speed.Add(100, 10);
            speed.Add(75, 13);
            speed.Add(65, 15);
            speed.Add(50, 20);
            speed.Add(30, 30);
            speed.Add(25, 40);
            speed.Add(20, 50);
            speed.Add(15, 70);
            speed.Add(10, 100);
            fieldSize = new Dictionary<int, string>();
            fieldSize.Add(1, "25X40");
            fieldSize.Add(2, "20X35");
            fieldSize.Add(3, "15X25");
        }

        
        public void CreateGraphic(Form givenForm,int cols,int rows,int pixelSize,int snakeTimeInterval,bool includeSmoothGraphics)
        {
           
            gamePlatformGraphic = new GameGrapric(givenForm,10,25,cols,rows,pixelSize,snakeTimeInterval,includeSmoothGraphics);            
            
        }

        public void theSnake_RunChange(object sender, SnakeRunningEventArgs e)
        {

            toolStripStatusLabelRunning.Text = e.Status ;
        }

        public void form_LostFocus(object sender, EventArgs e)
        {
            this.TheSnake.SnakeTimer.Stop();
            this.toolStripStatusLabelRunning.Text = "Stopped";
        }

        public void theSnake_GameOver(object sender, GameOverEventArgs e)
        {
            this.TheSnake.SnakeTimer.Stop();
            this.toolStripStatusLabelRunning.Text = "Game Over";
            this.timerGameDuration.Stop();
            this.GameOverForm = new FormGameOver(this);
            this.GameOverForm.ShowDialog();
            
        }

        public void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.NewGameForm = new NewGameForm(this);
            this.NewGameForm.ShowDialog();               
        }

        internal void ConfigureForm(int ownerFormSizeX, int ownerFormSizeY,bool tooSmall)
        {
            if (tooSmall)
            {
                this.Width = ownerFormSizeX + 120;
                this.Height = ownerFormSizeY;
            }
            else
            {
                this.Width = ownerFormSizeX;
                this.Height = ownerFormSizeY;
            }
            this.DesktopLocation = new Point(5, 5);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.BackgroundImage = null;
            this.buttonNewGame.Enabled = false;
            this.buttonOptions.Enabled = false;
            this.buttonExit.Enabled = false;
            this.buttonResults.Enabled = false;
            this.buttonResults.Visible = false;
            this.buttonNewGame.Visible = false;
            this.buttonOptions.Visible = false;
            this.buttonExit.Visible = false;
        }

        internal void StartOrStopGameDurationTimer()
        {
            if (this.timerGameDuration.Enabled==false)
            {
                this.timerGameDuration.Enabled = true;
            }
            else
            {
                this.timerGameDuration.Enabled = false;
            }
        }
        private void timerGameDuration_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.AddSeconds(1);
            toolStripStatusLabelResult.Text = "";
            toolStripStatusLabelResult.Text = "Snake Lenght: " + TheSnake.SnakeBody.Count;
            toolStripStatusLabelTurn.Text = "";
            toolStripStatusLabelTurn.Text = "Changed direction: " + TheSnake.ChangedDirectionCount;
            toolStripStatusLabelElapsedTime.Text = "Time: " + elapsedTime.ToLongTimeString();
           
        }
        
        public void surrenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TheSnake.CallGameOver();
        }

        public void SnakeMainForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            this.gamePlatformGraphic.RePaintPlatform(this.gamePlatform.Matrix);         
       
        }       

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            MessageBoxButtons exitDialog = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(this,"Do you really want to exit?","Exit",exitDialog);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void colorsToolStripMenuColors_Click(object sender, EventArgs e)
        {
            this.formColors = new FormColors(this);
            this.formColors.ShowDialog();
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            ResultForm resultsForm = new ResultForm();
            resultsForm.Show();
        }

      
    }
}
