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
    public partial class FormStatistics : Form
    {   
        private int userId = UserSess.UserId;
        UtilizatoriTableAdapter usersTA = new UtilizatoriTableAdapter();
        ColectiiTableAdapter collectionsTA = new ColectiiTableAdapter();
        public FormStatistics()
        {
            InitializeComponent();
            var date = usersTA.GetCreationDate(userId);
            labelCreateDate.Text = $"Cont creat la: {date:dd MMM yyyy}";
            labelTBR.Text = $" Favorite: {collectionsTA.CountTBR(userId)}";
            labelStarted.Text = $"Începute: {collectionsTA.CountStarted(userId)}";
            labelRead.Text = $"Citite: { collectionsTA.CountFinished(userId)}";
            labelGen.Text = "Genul favorit: " + (collectionsTA.GetFavoriteGenre(userId) ?? "N/A");
            labelAutor.Text = "Autorul preferat: "+ (collectionsTA.GetFavoriteAuthor(userId)?? "N/A");
            

        }

        private void labelFav_Click(object sender, EventArgs e)
        {

        }

        private void labelCreateDate_Click(object sender, EventArgs e)
        {

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

        private void tBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTBR formTBR = new FormTBR();
            formTBR.Show();
            this.Hide();
        }

        private void setăriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
            this.Hide();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {

        }
    }
}
