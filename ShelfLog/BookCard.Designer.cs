namespace ShelfLog
{
    partial class BookCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelAn = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelAuthor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGen, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(3, 15);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(44, 15);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "label1";
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Location = new System.Drawing.Point(3, 30);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(44, 15);
            this.labelAn.TabIndex = 2;
            this.labelAn.Text = "label1";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(3, 45);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(44, 16);
            this.labelGen.TabIndex = 3;
            this.labelGen.Text = "label1";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(44, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "label1";
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(335, 15);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(87, 30);
            this.buttonDetails.TabIndex = 5;
            this.buttonDetails.Text = "Detalii";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click_1);
            // 
            // BookCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookCard";
            this.Size = new System.Drawing.Size(432, 61);
            this.Load += new System.EventHandler(this.BookCard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonDetails;
    }
}
