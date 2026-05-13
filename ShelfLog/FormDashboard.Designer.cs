namespace ShelfLog
{
    partial class FormDashboard
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
            System.Windows.Forms.PictureBox pictureBox1;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tBRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setăriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitluRecomandare = new System.Windows.Forms.Label();
            this.listBoxRecomandari = new System.Windows.Forms.ListBox();
            this.buttonGenerareRec = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::ShelfLog.Properties.Resources.BookShelf1;
            pictureBox1.Location = new System.Drawing.Point(93, 112);
            pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(269, 182);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cărțiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cărțiToolStripMenuItem2,
            this.favoriteToolStripMenuItem1,
            this.tBRToolStripMenuItem1,
            this.statisticiToolStripMenuItem1,
            this.setăriToolStripMenuItem1});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItem1.Text = "Meniu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cărțiToolStripMenuItem2
            // 
            this.cărțiToolStripMenuItem2.Name = "cărțiToolStripMenuItem2";
            this.cărțiToolStripMenuItem2.Size = new System.Drawing.Size(148, 26);
            this.cărțiToolStripMenuItem2.Text = "Cărți";
            this.cărțiToolStripMenuItem2.Click += new System.EventHandler(this.cărțiToolStripMenuItem2_Click);
            // 
            // favoriteToolStripMenuItem1
            // 
            this.favoriteToolStripMenuItem1.Name = "favoriteToolStripMenuItem1";
            this.favoriteToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.favoriteToolStripMenuItem1.Text = "Favorite";
            this.favoriteToolStripMenuItem1.Click += new System.EventHandler(this.favoriteToolStripMenuItem1_Click);
            // 
            // tBRToolStripMenuItem1
            // 
            this.tBRToolStripMenuItem1.Name = "tBRToolStripMenuItem1";
            this.tBRToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.tBRToolStripMenuItem1.Text = "TBR";
            this.tBRToolStripMenuItem1.Click += new System.EventHandler(this.tBRToolStripMenuItem1_Click);
            // 
            // statisticiToolStripMenuItem1
            // 
            this.statisticiToolStripMenuItem1.Name = "statisticiToolStripMenuItem1";
            this.statisticiToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.statisticiToolStripMenuItem1.Text = "Statistici";
            this.statisticiToolStripMenuItem1.Click += new System.EventHandler(this.statisticiToolStripMenuItem1_Click);
            // 
            // setăriToolStripMenuItem1
            // 
            this.setăriToolStripMenuItem1.Name = "setăriToolStripMenuItem1";
            this.setăriToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.setăriToolStripMenuItem1.Text = "Setări";
            this.setăriToolStripMenuItem1.Click += new System.EventHandler(this.setăriToolStripMenuItem1_Click);
            // 
            // cărțiToolStripMenuItem
            // 
            this.cărțiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cărțiToolStripMenuItem1,
            this.favoriteToolStripMenuItem,
            this.tBRToolStripMenuItem,
            this.statisticiToolStripMenuItem,
            this.setăriToolStripMenuItem});
            this.cărțiToolStripMenuItem.Name = "cărțiToolStripMenuItem";
            this.cărțiToolStripMenuItem.Size = new System.Drawing.Size(27, 24);
            this.cărțiToolStripMenuItem.Text = " ";
            this.cărțiToolStripMenuItem.Click += new System.EventHandler(this.cărțiToolStripMenuItem_Click);
            // 
            // cărțiToolStripMenuItem1
            // 
            this.cărțiToolStripMenuItem1.Name = "cărțiToolStripMenuItem1";
            this.cărțiToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.cărțiToolStripMenuItem1.Text = "Cărți";
            // 
            // favoriteToolStripMenuItem
            // 
            this.favoriteToolStripMenuItem.Name = "favoriteToolStripMenuItem";
            this.favoriteToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.favoriteToolStripMenuItem.Text = "Favorite";
            // 
            // tBRToolStripMenuItem
            // 
            this.tBRToolStripMenuItem.Name = "tBRToolStripMenuItem";
            this.tBRToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.tBRToolStripMenuItem.Text = "TBR";
            // 
            // statisticiToolStripMenuItem
            // 
            this.statisticiToolStripMenuItem.Name = "statisticiToolStripMenuItem";
            this.statisticiToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.statisticiToolStripMenuItem.Text = "Statistici";
            // 
            // setăriToolStripMenuItem
            // 
            this.setăriToolStripMenuItem.Name = "setăriToolStripMenuItem";
            this.setăriToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.setăriToolStripMenuItem.Text = "Setări";
            // 
            // labelTitluRecomandare
            // 
            this.labelTitluRecomandare.AutoSize = true;
            this.labelTitluRecomandare.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitluRecomandare.ForeColor = System.Drawing.Color.White;
            this.labelTitluRecomandare.Location = new System.Drawing.Point(144, 348);
            this.labelTitluRecomandare.Name = "labelTitluRecomandare";
            this.labelTitluRecomandare.Size = new System.Drawing.Size(154, 26);
            this.labelTitluRecomandare.TabIndex = 4;
            this.labelTitluRecomandare.Text = "Recomandări";
            this.labelTitluRecomandare.Click += new System.EventHandler(this.labelTitluRecomandare_Click);
            // 
            // listBoxRecomandari
            // 
            this.listBoxRecomandari.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listBoxRecomandari.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecomandari.FormattingEnabled = true;
            this.listBoxRecomandari.ItemHeight = 19;
            this.listBoxRecomandari.Location = new System.Drawing.Point(42, 405);
            this.listBoxRecomandari.Name = "listBoxRecomandari";
            this.listBoxRecomandari.Size = new System.Drawing.Size(373, 118);
            this.listBoxRecomandari.TabIndex = 5;
            this.listBoxRecomandari.SelectedIndexChanged += new System.EventHandler(this.listBoxRecomandari_SelectedIndexChanged);
            // 
            // buttonGenerareRec
            // 
            this.buttonGenerareRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonGenerareRec.Location = new System.Drawing.Point(137, 557);
            this.buttonGenerareRec.Name = "buttonGenerareRec";
            this.buttonGenerareRec.Size = new System.Drawing.Size(188, 50);
            this.buttonGenerareRec.TabIndex = 6;
            this.buttonGenerareRec.Text = "Generează recomandare";
            this.buttonGenerareRec.UseVisualStyleBackColor = false;
            this.buttonGenerareRec.Click += new System.EventHandler(this.buttonGenerareRec_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWelcome.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWelcome.Location = new System.Drawing.Point(0, 28);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(460, 26);
            this.labelWelcome.TabIndex = 8;
            this.labelWelcome.Text = "Bine ai venit!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(460, 665);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.buttonGenerareRec);
            this.Controls.Add(this.listBoxRecomandari);
            this.Controls.Add(this.labelTitluRecomandare);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setăriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tBRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setăriToolStripMenuItem1;
        private System.Windows.Forms.Label labelTitluRecomandare;
        private System.Windows.Forms.ListBox listBoxRecomandari;
        private System.Windows.Forms.Button buttonGenerareRec;
        private System.Windows.Forms.Label labelWelcome;
    }
}

