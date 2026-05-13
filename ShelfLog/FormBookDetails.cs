using ShelfLog.lucrare_atestatDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShelfLog
{
    public partial class FormBookDetails : Form
    {
        private int bookId;
        private int userId = UserSess.UserId;
        private bool esteFav = false;
        RecenziiTableAdapter recenziiTableAdapter = new RecenziiTableAdapter();
        DataTable1TableAdapter cartiTA = new DataTable1TableAdapter();

        public FormBookDetails(int bookId)
        {
            InitializeComponent();
            this.bookId = bookId;
        }

      
        private void FormBookDetails_Load(object sender, EventArgs e)
        {
            var carte = cartiTA.GetBookById(bookId)[0];
            labelTitle.Text = carte.Titlu;
            labelTitle.Anchor = AnchorStyles.Top;
            if(labelTitle.Text.Length > 30)
            {
                labelTitle.TextAlign = ContentAlignment.TopLeft;
            }



            labelAuthor.Text = "Autor:"+ $"{carte.Nume.Trim()} {carte.Prenume.Trim()}";
            labelGen.Text = "Gen:" + carte.Gen;
            labelData.Text="Data publicare "+ carte.An_Publicatie.ToShortDateString();
            int countReviews = recenziiTableAdapter.GetNumberOfReviews(bookId) ?? 0;
            if(countReviews==1)
                labelNrRate.Text = $"({countReviews} recenzie)";
            else
                labelNrRate.Text= $"({countReviews} recenzii)";
            var avgRating = recenziiTableAdapter.GetRating(bookId) ;
            double avg = avgRating.GetValueOrDefault();
            labelRating.Text = labelRating.Text = "Rating: " + avg.ToString("0.0") + "/5";
            ;
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("Necitită");
            comboBoxStatus.Items.Add("În lectură");
            comboBoxStatus.Items.Add("Citită");
            comboBoxStatus.Items.Add("TBR");

            var myReview = recenziiTableAdapter.GetReviewByUserAndBook(bookId, userId);
            if (myReview.Count > 0)
            {
                textBoxRecenzie.Text = myReview[0].Descriere_;
                numericRating.Value = (int)myReview[0].Rating;
                checkBoxVisibility.Checked = myReview[0].Vizibilitate == true;



            }
            ColectiiTableAdapter colectiiTA = new ColectiiTableAdapter();
            var entry = colectiiTA.GetCollectionEntry(userId, bookId);
            if (entry.Count > 0 && entry[0].Favorita )
            {
                buttonFav.Text = "Șterge din favorite 💔";
                esteFav = true;
            }
            else
            {
                buttonFav.Text = "Adaugă la favorite ❤️";
            }

            numericRating.Minimum = 1;
            numericRating.Maximum = 5;
            numericRating.Increment = 1;



            DataTable2TableAdapter recenziiTA = new DataTable2TableAdapter();
            var recenzii= recenziiTA.GetPublicReviews(bookId,userId);
            flowLayoutPanel1.Controls.Clear();
           
            foreach (var r in recenzii)
            {
                var card = new ReviewCard(
                    r.Username,
                    r.Rating,
                    r.Descriere
                );

                flowLayoutPanel1.Controls.Add(card);
            }



            var entry1 = colectiiTA.GetCollectionEntry(userId, bookId);

            if (entry1.Count > 0)
            {
                comboBoxStatus.SelectedItem = entry1[0].Status.Trim();
            }
            else
            {
                comboBoxStatus.SelectedIndex = 0;
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxRecenzie_TextChanged(object sender, EventArgs e)
        {
            var myReview = recenziiTableAdapter.GetReviewByUserAndBook(bookId, userId);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxVisibility_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveRev_Click(object sender, EventArgs e)
        {
         
            string descriere = textBoxRecenzie.Text.Trim();
            int rating = (int)numericRating.Value;
            int viz = checkBoxVisibility.Checked ? 1 : 0;

            var existing = recenziiTableAdapter.GetReviewByUserAndBook(bookId, userId);

            if (existing.Count > 0)
            {
                recenziiTableAdapter.UpdateReview( rating, descriere, viz==1, userId, bookId);
            }
            else
            {
                recenziiTableAdapter.InsertReview(userId, bookId, rating, descriere, viz == 1 );
            }

           
        }

        private void buttonDeleteRev_Click(object sender, EventArgs e)
        {
            var existing = recenziiTableAdapter.GetReviewByUserAndBook(bookId, userId);
            if (existing.Count>0)
            {
                recenziiTableAdapter.DeleteReview(userId, bookId);
                textBoxRecenzie.Text = "";
                numericRating.Value = 1;
                checkBoxVisibility.Checked = false;

                DataTable2TableAdapter recenziiTA = new DataTable2TableAdapter();
                var recenzii = recenziiTA.GetPublicReviews(bookId, userId);
                flowLayoutPanel1.Controls.Clear();
                foreach (var r in recenzii)
                {
                    var card = new ReviewCard(
                        r.Username,
                        r.Rating,
                        r.Descriere
                    );
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }

        private void buttonSaveStat_Click(object sender, EventArgs e)
        {
            string status = comboBoxStatus.SelectedItem.ToString();
            bool favorita = esteFav;
            string start = null;
            string end = null;


            if (status == "În lectură")
                start = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (status == "Citită")
                end = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            ColectiiTableAdapter colectiiTableAdapter = new ColectiiTableAdapter();
            var c=colectiiTableAdapter.GetCollectionEntry(userId, bookId);
            if(c.Count>0)
            {
                colectiiTableAdapter.UpdateCollectionEntry(status,favorita? true : false, start, end, userId, bookId);
            }
            else
            {
                colectiiTableAdapter.InserCollectionEntry(userId, bookId, status, favorita? true : false, start, end);
            }
        }

        private void buttonFav_Click(object sender, EventArgs e)
        {
            ColectiiTableAdapter colectiiTableAdapter = new ColectiiTableAdapter();
            var entry = colectiiTableAdapter.GetCollectionEntry(userId, bookId);
           
         
            if(esteFav)
            {
                colectiiTableAdapter.UpdateFavorite(false,userId, bookId);
                esteFav = false;
                buttonFav.Text = "Adaugă la favorite ❤️";
            }
            else
            {
                if(entry.Count == 0)
                {
                    colectiiTableAdapter.InserCollectionEntry(userId, bookId, "N/A", true, null, null );
                }
                else
                    colectiiTableAdapter.UpdateFavorite(true, userId, bookId);
                esteFav = true;
                buttonFav.Text = "Șterge din favorite 💔";
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = comboBoxStatus.SelectedItem.ToString();

            if (status == "În lectură")
            {
                dateTimePicker1.Visible = true;
                labelData.Visible = true;
               /// labelData.Text = "Data start:";
            }
            else if (status == "Citită")
            {
                dateTimePicker1.Visible = true;
                labelData.Visible = true;
               /// labelData.Text = "Data finalizare:";
            }
            else
            {
                dateTimePicker1.Visible = false;
                ///labelData.Visible = false;
            }
        }
    }
}
