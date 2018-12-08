namespace RandomGameSelector
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblPlatform = new System.Windows.Forms.Label();
            this.btnGetGame = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGame = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddGame = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddPlatform = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(23, 28);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(0, 17);
            this.lblPlatform.TabIndex = 0;
            // 
            // btnGetGame
            // 
            this.btnGetGame.Location = new System.Drawing.Point(12, 155);
            this.btnGetGame.Name = "btnGetGame";
            this.btnGetGame.Size = new System.Drawing.Size(116, 27);
            this.btnGetGame.TabIndex = 1;
            this.btnGetGame.Text = "Get new game";
            this.btnGetGame.UseVisualStyleBackColor = true;
            this.btnGetGame.Click += new System.EventHandler(this.BtnGetGame_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(134, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(26, 72);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(0, 17);
            this.lblGame.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(220, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeGamesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddGame,
            this.smiAddPlatform});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // smiAddGame
            // 
            this.smiAddGame.Name = "smiAddGame";
            this.smiAddGame.Size = new System.Drawing.Size(141, 26);
            this.smiAddGame.Text = "Game";
            this.smiAddGame.Click += new System.EventHandler(this.SmiAddGame_Click);
            // 
            // smiAddPlatform
            // 
            this.smiAddPlatform.Name = "smiAddPlatform";
            this.smiAddPlatform.Size = new System.Drawing.Size(141, 26);
            this.smiAddPlatform.Text = "Platform";
            this.smiAddPlatform.Click += new System.EventHandler(this.SmiAddPlatform_Click);
            // 
            // removeGamesToolStripMenuItem
            // 
            this.removeGamesToolStripMenuItem.Name = "removeGamesToolStripMenuItem";
            this.removeGamesToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.removeGamesToolStripMenuItem.Text = "Remove Games";
            this.removeGamesToolStripMenuItem.Click += new System.EventHandler(this.RemoveGamesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnGetGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(220, 194);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetGame);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Button btnGetGame;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiAddGame;
        private System.Windows.Forms.ToolStripMenuItem smiAddPlatform;
        private System.Windows.Forms.ToolStripMenuItem removeGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

