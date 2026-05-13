namespace ShelfLog
{
    partial class FormCarti
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
            this.labelTextCarti = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.buttonFiltre = new System.Windows.Forms.Button();
            this.comboBoxFiltre = new System.Windows.Forms.ComboBox();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTextCarti
            // 
            this.labelTextCarti.AutoSize = true;
            this.labelTextCarti.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextCarti.ForeColor = System.Drawing.Color.White;
            this.labelTextCarti.Location = new System.Drawing.Point(169, 40);
            this.labelTextCarti.Name = "labelTextCarti";
            this.labelTextCarti.Size = new System.Drawing.Size(63, 26);
            this.labelTextCarti.TabIndex = 0;
            this.labelTextCarti.Text = "Cărți";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(97, 121);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(287, 22);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Search.Location = new System.Drawing.Point(174, 159);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(111, 33);
            this.Search.TabIndex = 4;
            this.Search.Text = "Caută";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // buttonFiltre
            // 
            this.buttonFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonFiltre.Location = new System.Drawing.Point(239, 227);
            this.buttonFiltre.Name = "buttonFiltre";
            this.buttonFiltre.Size = new System.Drawing.Size(100, 25);
            this.buttonFiltre.TabIndex = 5;
            this.buttonFiltre.Text = "Filtrează";
            this.buttonFiltre.UseVisualStyleBackColor = false;
            this.buttonFiltre.Click += new System.EventHandler(this.buttonFiltre_Click);
            // 
            // comboBoxFiltre
            // 
            this.comboBoxFiltre.FormattingEnabled = true;
            this.comboBoxFiltre.Location = new System.Drawing.Point(97, 227);
            this.comboBoxFiltre.Name = "comboBoxFiltre";
            this.comboBoxFiltre.Size = new System.Drawing.Size(135, 24);
            this.comboBoxFiltre.TabIndex = 6;
            this.comboBoxFiltre.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltre_SelectedIndexChanged);
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltre.ForeColor = System.Drawing.Color.White;
            this.labelFiltre.Location = new System.Drawing.Point(8, 225);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(83, 22);
            this.labelFiltre.TabIndex = 7;
            this.labelFiltre.Text = "Filtrează";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.favoriteToolStripMenuItem,
            this.tBRToolStripMenuItem,
            this.statisticiToolStripMenuItem,
            this.setăriToolStripMenuItem});
            this.meniuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // favoriteToolStripMenuItem
            // 
            this.favoriteToolStripMenuItem.Name = "favoriteToolStripMenuItem";
            this.favoriteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.favoriteToolStripMenuItem.Text = "Favorite";
            this.favoriteToolStripMenuItem.Click += new System.EventHandler(this.favoriteToolStripMenuItem_Click);
            // 
            // tBRToolStripMenuItem
            // 
            this.tBRToolStripMenuItem.Name = "tBRToolStripMenuItem";
            this.tBRToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tBRToolStripMenuItem.Text = "TBR";
            this.tBRToolStripMenuItem.Click += new System.EventHandler(this.tBRToolStripMenuItem_Click_1);
            // 
            // statisticiToolStripMenuItem
            // 
            this.statisticiToolStripMenuItem.Name = "statisticiToolStripMenuItem";
            this.statisticiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.statisticiToolStripMenuItem.Text = "Statistici";
            this.statisticiToolStripMenuItem.Click += new System.EventHandler(this.statisticiToolStripMenuItem_Click_1);
            // 
            // setăriToolStripMenuItem
            // 
            this.setăriToolStripMenuItem.Name = "setăriToolStripMenuItem";
            this.setăriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.setăriToolStripMenuItem.Text = "Setări";
            this.setăriToolStripMenuItem.Click += new System.EventHandler(this.setăriToolStripMenuItem_Click_1);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonReset.Location = new System.Drawing.Point(348, 227);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 25);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Resetează";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(97, 271);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(135, 24);
            this.comboBoxSort.TabIndex = 12;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSort.ForeColor = System.Drawing.Color.White;
            this.labelSort.Location = new System.Drawing.Point(12, 271);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(73, 22);
            this.labelSort.TabIndex = 13;
            this.labelSort.Text = "Sortare";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 316);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 349);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Căutare";
            // 
            // FormCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(460, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelFiltre);
            this.Controls.Add(this.comboBoxFiltre);
            this.Controls.Add(this.buttonFiltre);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelTextCarti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCarti";
            this.Text = "FormCarti";
            this.Load += new System.EventHandler(this.FormCarti_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextCarti;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button buttonFiltre;
        private System.Windows.Forms.ComboBox comboBoxFiltre;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setăriToolStripMenuItem;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}