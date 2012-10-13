namespace SnakeClassicGUI
{
    partial class FormColors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialogGraphic = new System.Windows.Forms.ColorDialog();
            this.buttonEmptyFieldColor = new System.Windows.Forms.Button();
            this.buttonChangeSnakeColor = new System.Windows.Forms.Button();
            this.buttonFoodColor = new System.Windows.Forms.Button();
            this.buttonWallColor = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRestoreDefault = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSampleColors = new System.Windows.Forms.PictureBox();
            this.buttonChangeSnakeHeadColor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSampleColors)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEmptyFieldColor
            // 
            this.buttonEmptyFieldColor.Location = new System.Drawing.Point(7, 26);
            this.buttonEmptyFieldColor.Name = "buttonEmptyFieldColor";
            this.buttonEmptyFieldColor.Size = new System.Drawing.Size(75, 23);
            this.buttonEmptyFieldColor.TabIndex = 0;
            this.buttonEmptyFieldColor.Text = "Empty field";
            this.buttonEmptyFieldColor.UseVisualStyleBackColor = true;
            this.buttonEmptyFieldColor.Click += new System.EventHandler(this.buttonChangeEFieldColor_Click);
            // 
            // buttonChangeSnakeColor
            // 
            this.buttonChangeSnakeColor.Location = new System.Drawing.Point(7, 55);
            this.buttonChangeSnakeColor.Name = "buttonChangeSnakeColor";
            this.buttonChangeSnakeColor.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeSnakeColor.TabIndex = 1;
            this.buttonChangeSnakeColor.Text = "Snake";
            this.buttonChangeSnakeColor.UseVisualStyleBackColor = true;
            this.buttonChangeSnakeColor.Click += new System.EventHandler(this.buttonChangeSnakeColor_Click);
            // 
            // buttonFoodColor
            // 
            this.buttonFoodColor.Location = new System.Drawing.Point(7, 113);
            this.buttonFoodColor.Name = "buttonFoodColor";
            this.buttonFoodColor.Size = new System.Drawing.Size(75, 23);
            this.buttonFoodColor.TabIndex = 2;
            this.buttonFoodColor.Text = "Food";
            this.buttonFoodColor.UseVisualStyleBackColor = true;
            this.buttonFoodColor.Click += new System.EventHandler(this.buttonFoodColor_Click);
            // 
            // buttonWallColor
            // 
            this.buttonWallColor.Location = new System.Drawing.Point(7, 142);
            this.buttonWallColor.Name = "buttonWallColor";
            this.buttonWallColor.Size = new System.Drawing.Size(75, 23);
            this.buttonWallColor.TabIndex = 3;
            this.buttonWallColor.Text = "Wall";
            this.buttonWallColor.UseVisualStyleBackColor = true;
            this.buttonWallColor.Click += new System.EventHandler(this.buttonWallColor_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(276, 118);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 32);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(276, 156);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRestoreDefault
            // 
            this.buttonRestoreDefault.Location = new System.Drawing.Point(276, 12);
            this.buttonRestoreDefault.Name = "buttonRestoreDefault";
            this.buttonRestoreDefault.Size = new System.Drawing.Size(100, 30);
            this.buttonRestoreDefault.TabIndex = 6;
            this.buttonRestoreDefault.Text = "Restore Default";
            this.buttonRestoreDefault.UseVisualStyleBackColor = true;
            this.buttonRestoreDefault.Click += new System.EventHandler(this.buttonRestoreDefault_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonChangeSnakeHeadColor);
            this.groupBox1.Controls.Add(this.pictureBoxSampleColors);
            this.groupBox1.Controls.Add(this.buttonWallColor);
            this.groupBox1.Controls.Add(this.buttonFoodColor);
            this.groupBox1.Controls.Add(this.buttonChangeSnakeColor);
            this.groupBox1.Controls.Add(this.buttonEmptyFieldColor);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change the Color of:";
            // 
            // pictureBoxSampleColors
            // 
            this.pictureBoxSampleColors.Location = new System.Drawing.Point(98, 26);
            this.pictureBoxSampleColors.Name = "pictureBoxSampleColors";
            this.pictureBoxSampleColors.Size = new System.Drawing.Size(127, 139);
            this.pictureBoxSampleColors.TabIndex = 4;
            this.pictureBoxSampleColors.TabStop = false;
            // 
            // buttonChangeSnakeHeadColor
            // 
            this.buttonChangeSnakeHeadColor.Location = new System.Drawing.Point(7, 84);
            this.buttonChangeSnakeHeadColor.Name = "buttonChangeSnakeHeadColor";
            this.buttonChangeSnakeHeadColor.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeSnakeHeadColor.TabIndex = 5;
            this.buttonChangeSnakeHeadColor.Text = "Snake head";
            this.buttonChangeSnakeHeadColor.UseVisualStyleBackColor = true;
            this.buttonChangeSnakeHeadColor.Click += new System.EventHandler(this.buttonChangeSnakeHeadColor_Click);
            // 
            // FormColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 204);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRestoreDefault);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormColors";
            this.Text = "Colors";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSampleColors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialogGraphic;
        private System.Windows.Forms.Button buttonEmptyFieldColor;
        private System.Windows.Forms.Button buttonChangeSnakeColor;
        private System.Windows.Forms.Button buttonFoodColor;
        private System.Windows.Forms.Button buttonWallColor;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRestoreDefault;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxSampleColors;
        private System.Windows.Forms.Button buttonChangeSnakeHeadColor;
    }
}