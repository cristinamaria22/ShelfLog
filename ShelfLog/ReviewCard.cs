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
    public partial class ReviewCard : UserControl
    {
        public ReviewCard(string user, double rating, string text)
        {
            InitializeComponent();
            labelUser.Text = user;
            labelRate.Text = "Rating: " + rating.ToString();
            labelTextReview.Text = text;
        }

        private void ReviewCard_Load(object sender, EventArgs e)
        {

        }
    }
}
