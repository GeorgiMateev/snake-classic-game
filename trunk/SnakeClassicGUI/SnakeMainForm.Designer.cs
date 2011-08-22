namespace SnakeClassicGUI
{
    partial class SnakeMainForm
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
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxTimeInterval = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.panelNewGame = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxSnakeCondition = new System.Windows.Forms.TextBox();
            this.panelNewGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(2, 11);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time";
            // 
            // comboBoxTimeInterval
            // 
            this.comboBoxTimeInterval.FormattingEnabled = true;
            this.comboBoxTimeInterval.Items.AddRange(new object[] {
            "1000",
            "500",
            "400",
            "300",
            "200",
            "100",
            "50",
            "20"});
            this.comboBoxTimeInterval.Location = new System.Drawing.Point(59, 11);
            this.comboBoxTimeInterval.Name = "comboBoxTimeInterval";
            this.comboBoxTimeInterval.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTimeInterval.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "In miliseconds.1000ms is 1 second.";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(378, 11);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.Text = "New game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // panelNewGame
            // 
            this.panelNewGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNewGame.Controls.Add(this.buttonNewGame);
            this.panelNewGame.Controls.Add(this.label1);
            this.panelNewGame.Controls.Add(this.comboBoxTimeInterval);
            this.panelNewGame.Controls.Add(this.labelTime);
            this.panelNewGame.Location = new System.Drawing.Point(10, 29);
            this.panelNewGame.Name = "panelNewGame";
            this.panelNewGame.Size = new System.Drawing.Size(470, 51);
            this.panelNewGame.TabIndex = 5;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 94);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(71, 94);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 7;
            // 
            // textBoxSnakeCondition
            // 
            this.textBoxSnakeCondition.Enabled = false;
            this.textBoxSnakeCondition.Location = new System.Drawing.Point(189, 93);
            this.textBoxSnakeCondition.Name = "textBoxSnakeCondition";
            this.textBoxSnakeCondition.ReadOnly = true;
            this.textBoxSnakeCondition.Size = new System.Drawing.Size(100, 20);
            this.textBoxSnakeCondition.TabIndex = 8;
            // 
            // SnakeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 354);
            this.Controls.Add(this.textBoxSnakeCondition);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.panelNewGame);
            this.Name = "SnakeMainForm";
            this.Text = "Snake Classic";
            this.panelNewGame.ResumeLayout(false);
            this.panelNewGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxTimeInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Panel panelNewGame;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxSnakeCondition;


    }
}

