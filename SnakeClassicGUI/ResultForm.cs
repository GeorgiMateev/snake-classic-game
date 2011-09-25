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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            Result.DisplayResults(dataGridViewResult);
            labelAllRecNumber.Text ="All records:" + Result.AllRecordsNumber().ToString();
        }

        private void buttonShowNumberResults_Click(object sender, EventArgs e)
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
                textBoxMessages.Text = err.Message;
            }
            catch (ArgumentOutOfRangeException err)
            {
                textBoxMessages.Text = err.Message;
            }
        }

        private void buttonDeleteFrom_Click(object sender, EventArgs e)
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
                textBoxMessages.Text = err.Message;
            }
            catch (ArgumentOutOfRangeException err)
            {
                textBoxMessages.Text = err.Message;
            }
            Result.DisplayResults(dataGridViewResult, 5);
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            MessageBoxButtons deleteDialog = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Delete all records?", "Delete records", deleteDialog, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Result.DeleteFrom(0);
            }
            Result.DisplayResults(dataGridViewResult, 1);
            labelAllRecNumber.Text = "All records:" + Result.AllRecordsNumber().ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            Result.DisplayResults(dataGridViewResult);
        }
    }
}
