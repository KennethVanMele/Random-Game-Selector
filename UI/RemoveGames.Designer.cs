namespace UI
{
    partial class RemoveGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveGames));
            this.btnRm = new System.Windows.Forms.Button();
            this.btnKeep = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbKeep = new System.Windows.Forms.ListBox();
            this.lbRemove = new System.Windows.Forms.ListBox();
            this.gbKeep = new System.Windows.Forms.GroupBox();
            this.gbRemove = new System.Windows.Forms.GroupBox();
            this.gbKeep.SuspendLayout();
            this.gbRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRm
            // 
            this.btnRm.Location = new System.Drawing.Point(269, 181);
            this.btnRm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRm.Name = "btnRm";
            this.btnRm.Size = new System.Drawing.Size(75, 29);
            this.btnRm.TabIndex = 2;
            this.btnRm.Text = ">";
            this.btnRm.UseVisualStyleBackColor = true;
            this.btnRm.Click += new System.EventHandler(this.btnRm_Click);
            // 
            // btnKeep
            // 
            this.btnKeep.Location = new System.Drawing.Point(269, 286);
            this.btnKeep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKeep.Name = "btnKeep";
            this.btnKeep.Size = new System.Drawing.Size(75, 29);
            this.btnKeep.TabIndex = 3;
            this.btnKeep.Text = "<";
            this.btnKeep.UseVisualStyleBackColor = true;
            this.btnKeep.Click += new System.EventHandler(this.btnKeep_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(400, 525);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 34);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(525, 525);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbKeep
            // 
            this.lbKeep.FormattingEnabled = true;
            this.lbKeep.ItemHeight = 20;
            this.lbKeep.Location = new System.Drawing.Point(7, 28);
            this.lbKeep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbKeep.Name = "lbKeep";
            this.lbKeep.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbKeep.Size = new System.Drawing.Size(187, 464);
            this.lbKeep.TabIndex = 0;
            // 
            // lbRemove
            // 
            this.lbRemove.FormattingEnabled = true;
            this.lbRemove.ItemHeight = 20;
            this.lbRemove.Location = new System.Drawing.Point(6, 26);
            this.lbRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbRemove.Size = new System.Drawing.Size(188, 464);
            this.lbRemove.TabIndex = 0;
            // 
            // gbKeep
            // 
            this.gbKeep.Controls.Add(this.lbKeep);
            this.gbKeep.Location = new System.Drawing.Point(12, 15);
            this.gbKeep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbKeep.Name = "gbKeep";
            this.gbKeep.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbKeep.Size = new System.Drawing.Size(200, 502);
            this.gbKeep.TabIndex = 6;
            this.gbKeep.TabStop = false;
            this.gbKeep.Text = "Keep";
            // 
            // gbRemove
            // 
            this.gbRemove.Controls.Add(this.lbRemove);
            this.gbRemove.Location = new System.Drawing.Point(400, 15);
            this.gbRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRemove.Name = "gbRemove";
            this.gbRemove.Size = new System.Drawing.Size(200, 502);
            this.gbRemove.TabIndex = 7;
            this.gbRemove.TabStop = false;
            this.gbRemove.Text = "Remove";
            // 
            // RemoveGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(612, 569);
            this.Controls.Add(this.gbKeep);
            this.Controls.Add(this.gbRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnKeep);
            this.Controls.Add(this.btnRm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveGames";
            this.Text = "RemoveGames";
            this.Load += new System.EventHandler(this.RemoveGames_Load);
            this.gbKeep.ResumeLayout(false);
            this.gbRemove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRm;
        private Button btnKeep;
        private Button btnRemove;
        private Button btnCancel;
        private ListBox lbKeep;
        private ListBox lbRemove;
        private GroupBox gbKeep;
        private GroupBox gbRemove;
    }
}