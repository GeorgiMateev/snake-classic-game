using System.Drawing;
namespace SnakeClassicGUI
{
    partial class FormGameOver
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelField = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.buttonChangeName = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelSavingInfo = new System.Windows.Forms.Label();
            this.buttonShowResults = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 237);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(358, 22);
            this.statusStrip.TabIndex = 39;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelField);
            this.panel1.Controls.Add(this.labelSpeed);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 84);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snake Lenght:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(96, 6);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(31, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Speed:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(96, 31);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(61, 13);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "somespeed";
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelField.Location = new System.Drawing.Point(96, 56);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(29, 13);
            this.labelField.TabIndex = 7;
            this.labelField.Text = "Field";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Field:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.playerName);
            this.panel2.Controls.Add(this.buttonChangeName);
            this.panel2.Controls.Add(this.labelPlayerName);
            this.panel2.Location = new System.Drawing.Point(6, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 38);
            this.panel2.TabIndex = 43;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerName.Location = new System.Drawing.Point(2, 6);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(46, 13);
            this.labelPlayerName.TabIndex = 26;
            this.labelPlayerName.Text = "Player:";
            // 
            // buttonChangeName
            // 
            this.buttonChangeName.Location = new System.Drawing.Point(226, 6);
            this.buttonChangeName.Name = "buttonChangeName";
            this.buttonChangeName.Size = new System.Drawing.Size(115, 23);
            this.buttonChangeName.TabIndex = 1;
            this.buttonChangeName.Text = "Change";
            this.buttonChangeName.UseVisualStyleBackColor = true;
            this.buttonChangeName.Click += new System.EventHandler(this.buttonChangeName_Click);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(99, 6);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(67, 13);
            this.playerName.TabIndex = 27;
            this.playerName.Text = "Player Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonShowResults);
            this.panel3.Controls.Add(this.labelSavingInfo);
            this.panel3.Controls.Add(this.labelPlace);
            this.panel3.Controls.Add(this.labelScore);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonSaveResult);
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 98);
            this.panel3.TabIndex = 44;
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.Location = new System.Drawing.Point(226, 8);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(115, 23);
            this.buttonSaveResult.TabIndex = 2;
            this.buttonSaveResult.Text = "Save Result";
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Visible = false;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(95, 8);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(45, 20);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "0000";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.Location = new System.Drawing.Point(6, 37);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(43, 17);
            this.labelPlace.TabIndex = 18;
            this.labelPlace.Text = "Place";
            // 
            // labelSavingInfo
            // 
            this.labelSavingInfo.AutoSize = true;
            this.labelSavingInfo.Location = new System.Drawing.Point(6, 68);
            this.labelSavingInfo.Name = "labelSavingInfo";
            this.labelSavingInfo.Size = new System.Drawing.Size(188, 13);
            this.labelSavingInfo.TabIndex = 24;
            this.labelSavingInfo.Text = "Only the top 5 records are auto-saved!";
            this.labelSavingInfo.Visible = false;
            // 
            // buttonShowResults
            // 
            this.buttonShowResults.Location = new System.Drawing.Point(226, 37);
            this.buttonShowResults.Name = "buttonShowResults";
            this.buttonShowResults.Size = new System.Drawing.Size(115, 23);
            this.buttonShowResults.TabIndex = 41;
            this.buttonShowResults.Text = "Show all results";
            this.buttonShowResults.UseVisualStyleBackColor = true;
            this.buttonShowResults.Click += new System.EventHandler(this.buttonShowResults_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonNewGame);
            this.panel4.Controls.Add(this.buttonOk);
            this.panel4.Location = new System.Drawing.Point(213, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 72);
            this.panel4.TabIndex = 45;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(19, 35);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(115, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Close";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(19, 6);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(115, 23);
            this.buttonNewGame.TabIndex = 3;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 259);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Name = "FormGameOver";
            this.Text = "Game Over";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gameOverForm_Closing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Button buttonChangeName;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonShowResults;
        private System.Windows.Forms.Label labelSavingInfo;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonOk;
    }
}