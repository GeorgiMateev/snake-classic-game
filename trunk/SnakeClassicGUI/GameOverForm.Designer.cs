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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelChangedDirection = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelField = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
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
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnakeLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAllRecNumber = new System.Windows.Forms.Label();
            this.buttonShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snake Lenght:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(6, 39);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(69, 29);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Score Is:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Changed Direction:";
            // 
            // labelChangedDirection
            // 
            this.labelChangedDirection.AutoSize = true;
            this.labelChangedDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangedDirection.Location = new System.Drawing.Point(104, 39);
            this.labelChangedDirection.Name = "labelChangedDirection";
            this.labelChangedDirection.Size = new System.Drawing.Size(69, 29);
            this.labelChangedDirection.TabIndex = 2;
            this.labelChangedDirection.Text = "0000";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(6, 110);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(69, 29);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "0000";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(250, 39);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(145, 29);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "somespeed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Speed";
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelField.Location = new System.Drawing.Point(437, 39);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(68, 29);
            this.labelField.TabIndex = 7;
            this.labelField.Text = "Field";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Field";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(591, 214);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(115, 38);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Close";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(591, 89);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(115, 38);
            this.buttonNewGame.TabIndex = 10;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.Location = new System.Drawing.Point(139, 96);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(115, 43);
            this.buttonSaveResult.TabIndex = 11;
            this.buttonSaveResult.Text = "Save Result";
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(369, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(185, 163);
            this.textBox1.TabIndex = 13;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Score =\r\nSnake Lenght * Speed\r\n\r\n* 1 (for big field) or\r\n* 2 (for medium field) o" +
                "r\r\n* 3 (for small field)\r\n\r\n*1 (no walls) or\r\n*3 (walls).";
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxMessages.Enabled = false;
            this.textBoxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMessages.Location = new System.Drawing.Point(0, 432);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(754, 23);
            this.textBoxMessages.TabIndex = 16;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Score,
            this.Owner,
            this.SnakeLenght,
            this.Speed,
            this.FieldSize,
            this.Borders,
            this.Date});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 265);
            this.dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewResult.RowHeadersWidth = 10;
            this.dataGridViewResult.Size = new System.Drawing.Size(730, 157);
            this.dataGridViewResult.TabIndex = 17;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.Location = new System.Drawing.Point(8, 143);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(43, 17);
            this.labelPlace.TabIndex = 18;
            this.labelPlace.Text = "Place";
            // 
            // buttonShowTopResult
            // 
            this.buttonShowTopResult.Location = new System.Drawing.Point(11, 236);
            this.buttonShowTopResult.Name = "buttonShowTopResult";
            this.buttonShowTopResult.Size = new System.Drawing.Size(64, 23);
            this.buttonShowTopResult.TabIndex = 19;
            this.buttonShowTopResult.Text = "Show top:";
            this.buttonShowTopResult.UseVisualStyleBackColor = true;
            this.buttonShowTopResult.Click += new System.EventHandler(this.buttonShowTopResult_Click);
            // 
            // textBoxResultNumber
            // 
            this.textBoxResultNumber.Location = new System.Drawing.Point(81, 238);
            this.textBoxResultNumber.Name = "textBoxResultNumber";
            this.textBoxResultNumber.Size = new System.Drawing.Size(31, 20);
            this.textBoxResultNumber.TabIndex = 20;
            // 
            // buttonDeteFrom
            // 
            this.buttonDeteFrom.Location = new System.Drawing.Point(129, 236);
            this.buttonDeteFrom.Name = "buttonDeteFrom";
            this.buttonDeteFrom.Size = new System.Drawing.Size(75, 23);
            this.buttonDeteFrom.TabIndex = 21;
            this.buttonDeteFrom.Text = "Delete from:";
            this.buttonDeteFrom.UseVisualStyleBackColor = true;
            this.buttonDeteFrom.Click += new System.EventHandler(this.buttonDeteFrom_Click);
            // 
            // textBoxDeleteFrom
            // 
            this.textBoxDeleteFrom.Location = new System.Drawing.Point(210, 238);
            this.textBoxDeleteFrom.Name = "textBoxDeleteFrom";
            this.textBoxDeleteFrom.Size = new System.Drawing.Size(31, 20);
            this.textBoxDeleteFrom.TabIndex = 22;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(259, 236);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAll.TabIndex = 23;
            this.buttonDeleteAll.Text = "Delete All";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // labelSavingInfo
            // 
            this.labelSavingInfo.AutoSize = true;
            this.labelSavingInfo.Location = new System.Drawing.Point(12, 169);
            this.labelSavingInfo.Name = "labelSavingInfo";
            this.labelSavingInfo.Size = new System.Drawing.Size(188, 13);
            this.labelSavingInfo.TabIndex = 24;
            this.labelSavingInfo.Text = "Only the top 5 records are auto-saved!";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Enabled = false;
            this.textBoxPlayerName.Location = new System.Drawing.Point(12, 210);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.ReadOnly = true;
            this.textBoxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerName.TabIndex = 25;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(12, 194);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(39, 13);
            this.labelPlayerName.TabIndex = 26;
            this.labelPlayerName.Text = "Player:";
            // 
            // buttonChangeName
            // 
            this.buttonChangeName.Location = new System.Drawing.Point(129, 207);
            this.buttonChangeName.Name = "buttonChangeName";
            this.buttonChangeName.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeName.TabIndex = 27;
            this.buttonChangeName.Text = "Change";
            this.buttonChangeName.UseVisualStyleBackColor = true;
            this.buttonChangeName.Click += new System.EventHandler(this.buttonChangeName_Click);
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Owner";
            this.Owner.Name = "Owner";
            // 
            // SnakeLenght
            // 
            this.SnakeLenght.HeaderText = "Snake lenght";
            this.SnakeLenght.Name = "SnakeLenght";
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            // 
            // FieldSize
            // 
            this.FieldSize.HeaderText = "Field Size";
            this.FieldSize.Name = "FieldSize";
            // 
            // Borders
            // 
            this.Borders.HeaderText = "Borders";
            this.Borders.Name = "Borders";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // labelAllRecNumber
            // 
            this.labelAllRecNumber.AutoSize = true;
            this.labelAllRecNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllRecNumber.Location = new System.Drawing.Point(452, 238);
            this.labelAllRecNumber.Name = "labelAllRecNumber";
            this.labelAllRecNumber.Size = new System.Drawing.Size(75, 17);
            this.labelAllRecNumber.TabIndex = 37;
            this.labelAllRecNumber.Text = "All records";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(369, 235);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 38;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 455);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.labelAllRecNumber);
            this.Controls.Add(this.buttonChangeName);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelSavingInfo);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.textBoxDeleteFrom);
            this.Controls.Add(this.buttonDeteFrom);
            this.Controls.Add(this.textBoxResultNumber);
            this.Controls.Add(this.buttonShowTopResult);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSaveResult);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelField);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelChangedDirection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Name = "FormGameOver";
            this.Text = "Game Over";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelChangedDirection;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxMessages;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnakeLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label labelAllRecNumber;
        private System.Windows.Forms.Button buttonShowAll;
    }
}