namespace SnakeClassicGUI
{
    partial class NewGameForm
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxTimeInterval = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBoxFieldSize = new System.Windows.Forms.GroupBox();
            this.labelPixelSize = new System.Windows.Forms.Label();
            this.comboBoxPixelSize = new System.Windows.Forms.ComboBox();
            this.checkBoxBorderWalls = new System.Windows.Forms.CheckBox();
            this.groupBoxFieldSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(12, 146);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 7;
            this.buttonNewGame.Text = "New game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(186, 146);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxTimeInterval
            // 
            this.comboBoxTimeInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTimeInterval.FormattingEnabled = true;
            this.comboBoxTimeInterval.Location = new System.Drawing.Point(12, 26);
            this.comboBoxTimeInterval.Name = "comboBoxTimeInterval";
            this.comboBoxTimeInterval.Size = new System.Drawing.Size(99, 21);
            this.comboBoxTimeInterval.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(38, 13);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Speed";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "25 X 40";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "20 X 35";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "15 X 25";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBoxFieldSize
            // 
            this.groupBoxFieldSize.Controls.Add(this.radioButton3);
            this.groupBoxFieldSize.Controls.Add(this.radioButton2);
            this.groupBoxFieldSize.Controls.Add(this.radioButton1);
            this.groupBoxFieldSize.Location = new System.Drawing.Point(145, 12);
            this.groupBoxFieldSize.Name = "groupBoxFieldSize";
            this.groupBoxFieldSize.Size = new System.Drawing.Size(116, 128);
            this.groupBoxFieldSize.TabIndex = 12;
            this.groupBoxFieldSize.TabStop = false;
            this.groupBoxFieldSize.Text = "Field Size";
            // 
            // labelPixelSize
            // 
            this.labelPixelSize.AutoSize = true;
            this.labelPixelSize.Location = new System.Drawing.Point(12, 68);
            this.labelPixelSize.Name = "labelPixelSize";
            this.labelPixelSize.Size = new System.Drawing.Size(52, 13);
            this.labelPixelSize.TabIndex = 12;
            this.labelPixelSize.Text = "Pixel Size";
            // 
            // comboBoxPixelSize
            // 
            this.comboBoxPixelSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPixelSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPixelSize.FormattingEnabled = true;
            this.comboBoxPixelSize.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2"});
            this.comboBoxPixelSize.Location = new System.Drawing.Point(15, 84);
            this.comboBoxPixelSize.Name = "comboBoxPixelSize";
            this.comboBoxPixelSize.Size = new System.Drawing.Size(96, 21);
            this.comboBoxPixelSize.TabIndex = 2;
            // 
            // checkBoxBorderWalls
            // 
            this.checkBoxBorderWalls.AutoSize = true;
            this.checkBoxBorderWalls.Location = new System.Drawing.Point(15, 123);
            this.checkBoxBorderWalls.Name = "checkBoxBorderWalls";
            this.checkBoxBorderWalls.Size = new System.Drawing.Size(124, 17);
            this.checkBoxBorderWalls.TabIndex = 6;
            this.checkBoxBorderWalls.Text = "Include Border Walls";
            this.checkBoxBorderWalls.UseVisualStyleBackColor = true;
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.checkBoxBorderWalls);
            this.Controls.Add(this.comboBoxPixelSize);
            this.Controls.Add(this.labelPixelSize);
            this.Controls.Add(this.groupBoxFieldSize);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.comboBoxTimeInterval);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNewGame);
            this.Name = "NewGameForm";
            this.Text = "New Game";
            this.groupBoxFieldSize.ResumeLayout(false);
            this.groupBoxFieldSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxTimeInterval;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBoxFieldSize;
        private System.Windows.Forms.Label labelPixelSize;
        private System.Windows.Forms.ComboBox comboBoxPixelSize;
        private System.Windows.Forms.CheckBox checkBoxBorderWalls;
    }
}