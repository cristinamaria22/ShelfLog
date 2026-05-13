namespace ShelfLog
{
    partial class FormFavorites
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setăriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setăriToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lucrare_atestatDataSet1 = new ShelfLog.lucrare_atestatDataSet1();
            this.autoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoriTableAdapter = new ShelfLog.lucrare_atestatDataSet1TableAdapters.AutoriTableAdapter();
            this.tableAdapterManager = new ShelfLog.lucrare_atestatDataSet1TableAdapters.TableAdapterManager();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lucrare_atestatDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.cToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tBRToolStripMenuItem,
            this.setăriToolStripMenuItem,
            this.setăriToolStripMenuItem1,
            this.statisticiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 172);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.cToolStripMenuItem.Text = "Cărți";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 24);
            this.toolStripMenuItem2.Text = "Favorite";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tBRToolStripMenuItem
            // 
            this.tBRToolStripMenuItem.Name = "tBRToolStripMenuItem";
            this.tBRToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.tBRToolStripMenuItem.Text = "TBR";
            // 
            // setăriToolStripMenuItem
            // 
            this.setăriToolStripMenuItem.Name = "setăriToolStripMenuItem";
            this.setăriToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.setăriToolStripMenuItem.Text = "TBR";
            this.setăriToolStripMenuItem.Click += new System.EventHandler(this.setăriToolStripMenuItem_Click);
            // 
            // setăriToolStripMenuItem1
            // 
            this.setăriToolStripMenuItem1.Name = "setăriToolStripMenuItem1";
            this.setăriToolStripMenuItem1.Size = new System.Drawing.Size(151, 24);
            this.setăriToolStripMenuItem1.Text = "Setări";
            // 
            // statisticiToolStripMenuItem
            // 
            this.statisticiToolStripMenuItem.Name = "statisticiToolStripMenuItem";
            this.statisticiToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.statisticiToolStripMenuItem.Text = "Statistici";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.cărțiToolStripMenuItem,
            this.favoriteToolStripMenuItem,
            this.tBRToolStripMenuItem1,
            this.statisticiToolStripMenuItem1,
            this.setăriToolStripMenuItem2});
            this.meniuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
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
            // tBRToolStripMenuItem1
            // 
            this.tBRToolStripMenuItem1.Name = "tBRToolStripMenuItem1";
            this.tBRToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.tBRToolStripMenuItem1.Text = "TBR";
            this.tBRToolStripMenuItem1.Click += new System.EventHandler(this.tBRToolStripMenuItem1_Click);
            // 
            // statisticiToolStripMenuItem1
            // 
            this.statisticiToolStripMenuItem1.Name = "statisticiToolStripMenuItem1";
            this.statisticiToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.statisticiToolStripMenuItem1.Text = "Statistici";
            this.statisticiToolStripMenuItem1.Click += new System.EventHandler(this.statisticiToolStripMenuItem1_Click);
            // 
            // setăriToolStripMenuItem2
            // 
            this.setăriToolStripMenuItem2.Name = "setăriToolStripMenuItem2";
            this.setăriToolStripMenuItem2.Size = new System.Drawing.Size(165, 26);
            this.setăriToolStripMenuItem2.Text = "Setări";
            this.setăriToolStripMenuItem2.Click += new System.EventHandler(this.setăriToolStripMenuItem2_Click);
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
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Favorite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Căutare:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(107, 155);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(235, 22);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(363, 155);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Caută";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 254);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 411);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lucrare_atestatDataSet1
            // 
            this.lucrare_atestatDataSet1.DataSetName = "lucrare_atestatDataSet1";
            this.lucrare_atestatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoriBindingSource
            // 
            this.autoriBindingSource.DataMember = "Autori";
            this.autoriBindingSource.DataSource = this.lucrare_atestatDataSet1;
            // 
            // autoriTableAdapter
            // 
            this.autoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoriTableAdapter = this.autoriTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartiTableAdapter = null;
            this.tableAdapterManager.ColectiiTableAdapter = null;
            this.tableAdapterManager.RecenziiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShelfLog.lucrare_atestatDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = null;
            // 
            // FormFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(460, 665);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormFavorites";
            this.Text = "+";
            this.Load += new System.EventHandler(this.FormFavorites_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lucrare_atestatDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem setăriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setăriToolStripMenuItem1;
        private lucrare_atestatDataSet1 lucrare_atestatDataSet1;
        private System.Windows.Forms.BindingSource autoriBindingSource;
        private lucrare_atestatDataSet1TableAdapters.AutoriTableAdapter autoriTableAdapter;
        private lucrare_atestatDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tBRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setăriToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}