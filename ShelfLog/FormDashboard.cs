using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelfLog
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
           
        }

        private void cărțiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void labelTitluRecomandare_Click(object sender, EventArgs e)
        {

        }

        private void listBoxRecomandari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if (UserSess.UserId != 0)
            {
                labelWelcome.Text = $"Bine ai venit, {UserSess.Username.Trim()} !";
            }
            var ta = new lucrare_atestatDataSet1TableAdapters.DataTable1TableAdapter();
            var dt = ta.GetBooksAndAuthorsDetails();

            int count = dt.Rows.Count;
            Random random = new Random();
            int index = random.Next(0, count);
            string titlu = dt.Rows[index]["Titlu"].ToString();
            string autorFirstName = dt.Rows[index]["Nume"].ToString();
            string autorLastName = dt.Rows[index]["Prenume"].ToString();
            listBoxRecomandari.Items.Add(titlu.Trim());
            listBoxRecomandari.Items.Add(autorFirstName.Trim() + " " + autorLastName.Trim());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cărțiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (UserSess.UserId != 0)
            {
                FormCarti formCarti = new FormCarti();
                formCarti.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Trebuie să fii autentificat pentru a accesa această secțiune.\nVrei să mergi la pagina de autentificare?",
                    "Autentificare necesară",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    LogIn login= new LogIn();
                    login.Show();
                    this.Hide();
                }
            }
        }

        private void favoriteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UserSess.UserId != 0)
            {
                FormFavorites formFavorites = new FormFavorites();
                formFavorites.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Trebuie să fii autentificat pentru a accesa această secțiune.\nVrei să mergi la pagina de autentificare?",
                    "Autentificare necesară",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    LogIn login = new LogIn();
                    login.Show();
                    this.Hide();
                }
            }
        }

        private void tBRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UserSess.UserId != 0)
            {
                FormTBR formTBR = new FormTBR();    
                  formTBR.Show();
                   this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                   "Trebuie să fii autentificat pentru a accesa această secțiune.\nVrei să mergi la pagina de autentificare?",
                   "Autentificare necesară",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    LogIn login = new LogIn();
                    login.Show();
                    this.Hide();
                }
            }

        }

        private void statisticiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UserSess.UserId != 0)
            {
            FormStatistics formStatistics = new FormStatistics();   
                formStatistics.Show();
                 this.Hide();
            }
                
             else
            {
                DialogResult result = MessageBox.Show(
                   "Trebuie să fii autentificat pentru a accesa această secțiune.\nVrei să mergi la pagina de autentificare?",
                   "Autentificare necesară",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    LogIn login = new LogIn();
                    login.Show();
                    this.Hide();
                }
            }
        }

        private void setăriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
            this.Hide();
        }

      
        private void label2_Click(object sender, EventArgs e)
        {
           
        }
        private void labelWelcome_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGenerareRec_Click(object sender, EventArgs e)
        {
            var ta = new lucrare_atestatDataSet1TableAdapters.DataTable1TableAdapter();
            var dt = ta.GetBooksAndAuthorsDetails();

            int count = dt.Rows.Count;
            Random random = new Random();
            int index = random.Next(0,count);
            string titlu = dt.Rows[index]["Titlu"].ToString();
            string autorFirstName = dt.Rows[index]["Nume"].ToString();
            string autorLastName = dt.Rows[index]["Prenume"].ToString();
            listBoxRecomandari.Items.Clear();
            listBoxRecomandari.Items.Add(titlu.Trim());
            listBoxRecomandari.Items.Add(autorFirstName.Trim() + " " + autorLastName.Trim());


        }
    }
}
