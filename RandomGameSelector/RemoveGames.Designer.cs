namespace RandomGameSelector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveGames));
            this.btnRm = new System.Windows.Forms.Button();
            this.btnKeep = new System.Windows.Forms.Button();
            this.gameDBDataSet = new RandomGameSelector.GameDBDataSet();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new RandomGameSelector.GameDBDataSetTableAdapters.GamesTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbKeep = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRemove = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRm
            // 
            this.btnRm.Location = new System.Drawing.Point(269, 145);
            this.btnRm.Name = "btnRm";
            this.btnRm.Size = new System.Drawing.Size(75, 23);
            this.btnRm.TabIndex = 2;
            this.btnRm.Text = ">";
            this.btnRm.UseVisualStyleBackColor = true;
            this.btnRm.Click += new System.EventHandler(this.BtnRm_Click);
            // 
            // btnKeep
            // 
            this.btnKeep.Location = new System.Drawing.Point(269, 229);
            this.btnKeep.Name = "btnKeep";
            this.btnKeep.Size = new System.Drawing.Size(75, 23);
            this.btnKeep.TabIndex = 3;
            this.btnKeep.Text = "<";
            this.btnKeep.UseVisualStyleBackColor = true;
            this.btnKeep.Click += new System.EventHandler(this.BtnKeep_Click);
            // 
            // gameDBDataSet
            // 
            this.gameDBDataSet.DataSetName = "GameDBDataSet";
            this.gameDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.gameDBDataSet;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(525, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(400, 420);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 27);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbKeep);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 402);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keep";
            // 
            // lbKeep
            // 
            this.lbKeep.FormattingEnabled = true;
            this.lbKeep.ItemHeight = 16;
            this.lbKeep.Location = new System.Drawing.Point(7, 22);
            this.lbKeep.Name = "lbKeep";
            this.lbKeep.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbKeep.Size = new System.Drawing.Size(187, 372);
            this.lbKeep.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRemove);
            this.groupBox2.Location = new System.Drawing.Point(400, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 402);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove";
            // 
            // lbRemove
            // 
            this.lbRemove.FormattingEnabled = true;
            this.lbRemove.ItemHeight = 16;
            this.lbRemove.Location = new System.Drawing.Point(6, 21);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbRemove.Size = new System.Drawing.Size(188, 372);
            this.lbRemove.TabIndex = 0;
            // 
            // RemoveGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(612, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnKeep);
            this.Controls.Add(this.btnRm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveGames";
            this.Text = "RemoveGames";
            this.Load += new System.EventHandler(this.RemoveGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRm;
        private System.Windows.Forms.Button btnKeep;
        private GameDBDataSet gameDBDataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private GameDBDataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbKeep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbRemove;
    }
}