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
        public SnakeMainForm()
        {
            InitializeComponent();           
            
        }
        private GameMatrix gamePlatform;
        private Snake theSnake;
        private UserControls userSnakeControl;

        public Snake TheSnake
        {
            get { return theSnake; }
            set { theSnake = value; }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            int timeInterval = int.Parse(comboBoxTimeInterval.Text);
            gamePlatform = new GameMatrix(30, 30);
            theSnake = new Snake(gamePlatform,timeInterval);
            theSnake.CreateBasicSnake();
            userSnakeControl = new UserControls(StartGUI.snakeMainForm);
            panelNewGame.Enabled = false;
            theSnake.GameOver += new Snake.GameOverEventHandler(theSnake_GameOver);
            StartGUI.snakeMainForm.Focus();
            theSnake.RunChange += new Snake.SnakeRunningChangeEventHandler(theSnake_RunChange);
        }

        void theSnake_RunChange(object sender, SnakeRunningEventArgs e)
        {
            textBoxSnakeCondition.Text = e.Status;
        }

        void theSnake_GameOver(object sender, GameOverEventArgs e)
        {
            theSnake.StartOrStopSnakeTimer();
            panelNewGame.Enabled = true;
            textBoxResult.Text = e.SnakeSize.ToString();
        }           
                       
    }
}
