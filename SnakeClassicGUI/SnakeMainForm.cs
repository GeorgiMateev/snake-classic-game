using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SnakeInterfaces;
using SnakeGraphicEngine;



namespace SnakeClassicGUI
{
    public partial class SnakeMainForm : Form
    {
        public SnakeMainForm()
        {
            InitializeComponent();           
            
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            int timeInterval = int.Parse(comboBoxTimeInterval.SelectedText);
            GameMatrix gamePlatform = new GameMatrix(30, 30);
            Snake theSnake = new Snake(gamePlatform,timeInterval);            
        }

           
         

        
    }
}
