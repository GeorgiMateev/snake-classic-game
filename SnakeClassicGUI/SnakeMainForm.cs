﻿using System;
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
        private DateTime elapsedTime;
        
        
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
           // this.Paint += new System.Windows.Forms.PaintEventHandler(SnakeMainForm_Paint);
            //this.Resize += new EventHandler(SnakeMainForm_Resize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

       
        public void CreateGraphic(Form givenForm,int cols,int rows,int pixelSize)
        {
           
            gamePlatformGraphic = new GameGrapric(givenForm,10,25,cols,rows,pixelSize);
            
        }

        public void theSnake_RunChange(object sender, SnakeRunningEventArgs e)
        {

            toolStripStatusLabelRunning.Text = e.Status ;
        }

        public void theSnake_GameOver(object sender, GameOverEventArgs e)
        {
            this.TheSnake.SnakeTimer.Stop();
            this.toolStripStatusLabelRunning.Text = "Game Over";
            this.timerGameDuration.Stop();
            this.GameOverForm = new FormGameOver(this);
            this.GameOverForm.ShowDialog();
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
            toolStripStatusLabelResult.Text = "Result: " + TheSnake.SnakeBody.Count;
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
        void SnakeMainForm_Resize(object sender, EventArgs e)
        {
            this.gamePlatformGraphic.RePaintPlatform(this.gamePlatform.Matrix);  
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}