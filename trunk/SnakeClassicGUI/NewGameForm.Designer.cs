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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGameForm));
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
            this.checkBoxSmoothGraphic = new System.Windows.Forms.CheckBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelWarning2 = new System.Windows.Forms.Label();
            this.checkBoxDefGameOptions = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.buttonPlayerNameChange = new System.Windows.Forms.Button();
            this.groupBoxFieldSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(15, 331);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(124, 28);
            this.buttonNewGame.TabIndex = 8;
            this.buttonNewGame.Text = "New game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(145, 331);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(127, 28);
            this.buttonCancel.TabIndex = 9;
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
            this.groupBoxFieldSize.TabIndex = 3;
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
            this.comboBoxPixelSize.Location = new System.Drawing.Point(12, 84);
            this.comboBoxPixelSize.Name = "comboBoxPixelSize";
            this.comboBoxPixelSize.Size = new System.Drawing.Size(99, 21);
            this.comboBoxPixelSize.TabIndex = 2;
            // 
            // checkBoxBorderWalls
            // 
            this.checkBoxBorderWalls.AutoSize = true;
            this.checkBoxBorderWalls.Location = new System.Drawing.Point(15, 123);
            this.checkBoxBorderWalls.Name = "checkBoxBorderWalls";
            this.checkBoxBorderWalls.Size = new System.Drawing.Size(124, 17);
            this.checkBoxBorderWalls.TabIndex = 4;
            this.checkBoxBorderWalls.Text = "Include Border Walls";
            this.checkBoxBorderWalls.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmoothGraphic
            // 
            this.checkBoxSmoothGraphic.AutoSize = true;
            this.checkBoxSmoothGraphic.Location = new System.Drawing.Point(15, 147);
            this.checkBoxSmoothGraphic.Name = "checkBoxSmoothGraphic";
            this.checkBoxSmoothGraphic.Size = new System.Drawing.Size(107, 17);
            this.checkBoxSmoothGraphic.TabIndex = 5;
            this.checkBoxSmoothGraphic.Text = "Smooth Graphics";
            this.checkBoxSmoothGraphic.UseVisualStyleBackColor = true;
            this.checkBoxSmoothGraphic.CheckedChanged += new System.EventHandler(this.checkBoxSmoothGraphic_CheckedChanged);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(12, 167);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(231, 13);
            this.labelWarning.TabIndex = 14;
            this.labelWarning.Text = "Warning!More hardware resources will be used!";
            // 
            // labelWarning2
            // 
            this.labelWarning2.AutoSize = true;
            this.labelWarning2.Location = new System.Drawing.Point(12, 180);
            this.labelWarning2.Name = "labelWarning2";
            this.labelWarning2.Size = new System.Drawing.Size(154, 13);
            this.labelWarning2.TabIndex = 15;
            this.labelWarning2.Text = "In higher speed may cause lag!";
            // 
            // checkBoxDefGameOptions
            // 
            this.checkBoxDefGameOptions.AutoSize = true;
            this.checkBoxDefGameOptions.Location = new System.Drawing.Point(15, 210);
            this.checkBoxDefGameOptions.Name = "checkBoxDefGameOptions";
            this.checkBoxDefGameOptions.Size = new System.Drawing.Size(176, 17);
            this.checkBoxDefGameOptions.TabIndex = 6;
            this.checkBoxDefGameOptions.Text = "Save these options as prefered.";
            this.checkBoxDefGameOptions.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 64);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(15, 245);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(68, 13);
            this.labelPlayerName.TabIndex = 19;
            this.labelPlayerName.Text = "Player name:";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Enabled = false;
            this.textBoxPlayerName.Location = new System.Drawing.Point(89, 238);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.ReadOnly = true;
            this.textBoxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerName.TabIndex = 20;
            // 
            // buttonPlayerNameChange
            // 
            this.buttonPlayerNameChange.Location = new System.Drawing.Point(195, 235);
            this.buttonPlayerNameChange.Name = "buttonPlayerNameChange";
            this.buttonPlayerNameChange.Size = new System.Drawing.Size(77, 23);
            this.buttonPlayerNameChange.TabIndex = 7;
            this.buttonPlayerNameChange.Text = "Change";
            this.buttonPlayerNameChange.UseVisualStyleBackColor = true;
            this.buttonPlayerNameChange.Click += new System.EventHandler(this.buttonPlayerNameChange_Click);
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 368);
            this.Controls.Add(this.buttonPlayerNameChange);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxDefGameOptions);
            this.Controls.Add(this.labelWarning2);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.checkBoxSmoothGraphic);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBoxSmoothGraphic;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Label labelWarning2;
        private System.Windows.Forms.CheckBox checkBoxDefGameOptions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Button buttonPlayerNameChange;
    }
}