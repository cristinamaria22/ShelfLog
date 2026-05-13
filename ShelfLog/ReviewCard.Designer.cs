namespace ShelfLog
{
    partial class ReviewCard
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelTextReview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(4, 4);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(127, 19);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Nume Persoana";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRate.Location = new System.Drawing.Point(286, 4);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(72, 19);
            this.labelRate.TabIndex = 1;
            this.labelRate.Text = "Rating : ";
            // 
            // labelTextReview
            // 
            this.labelTextReview.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextReview.Location = new System.Drawing.Point(11, 32);
            this.labelTextReview.Name = "labelTextReview";
            this.labelTextReview.Size = new System.Drawing.Size(388, 48);
            this.labelTextReview.TabIndex = 2;
            this.labelTextReview.Text = "label1";
            // 
            // ReviewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.Controls.Add(this.labelTextReview);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelUser);
            this.Name = "ReviewCard";
            this.Size = new System.Drawing.Size(420, 91);
            this.Load += new System.EventHandler(this.ReviewCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelTextReview;
    }
}
