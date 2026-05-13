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

namespace ShelfLog
{
    public partial class FormFavorites : Form
    {
        public FormFavorites()
        {
            InitializeComponent();
        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setăriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void cărțiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarti carti = new FormCarti();
            carti.Show();
            this.Hide();
        }

        private void favoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFavorites favorites = new FormFavorites();
            favorites.Show();
            this.Hide();
        }

        private void tBRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTBR tbr = new FormTBR();
            tbr.Show();
            this.Hide();
        }

        private void statisticiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormStatistics statistics = new FormStatistics();
            statistics.Show();
            this.Hide();
        }

        private void setăriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormStatistics statistics = new FormStatistics();
            statistics.Show();
            this.Hide();
        }


        private void autoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lucrare_atestatDataSet1);

        }
        private int userId= UserSess.UserId;

        private DataTable1TableAdapter colectiiTA = new DataTable1TableAdapter();

        private void ShowNoResultsMessage()
        {
            Label msg = new Label();
            msg.Text = "Nu se găsește nicio carte";
            msg.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            msg.ForeColor = Color.Gray;
            msg.AutoSize = false;
            msg.TextAlign = ContentAlignment.MiddleCenter;
            msg.Dock = DockStyle.Top;
            msg.Height = 40;

            flowLayoutPanel1.Controls.Add(msg);
        }

        private void FormFavorites_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            var data = colectiiTA.GetFavBooks(userId);

            foreach (var row in data)
            {
                flowLayoutPanel1.Controls.Add(new BookCard(row));
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text.Trim().ToLower();
            flowLayoutPanel1.Controls.Clear();

            var all = colectiiTA.GetFavBooks(userId);

            var filtered = all
                .Where(b => b.Titlu.ToLower().Contains(text))
                .ToList();
            if (filtered.Count == 0)
            {
                ShowNoResultsMessage();
                return;
            }
            foreach (var row in filtered)
                flowLayoutPanel1.Controls.Add(new BookCard(row));

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text.Trim();
            flowLayoutPanel1.Controls.Clear();

            if (string.IsNullOrEmpty(text))
            {
                var all = colectiiTA.GetFavBooks(userId);
                foreach (var row in all)
                    flowLayoutPanel1.Controls.Add(new BookCard(row));

                return;
            }

            var data = colectiiTA.GetFavBookByTitle(userId, text);
            foreach (var row in data)
                flowLayoutPanel1.Controls.Add(new BookCard(row));
        }
    }
}
