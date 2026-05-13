namespace ShelfLog
{
    partial class FormStatistics
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCreateDate = new System.Windows.Forms.Label();
            this.labelTBR = new System.Windows.Forms.Label();
            this.labelRead = new System.Windows.Forms.Label();
            this.labelStarted = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.cărțiToolStripMenuItem,
            this.favoriteToolStripMenuItem,
            this.tBRToolStripMenuItem,
            this.setăriToolStripMenuItem});
            this.meniuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // cărțiToolStripMenuItem
            // 
            this.cărțiToolStripMenuItem.Name = "cărțiToolStripMenuItem";
            this.cărțiToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.cărțiToolStripMenuItem.Text = "Cărți";
            this.cărțiToolStripMenuItem.Click += new System.EventHandler(this.cărțiToolStripMenuItem_Click);
            // 
            // favoriteToolStripMenuItem
            // 
            this.favoriteToolStripMenuItem.Name = "favoriteToolStripMenuItem";
            this.favoriteToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.favoriteToolStripMenuItem.Text = "Favorite";
            this.favoriteToolStripMenuItem.Click += new System.EventHandler(this.favoriteToolStripMenuItem_Click);
            // 
            // tBRToolStripMenuItem
            // 
            this.tBRToolStripMenuItem.Name = "tBRToolStripMenuItem";
            this.tBRToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.tBRToolStripMenuItem.Text = "TBR";
            this.tBRToolStripMenuItem.Click += new System.EventHandler(this.tBRToolStripMenuItem_Click);
            // 
            // setăriToolStripMenuItem
            // 
            this.setăriToolStripMenuItem.Name = "setăriToolStripMenuItem";
            this.setăriToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.setăriToolStripMenuItem.Text = "Setări";
            this.setăriToolStripMenuItem.Click += new System.EventHandler(this.setăriToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statistici";
            // 
            // labelCreateDate
            // 
            this.labelCreateDate.AutoSize = true;
            this.labelCreateDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateDate.ForeColor = System.Drawing.Color.White;
            this.labelCreateDate.Location = new System.Drawing.Point(137, 96);
            this.labelCreateDate.Name = "labelCreateDate";
            this.labelCreateDate.Size = new System.Drawing.Size(45, 16);
            this.labelCreateDate.TabIndex = 2;
            this.labelCreateDate.Text = "label2";
            this.labelCreateDate.Click += new System.EventHandler(this.labelCreateDate_Click);
            // 
            // labelTBR
            // 
            this.labelTBR.AutoSize = true;
            this.labelTBR.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTBR.ForeColor = System.Drawing.Color.White;
            this.labelTBR.Location = new System.Drawing.Point(21, 206);
            this.labelTBR.Name = "labelTBR";
            this.labelTBR.Size = new System.Drawing.Size(44, 22);
            this.labelTBR.TabIndex = 4;
            this.labelTBR.Text = "TBR";
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRead.ForeColor = System.Drawing.Color.White;
            this.labelRead.Location = new System.Drawing.Point(30, 297);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(56, 22);
            this.labelRead.TabIndex = 5;
            this.labelRead.Text = "Citite";
            // 
            // labelStarted
            // 
            this.labelStarted.AutoSize = true;
            this.labelStarted.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarted.ForeColor = System.Drawing.Color.White;
            this.labelStarted.Location = new System.Drawing.Point(30, 248);
            this.labelStarted.Name = "labelStarted";
            this.labelStarted.Size = new System.Drawing.Size(87, 22);
            this.labelStarted.TabIndex = 6;
            this.labelStarted.Text = "Începute";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGen.ForeColor = System.Drawing.Color.White;
            this.labelGen.Location = new System.Drawing.Point(89, 472);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(126, 22);
            this.labelGen.TabIndex = 7;
            this.labelGen.Text = "Gen preferat:";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.ForeColor = System.Drawing.Color.White;
            this.labelAutor.Location = new System.Drawing.Point(89, 514);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(139, 22);
            this.labelAutor.TabIndex = 8;
            this.labelAutor.Text = "Autor preferat:";
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(460, 665);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.labelStarted);
            this.Controls.Add(this.labelRead);
            this.Controls.Add(this.labelTBR);
            this.Controls.Add(this.labelCreateDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setăriToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCreateDate;
        private System.Windows.Forms.Label labelTBR;
        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.Label labelStarted;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.Label labelAutor;
    }
}