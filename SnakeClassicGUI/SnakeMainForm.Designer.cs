using SnakeClassLib;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeMainForm));
            this.toolStripDropDownGame = new System.Windows.Forms.ToolStripDropDownButton();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surrenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripMainMenu = new System.Windows.Forms.ToolStrip();
            this.statusStripGameStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRunning = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTurn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerGameDuration = new System.Windows.Forms.Timer(this.components);
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripMainMenu.SuspendLayout();
            this.statusStripGameStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripDropDownGame
            // 
            this.toolStripDropDownGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.surrenderToolStripMenuItem});
            this.toolStripDropDownGame.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownGame.Image")));
            this.toolStripDropDownGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownGame.Name = "toolStripDropDownGame";
            this.toolStripDropDownGame.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownGame.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // surrenderToolStripMenuItem
            // 
            this.surrenderToolStripMenuItem.Enabled = false;
            this.surrenderToolStripMenuItem.Name = "surrenderToolStripMenuItem";
            this.surrenderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.surrenderToolStripMenuItem.Text = "Surrender";
            this.surrenderToolStripMenuItem.Click += new System.EventHandler(this.surrenderToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Options";
            // 
            // toolStripMainMenu
            // 
            this.toolStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownGame,
            this.toolStripButton1,
            this.toolStripButtonClose});
            this.toolStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainMenu.Name = "toolStripMainMenu";
            this.toolStripMainMenu.Size = new System.Drawing.Size(426, 25);
            this.toolStripMainMenu.TabIndex = 9;
            this.toolStripMainMenu.Text = "toolStrip1";
            // 
            // statusStripGameStatus
            // 
            this.statusStripGameStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRunning,
            this.toolStripStatusLabelResult,
            this.toolStripStatusLabelTurn,
            this.toolStripStatusLabelElapsedTime});
            this.statusStripGameStatus.Location = new System.Drawing.Point(0, 174);
            this.statusStripGameStatus.Name = "statusStripGameStatus";
            this.statusStripGameStatus.Size = new System.Drawing.Size(426, 22);
            this.statusStripGameStatus.TabIndex = 10;
            this.statusStripGameStatus.Text = "Status";
            // 
            // toolStripStatusLabelRunning
            // 
            this.toolStripStatusLabelRunning.LinkVisited = true;
            this.toolStripStatusLabelRunning.Margin = new System.Windows.Forms.Padding(0, 3, 30, 2);
            this.toolStripStatusLabelRunning.Name = "toolStripStatusLabelRunning";
            this.toolStripStatusLabelRunning.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelRunning.Text = "Ready";
            // 
            // toolStripStatusLabelResult
            // 
            this.toolStripStatusLabelResult.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.toolStripStatusLabelResult.Name = "toolStripStatusLabelResult";
            this.toolStripStatusLabelResult.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelResult.Text = "Result:";
            // 
            // toolStripStatusLabelTurn
            // 
            this.toolStripStatusLabelTurn.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.toolStripStatusLabelTurn.Name = "toolStripStatusLabelTurn";
            this.toolStripStatusLabelTurn.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabelTurn.Text = "Changed Direction:";
            // 
            // toolStripStatusLabelElapsedTime
            // 
            this.toolStripStatusLabelElapsedTime.Name = "toolStripStatusLabelElapsedTime";
            this.toolStripStatusLabelElapsedTime.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabelElapsedTime.Text = "Time:";
            // 
            // timerGameDuration
            // 
            this.timerGameDuration.Interval = 1000;
            this.timerGameDuration.Tick += new System.EventHandler(this.timerGameDuration_Tick);
            // 
            // textBoxError
            // 
            this.textBoxError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxError.Enabled = false;
            this.textBoxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxError.Location = new System.Drawing.Point(0, 151);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.ReadOnly = true;
            this.textBoxError.Size = new System.Drawing.Size(426, 23);
            this.textBoxError.TabIndex = 11;
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(40, 22);
            this.toolStripButtonClose.Text = "Close";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // SnakeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 196);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.statusStripGameStatus);
            this.Controls.Add(this.toolStripMainMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SnakeMainForm";
            this.Text = "Snake Classic";
            this.toolStripMainMenu.ResumeLayout(false);
            this.toolStripMainMenu.PerformLayout();
            this.statusStripGameStatus.ResumeLayout(false);
            this.statusStripGameStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownGame;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStripMainMenu;
        public System.Windows.Forms.Timer timerGameDuration;
        public System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem surrenderToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRunning;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelElapsedTime;
        public System.Windows.Forms.StatusStrip statusStripGameStatus;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelResult;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTurn;
        public System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;


    }
}

