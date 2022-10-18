namespace UI
{
    partial class AddGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGame));
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.cmbPlatform = new System.Windows.Forms.ComboBox();
            this.cbMulti = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(117, 124);
            this.btnAddGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(75, 29);
            this.btnAddGame.TabIndex = 0;
            this.btnAddGame.Text = "Add";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(202, 124);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(82, 46);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(195, 27);
            this.txtTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 20);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(12, 15);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(69, 20);
            this.lblPlatform.TabIndex = 4;
            this.lblPlatform.Text = "Platform:";
            // 
            // cmbPlatform
            // 
            this.cmbPlatform.FormattingEnabled = true;
            this.cmbPlatform.Location = new System.Drawing.Point(82, 9);
            this.cmbPlatform.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPlatform.Name = "cmbPlatform";
            this.cmbPlatform.Size = new System.Drawing.Size(196, 28);
            this.cmbPlatform.TabIndex = 5;
            // 
            // cbMulti
            // 
            this.cbMulti.AutoSize = true;
            this.cbMulti.Location = new System.Drawing.Point(12, 80);
            this.cbMulti.Name = "cbMulti";
            this.cbMulti.Size = new System.Drawing.Size(169, 24);
            this.cbMulti.TabIndex = 6;
            this.cbMulti.Text = "Add multiple games.";
            this.cbMulti.UseVisualStyleBackColor = true;
            // 
            // AddGame
            // 
            this.AcceptButton = this.btnAddGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(290, 166);
            this.Controls.Add(this.cbMulti);
            this.Controls.Add(this.cmbPlatform);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGame";
            this.ShowIcon = false;
            this.Text = "AddGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.ComboBox cmbPlatform;
        private CheckBox cbMulti;
    }
}