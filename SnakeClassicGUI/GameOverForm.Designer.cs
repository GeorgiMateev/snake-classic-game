﻿using System.Drawing;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameOver));
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelField = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.textBoxScoreFormula = new System.Windows.Forms.TextBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnakeLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonShowTopResult = new System.Windows.Forms.Button();
            this.textBoxResultNumber = new System.Windows.Forms.TextBox();
            this.buttonDeteFrom = new System.Windows.Forms.Button();
            this.textBoxDeleteFrom = new System.Windows.Forms.TextBox();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.labelSavingInfo = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.buttonChangeName = new System.Windows.Forms.Button();
            this.labelAllRecNumber = new System.Windows.Forms.Label();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonScoreInfo = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelResult = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snake Lenght:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(598, 22);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(69, 29);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Score Is:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(6, 29);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(69, 29);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "0000";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(598, 84);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(145, 29);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "somespeed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Speed";
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelField.Location = new System.Drawing.Point(598, 151);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(68, 29);
            this.labelField.TabIndex = 7;
            this.labelField.Text = "Field";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Field";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(465, 91);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(115, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Close";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(465, 133);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(115, 23);
            this.buttonNewGame.TabIndex = 3;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.Location = new System.Drawing.Point(129, 9);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(115, 38);
            this.buttonSaveResult.TabIndex = 2;
            this.buttonSaveResult.Text = "Save Result";
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Visible = false;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // textBoxScoreFormula
            // 
            this.textBoxScoreFormula.Enabled = false;
            this.textBoxScoreFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxScoreFormula.Location = new System.Drawing.Point(259, 9);
            this.textBoxScoreFormula.Multiline = true;
            this.textBoxScoreFormula.Name = "textBoxScoreFormula";
            this.textBoxScoreFormula.ReadOnly = true;
            this.textBoxScoreFormula.Size = new System.Drawing.Size(185, 163);
            this.textBoxScoreFormula.TabIndex = 13;
            this.textBoxScoreFormula.TabStop = false;
            this.textBoxScoreFormula.Text = "Score =\r\nSnake Lenght * Speed\r\n\r\n* 1 (for big field) or\r\n* 2 (for medium field) o" +
    "r\r\n* 3 (for small field)\r\n\r\n*1 (no walls) or\r\n*3 (walls).";
            this.textBoxScoreFormula.Visible = false;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Score,
            this.Owner,
            this.SnakeLenght,
            this.Speed,
            this.FieldSize,
            this.Borders,
            this.Date});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewResult.Location = new System.Drawing.Point(8, 44);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewResult.RowHeadersWidth = 10;
            this.dataGridViewResult.Size = new System.Drawing.Size(730, 157);
            this.dataGridViewResult.TabIndex = 17;
            this.dataGridViewResult.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Owner
            // 
            this.Owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Owner.HeaderText = "Owner";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            this.Owner.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SnakeLenght
            // 
            this.SnakeLenght.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SnakeLenght.HeaderText = "Snake lenght";
            this.SnakeLenght.Name = "SnakeLenght";
            this.SnakeLenght.ReadOnly = true;
            // 
            // Speed
            // 
            this.Speed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            // 
            // FieldSize
            // 
            this.FieldSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldSize.HeaderText = "Field Size";
            this.FieldSize.Name = "FieldSize";
            this.FieldSize.ReadOnly = true;
            // 
            // Borders
            // 
            this.Borders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Borders.HeaderText = "Borders";
            this.Borders.Name = "Borders";
            this.Borders.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.Location = new System.Drawing.Point(8, 71);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(43, 17);
            this.labelPlace.TabIndex = 18;
            this.labelPlace.Text = "Place";
            // 
            // buttonShowTopResult
            // 
            this.buttonShowTopResult.Location = new System.Drawing.Point(7, 15);
            this.buttonShowTopResult.Name = "buttonShowTopResult";
            this.buttonShowTopResult.Size = new System.Drawing.Size(64, 23);
            this.buttonShowTopResult.TabIndex = 6;
            this.buttonShowTopResult.Text = "Show top:";
            this.buttonShowTopResult.UseVisualStyleBackColor = true;
            this.buttonShowTopResult.Click += new System.EventHandler(this.buttonShowTopResult_Click);
            // 
            // textBoxResultNumber
            // 
            this.textBoxResultNumber.Location = new System.Drawing.Point(77, 17);
            this.textBoxResultNumber.Name = "textBoxResultNumber";
            this.textBoxResultNumber.Size = new System.Drawing.Size(31, 20);
            this.textBoxResultNumber.TabIndex = 5;
            // 
            // buttonDeteFrom
            // 
            this.buttonDeteFrom.Location = new System.Drawing.Point(365, 19);
            this.buttonDeteFrom.Name = "buttonDeteFrom";
            this.buttonDeteFrom.Size = new System.Drawing.Size(75, 23);
            this.buttonDeteFrom.TabIndex = 8;
            this.buttonDeteFrom.Text = "Delete from:";
            this.buttonDeteFrom.UseVisualStyleBackColor = true;
            this.buttonDeteFrom.Click += new System.EventHandler(this.buttonDeteFrom_Click);
            // 
            // textBoxDeleteFrom
            // 
            this.textBoxDeleteFrom.Location = new System.Drawing.Point(446, 22);
            this.textBoxDeleteFrom.Name = "textBoxDeleteFrom";
            this.textBoxDeleteFrom.Size = new System.Drawing.Size(31, 20);
            this.textBoxDeleteFrom.TabIndex = 7;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(501, 19);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAll.TabIndex = 9;
            this.buttonDeleteAll.Text = "Delete All";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // labelSavingInfo
            // 
            this.labelSavingInfo.AutoSize = true;
            this.labelSavingInfo.Location = new System.Drawing.Point(8, 89);
            this.labelSavingInfo.Name = "labelSavingInfo";
            this.labelSavingInfo.Size = new System.Drawing.Size(188, 13);
            this.labelSavingInfo.TabIndex = 24;
            this.labelSavingInfo.Text = "Only the top 5 records are auto-saved!";
            this.labelSavingInfo.Visible = false;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Enabled = false;
            this.textBoxPlayerName.Location = new System.Drawing.Point(11, 154);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.ReadOnly = true;
            this.textBoxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerName.TabIndex = 25;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(8, 138);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(39, 13);
            this.labelPlayerName.TabIndex = 26;
            this.labelPlayerName.Text = "Player:";
            // 
            // buttonChangeName
            // 
            this.buttonChangeName.Location = new System.Drawing.Point(129, 152);
            this.buttonChangeName.Name = "buttonChangeName";
            this.buttonChangeName.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeName.TabIndex = 1;
            this.buttonChangeName.Text = "Change";
            this.buttonChangeName.UseVisualStyleBackColor = true;
            this.buttonChangeName.Click += new System.EventHandler(this.buttonChangeName_Click);
            // 
            // labelAllRecNumber
            // 
            this.labelAllRecNumber.AutoSize = true;
            this.labelAllRecNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllRecNumber.Location = new System.Drawing.Point(206, 19);
            this.labelAllRecNumber.Name = "labelAllRecNumber";
            this.labelAllRecNumber.Size = new System.Drawing.Size(75, 17);
            this.labelAllRecNumber.TabIndex = 37;
            this.labelAllRecNumber.Text = "All records";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(125, 17);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 10;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonScoreInfo
            // 
            this.buttonScoreInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonScoreInfo.FlatAppearance.BorderSize = 0;
            this.buttonScoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScoreInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonScoreInfo.Image")));
            this.buttonScoreInfo.Location = new System.Drawing.Point(219, 77);
            this.buttonScoreInfo.Name = "buttonScoreInfo";
            this.buttonScoreInfo.Size = new System.Drawing.Size(25, 25);
            this.buttonScoreInfo.TabIndex = 38;
            this.buttonScoreInfo.TabStop = false;
            this.buttonScoreInfo.UseVisualStyleBackColor = true;
            this.buttonScoreInfo.MouseLeave += new System.EventHandler(this.buttonScoreInfo_MouseLeave);
            this.buttonScoreInfo.MouseHover += new System.EventHandler(this.buttonScoreInfo_MouseHover);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 433);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(754, 22);
            this.statusStrip.TabIndex = 39;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.buttonShowTopResult);
            this.panelResult.Controls.Add(this.buttonShowAll);
            this.panelResult.Controls.Add(this.labelAllRecNumber);
            this.panelResult.Controls.Add(this.buttonDeleteAll);
            this.panelResult.Controls.Add(this.textBoxDeleteFrom);
            this.panelResult.Controls.Add(this.buttonDeteFrom);
            this.panelResult.Controls.Add(this.textBoxResultNumber);
            this.panelResult.Controls.Add(this.dataGridViewResult);
            this.panelResult.Location = new System.Drawing.Point(4, 221);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(749, 212);
            this.panelResult.TabIndex = 40;
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 455);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonScoreInfo);
            this.Controls.Add(this.buttonChangeName);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelSavingInfo);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.textBoxScoreFormula);
            this.Controls.Add(this.buttonSaveResult);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelField);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Name = "FormGameOver";
            this.Text = "Game Over";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gameOverForm_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.TextBox textBoxScoreFormula;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonShowTopResult;
        private System.Windows.Forms.TextBox textBoxResultNumber;
        private System.Windows.Forms.Button buttonDeteFrom;
        private System.Windows.Forms.TextBox textBoxDeleteFrom;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Label labelSavingInfo;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Button buttonChangeName;
        private System.Windows.Forms.Label labelAllRecNumber;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonScoreInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnakeLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel panelResult;
    }
}