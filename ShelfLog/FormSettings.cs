using ShelfLog.lucrare_atestatDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelfLog
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        UtilizatoriTableAdapter usersTA = new UtilizatoriTableAdapter();
       
        private void FormSettings_Load(object sender, EventArgs e)
        {
            var info=usersTA.GetUserInfo(UserSess.UserId);
            if (UserSess.UserId != 0)
            {
               labelAutentif.Hide();
                labelName.Text = "Nume: " + info[0].Nume;
                labelEmail.Text = "Email: " + info[0].Email;
                labelUsername.Text = "Username: " + info[0].username;
            }
            else
            {
                labelName.Hide();
                labelEmail.Hide();
                labelUsername.Hide();
                ButtonLogOut.Hide();
            }
        }

        private void labelAutentif_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void cărțiToolStripMenuItem_Click(object sender, EventArgs e)
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
                    LogIn logIn = new LogIn();
                    logIn.Show();
                    this.Hide();
                }
            }
            
        }

        private void favoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            if(UserSess.UserId != 0)
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
                    LogIn logIn = new LogIn();
                    logIn.Show();
                    this.Hide();
                }
            }
        }

        private void tBRToolStripMenuItem_Click(object sender, EventArgs e)
        {   if (UserSess.UserId != 0)
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
                    LogIn logIn = new LogIn();
                    logIn.Show();
                    this.Hide();
                }
            }

        }

        private void statisticiToolStripMenuItem_Click(object sender, EventArgs e)
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
                    LogIn logIn = new LogIn();
                    logIn.Show();
                    this.Hide();
                }
            }
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            UserSess.UserId = 0;
            UserSess.Username = null;
            MessageBox.Show("Deconectat cu succes!");
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
