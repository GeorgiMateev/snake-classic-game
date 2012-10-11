namespace SnakeClassicGUI
{
    partial class ResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxResultNumber = new System.Windows.Forms.TextBox();
            this.buttonShowTopResult = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.textBoxDeleteFrom = new System.Windows.Forms.TextBox();
            this.buttonDeleteFrom = new System.Windows.Forms.Button();
            this.buttonShowNumberResults = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.labelAllRecNumber = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnakeLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxResultNumber
            // 
            this.textBoxResultNumber.Location = new System.Drawing.Point(84, 22);
            this.textBoxResultNumber.Name = "textBoxResultNumber";
            this.textBoxResultNumber.Size = new System.Drawing.Size(31, 20);
            this.textBoxResultNumber.TabIndex = 1;
            // 
            // buttonShowTopResult
            // 
            this.buttonShowTopResult.Location = new System.Drawing.Point(-166, 42);
            this.buttonShowTopResult.Name = "buttonShowTopResult";
            this.buttonShowTopResult.Size = new System.Drawing.Size(64, 23);
            this.buttonShowTopResult.TabIndex = 25;
            this.buttonShowTopResult.Text = "Show top:";
            this.buttonShowTopResult.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(668, 22);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAll.TabIndex = 6;
            this.buttonDeleteAll.Text = "Delete All";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // textBoxDeleteFrom
            // 
            this.textBoxDeleteFrom.Location = new System.Drawing.Point(598, 25);
            this.textBoxDeleteFrom.Name = "textBoxDeleteFrom";
            this.textBoxDeleteFrom.Size = new System.Drawing.Size(31, 20);
            this.textBoxDeleteFrom.TabIndex = 3;
            // 
            // buttonDeleteFrom
            // 
            this.buttonDeleteFrom.Location = new System.Drawing.Point(517, 22);
            this.buttonDeleteFrom.Name = "buttonDeleteFrom";
            this.buttonDeleteFrom.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteFrom.TabIndex = 4;
            this.buttonDeleteFrom.Text = "Delete from:";
            this.buttonDeleteFrom.UseVisualStyleBackColor = true;
            this.buttonDeleteFrom.Click += new System.EventHandler(this.buttonDeleteFrom_Click);
            // 
            // buttonShowNumberResults
            // 
            this.buttonShowNumberResults.Location = new System.Drawing.Point(14, 19);
            this.buttonShowNumberResults.Name = "buttonShowNumberResults";
            this.buttonShowNumberResults.Size = new System.Drawing.Size(64, 23);
            this.buttonShowNumberResults.TabIndex = 2;
            this.buttonShowNumberResults.Text = "Show top:";
            this.buttonShowNumberResults.UseVisualStyleBackColor = true;
            this.buttonShowNumberResults.Click += new System.EventHandler(this.buttonShowNumberResults_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Score,
            this.Owner,
            this.SnakeLenght,
            this.Speed,
            this.FieldSize,
            this.Borders,
            this.Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewResult.RowHeadersWidth = 10;
            this.dataGridViewResult.Size = new System.Drawing.Size(731, 306);
            this.dataGridViewResult.TabIndex = 27;
            this.dataGridViewResult.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(668, 382);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxMessages.Enabled = false;
            this.textBoxMessages.Location = new System.Drawing.Point(0, 411);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(757, 20);
            this.textBoxMessages.TabIndex = 34;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(121, 20);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 5;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // labelAllRecNumber
            // 
            this.labelAllRecNumber.AutoSize = true;
            this.labelAllRecNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllRecNumber.Location = new System.Drawing.Point(213, 22);
            this.labelAllRecNumber.Name = "labelAllRecNumber";
            this.labelAllRecNumber.Size = new System.Drawing.Size(75, 17);
            this.labelAllRecNumber.TabIndex = 36;
            this.labelAllRecNumber.Text = "All records";
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Owner
            // 
            this.Owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Owner.HeaderText = "Owner";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            // 
            // SnakeLenght
            // 
            this.SnakeLenght.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SnakeLenght.HeaderText = "Snake Lenght";
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
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 431);
            this.Controls.Add(this.labelAllRecNumber);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.textBoxDeleteFrom);
            this.Controls.Add(this.buttonDeleteFrom);
            this.Controls.Add(this.buttonShowNumberResults);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.textBoxResultNumber);
            this.Controls.Add(this.buttonShowTopResult);
            this.Name = "ResultForm";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResultNumber;
        private System.Windows.Forms.Button buttonShowTopResult;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.TextBox textBoxDeleteFrom;
        private System.Windows.Forms.Button buttonDeleteFrom;
        private System.Windows.Forms.Button buttonShowNumberResults;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Label labelAllRecNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnakeLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}