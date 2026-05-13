namespace ShelfLog
{
    partial class FormBookDetails
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.numericRating = new System.Windows.Forms.NumericUpDown();
            this.textBoxRecenzie = new System.Windows.Forms.TextBox();
            this.buttonSaveRev = new System.Windows.Forms.Button();
            this.buttonDeleteRev = new System.Windows.Forms.Button();
            this.labelStat = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonSaveStat = new System.Windows.Forms.Button();
            this.buttonFav = new System.Windows.Forms.Button();
            this.labelNrRate = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRate = new System.Windows.Forms.Label();
            this.checkBoxVisibility = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(112, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(48, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Titlu";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(27, 74);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(50, 19);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Autor";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGen.ForeColor = System.Drawing.Color.White;
            this.labelGen.Location = new System.Drawing.Point(248, 74);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(39, 19);
            this.labelGen.TabIndex = 2;
            this.labelGen.Text = "Gen";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.White;
            this.labelData.Location = new System.Drawing.Point(27, 110);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(104, 19);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Data apariției";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.Color.White;
            this.labelRating.Location = new System.Drawing.Point(27, 171);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(58, 19);
            this.labelRating.TabIndex = 4;
            this.labelRating.Text = "Raiting";
            // 
            // numericRating
            // 
            this.numericRating.Location = new System.Drawing.Point(91, 171);
            this.numericRating.Name = "numericRating";
            this.numericRating.Size = new System.Drawing.Size(120, 22);
            this.numericRating.TabIndex = 5;
            // 
            // textBoxRecenzie
            // 
            this.textBoxRecenzie.Location = new System.Drawing.Point(31, 206);
            this.textBoxRecenzie.Multiline = true;
            this.textBoxRecenzie.Name = "textBoxRecenzie";
            this.textBoxRecenzie.Size = new System.Drawing.Size(385, 137);
            this.textBoxRecenzie.TabIndex = 6;
            this.textBoxRecenzie.TextChanged += new System.EventHandler(this.textBoxRecenzie_TextChanged);
            // 
            // buttonSaveRev
            // 
            this.buttonSaveRev.Location = new System.Drawing.Point(81, 352);
            this.buttonSaveRev.Name = "buttonSaveRev";
            this.buttonSaveRev.Size = new System.Drawing.Size(112, 23);
            this.buttonSaveRev.TabIndex = 7;
            this.buttonSaveRev.Text = "Salvează ";
            this.buttonSaveRev.UseVisualStyleBackColor = true;
            this.buttonSaveRev.Click += new System.EventHandler(this.buttonSaveRev_Click);
            // 
            // buttonDeleteRev
            // 
            this.buttonDeleteRev.Location = new System.Drawing.Point(261, 352);
            this.buttonDeleteRev.Name = "buttonDeleteRev";
            this.buttonDeleteRev.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRev.TabIndex = 8;
            this.buttonDeleteRev.Text = "Șterge";
            this.buttonDeleteRev.UseVisualStyleBackColor = true;
            this.buttonDeleteRev.Click += new System.EventHandler(this.buttonDeleteRev_Click);
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat.ForeColor = System.Drawing.Color.White;
            this.labelStat.Location = new System.Drawing.Point(28, 399);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(57, 19);
            this.labelStat.TabIndex = 9;
            this.labelStat.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(91, 399);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 10;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // buttonSaveStat
            // 
            this.buttonSaveStat.Location = new System.Drawing.Point(326, 441);
            this.buttonSaveStat.Name = "buttonSaveStat";
            this.buttonSaveStat.Size = new System.Drawing.Size(90, 23);
            this.buttonSaveStat.TabIndex = 11;
            this.buttonSaveStat.Text = "Salvează";
            this.buttonSaveStat.UseVisualStyleBackColor = true;
            this.buttonSaveStat.Click += new System.EventHandler(this.buttonSaveStat_Click);
            // 
            // buttonFav
            // 
            this.buttonFav.Location = new System.Drawing.Point(248, 398);
            this.buttonFav.Name = "buttonFav";
            this.buttonFav.Size = new System.Drawing.Size(168, 23);
            this.buttonFav.TabIndex = 12;
            this.buttonFav.Text = "Adaugă la favorite <3";
            this.buttonFav.UseVisualStyleBackColor = true;
            this.buttonFav.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // labelNrRate
            // 
            this.labelNrRate.AutoSize = true;
            this.labelNrRate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrRate.ForeColor = System.Drawing.Color.White;
            this.labelNrRate.Location = new System.Drawing.Point(130, 480);
            this.labelNrRate.Name = "labelNrRate";
            this.labelNrRate.Size = new System.Drawing.Size(120, 19);
            this.labelNrRate.TabIndex = 13;
            this.labelNrRate.Text = "Număr recenzii";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 512);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 153);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRate.ForeColor = System.Drawing.Color.White;
            this.labelRate.Location = new System.Drawing.Point(248, 110);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(0, 19);
            this.labelRate.TabIndex = 15;
            // 
            // checkBoxVisibility
            // 
            this.checkBoxVisibility.AutoSize = true;
            this.checkBoxVisibility.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVisibility.ForeColor = System.Drawing.Color.White;
            this.checkBoxVisibility.Location = new System.Drawing.Point(252, 170);
            this.checkBoxVisibility.Name = "checkBoxVisibility";
            this.checkBoxVisibility.Size = new System.Drawing.Size(104, 23);
            this.checkBoxVisibility.TabIndex = 17;
            this.checkBoxVisibility.Text = "Vizibilitate";
            this.checkBoxVisibility.UseVisualStyleBackColor = true;
            this.checkBoxVisibility.CheckedChanged += new System.EventHandler(this.checkBoxVisibility_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 442);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // FormBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(460, 665);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxVisibility);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelNrRate);
            this.Controls.Add(this.buttonFav);
            this.Controls.Add(this.buttonSaveStat);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.buttonDeleteRev);
            this.Controls.Add(this.buttonSaveRev);
            this.Controls.Add(this.textBoxRecenzie);
            this.Controls.Add(this.numericRating);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormBookDetails";
            this.Text = "FormBookDetails";
            this.Load += new System.EventHandler(this.FormBookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.NumericUpDown numericRating;
        private System.Windows.Forms.TextBox textBoxRecenzie;
        private System.Windows.Forms.Button buttonSaveRev;
        private System.Windows.Forms.Button buttonDeleteRev;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonSaveStat;
        private System.Windows.Forms.Button buttonFav;
        private System.Windows.Forms.Label labelNrRate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.CheckBox checkBoxVisibility;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}