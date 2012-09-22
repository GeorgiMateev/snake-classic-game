namespace SnakeClassicGUI
{
    partial class FormGetName
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
            this.buttonGetName = new System.Windows.Forms.Button();
            this.buttonCancelName = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGetName
            // 
            this.buttonGetName.Location = new System.Drawing.Point(12, 47);
            this.buttonGetName.Name = "buttonGetName";
            this.buttonGetName.Size = new System.Drawing.Size(75, 23);
            this.buttonGetName.TabIndex = 0;
            this.buttonGetName.Text = "OK";
            this.buttonGetName.UseVisualStyleBackColor = true;
            this.buttonGetName.Click += new System.EventHandler(this.buttonGetName_Click);
            // 
            // buttonCancelName
            // 
            this.buttonCancelName.Location = new System.Drawing.Point(164, 47);
            this.buttonCancelName.Name = "buttonCancelName";
            this.buttonCancelName.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelName.TabIndex = 1;
            this.buttonCancelName.Text = "Cancel";
            this.buttonCancelName.UseVisualStyleBackColor = true;
            this.buttonCancelName.Click += new System.EventHandler(this.buttonCancelName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Player Name";
            // 
            // FormGetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 89);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancelName);
            this.Controls.Add(this.buttonGetName);
            this.Name = "FormGetName";
            this.Text = "Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetName;
        private System.Windows.Forms.Button buttonCancelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}