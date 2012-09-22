using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataDealer;

namespace SnakeClassicGUI
{
    public partial class FormGetName : Form
    {
        private Result currentResult;
        public bool isOkClicked;
        private string name;

        public string GetName
        {
            get { return name; }
        }
        public FormGetName()
        {
            InitializeComponent();        
        }

        private void buttonGetName_Click(object sender, EventArgs e)
        {
            this.isOkClicked = true;
            this.name = textBoxName.Text;
            this.Close();
        }

        private void buttonCancelName_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
