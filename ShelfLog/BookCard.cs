using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelfLog
{
    public partial class BookCard : UserControl
    {
        private int carteId;
        public BookCard(lucrare_atestatDataSet1.DataTable1Row book)
        {
            InitializeComponent();
            styleText();
            carteId= book.CarteId;
            labelTitle.Text = book.Titlu;
            labelAuthor.Text = $"{book.Nume.Trim()} {book.Prenume.Trim()}";
            labelGen.Text = book.Gen;
            labelAn.Text = book.An_Publicatie.ToString("yyyy-MM-dd");



        }
        private void styleText()
        {
            labelTitle.AutoSize = true;
            labelTitle.MaximumSize = new Size(250, 0);
            labelAuthor.AutoSize = true;
            labelAuthor.MaximumSize = new Size(250, 0);
            labelGen.AutoSize = true;
            labelGen.MaximumSize = new Size(250, 0);
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            labelAuthor.TextAlign = ContentAlignment.MiddleLeft;
            labelGen.TextAlign = ContentAlignment.MiddleLeft;

        }
        private void BookCard_Load(object sender, EventArgs e)
        {

        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonDetails_Click_1(object sender, EventArgs e)
        {
            var formDetails = new FormBookDetails(carteId);
            formDetails.Show();
        }
    }
}
