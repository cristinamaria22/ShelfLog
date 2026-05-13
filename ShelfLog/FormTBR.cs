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
    public partial class FormTBR : Form
    {
        public FormTBR()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void cărțiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarti formCarti = new FormCarti();
            formCarti.Show();
            this.Hide();
        }

        private void favoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFavorites formFavorites = new FormFavorites();
            formFavorites.Show();
            this.Hide();
        }

        private void statisticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics();
            formStatistics.Show();
            this.Hide();
        }

        private void setăriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
            this.Hide();
        }
        private int userId = UserSess.UserId;

        private DataTable1TableAdapter colectiiTA = new DataTable1TableAdapter();
        private void FormTBR_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            var data = colectiiTA.GetTBRBooks(userId);

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

            var all = colectiiTA.GetTBRBooks(userId);

            var filtered = all
                .Where(b => b.Titlu.ToLower().Contains(text))
                .ToList();

            foreach (var row in filtered)
                flowLayoutPanel1.Controls.Add(new BookCard(row));
        }
    }
}
