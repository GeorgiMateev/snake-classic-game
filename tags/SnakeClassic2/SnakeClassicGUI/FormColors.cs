using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SnakeGraphicEngine;

namespace SnakeClassicGUI
{
    public partial class FormColors : Form
    {
        private SnakeMainForm ownerForm;
        public FormColors(SnakeMainForm ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
            this.Paint += new PaintEventHandler(FormColors_Paint);
        }

        void FormColors_Paint(object sender, PaintEventArgs e)
        {
            this.DisplayChosenColors();
        }

        private void DisplayChosenColors()
        {
            Graphics sampleColors = pictureBoxSampleColors.CreateGraphics();

            Brush emptyFieldBr =new SolidBrush( SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentEmptyFieldColor);
            sampleColors.FillRectangle(emptyFieldBr, 0, 2, 120, 20);

            Brush snakeBr = new SolidBrush(SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentSnakeFieldColor);
            sampleColors.FillRectangle(snakeBr, 0,30,120,20);

            Brush foodBr = new SolidBrush(SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentFoodFieldColor);
            sampleColors.FillRectangle(foodBr, 0, 60, 120, 20);

            Brush wallBr = new SolidBrush(SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentWallFieldColor);
            sampleColors.FillRectangle(wallBr, 0, 90, 120, 20);

            emptyFieldBr.Dispose();
            wallBr.Dispose();
            snakeBr.Dispose();
            foodBr.Dispose();
            sampleColors.Dispose();
        }

        private void buttonChangeEFieldColor_Click(object sender, EventArgs e)
        {
            colorDialogGraphic.ShowDialog();
            SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentEmptyFieldColor = colorDialogGraphic.Color;
            this.Invalidate();            
        }
        private void buttonChangeSnakeColor_Click(object sender, EventArgs e)
        {
            colorDialogGraphic.ShowDialog();
            SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentSnakeFieldColor = colorDialogGraphic.Color;
            this.Invalidate();
        }

        private void buttonFoodColor_Click(object sender, EventArgs e)
        {
            colorDialogGraphic.ShowDialog();
            SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentFoodFieldColor = colorDialogGraphic.Color;
            this.Invalidate();
        }

        private void buttonWallColor_Click(object sender, EventArgs e)
        {
            colorDialogGraphic.ShowDialog();
            SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentWallFieldColor = colorDialogGraphic.Color;
            this.Invalidate();
        }

        private void buttonRestoreDefault_Click(object sender, EventArgs e)
        {
            SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentWallFieldColor =
                SnakeGraphicEngine.Properties.GraphicColorSettings.Default.DefaultWallFieldColor;

            SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentSnakeFieldColor =
                SnakeGraphicEngine.Properties.GraphicColorSettings.Default.DefaultSnakeFieldColor;

            SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentFoodFieldColor =
                SnakeGraphicEngine.Properties.GraphicColorSettings.Default.DefaultFoodFieldColor;

            SnakeGraphicEngine.Properties.GraphicColorSettings.Default.CurrentEmptyFieldColor =
                SnakeGraphicEngine.Properties.GraphicColorSettings.Default.DefaultEmptyFieldColor;
            this.Invalidate();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SnakeGraphicEngine.Properties.GraphicColorSettings.Default.Save();
            this.Close();
            ownerForm.Invalidate();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
