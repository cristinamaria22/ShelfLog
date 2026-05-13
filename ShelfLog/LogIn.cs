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
    public partial class LogIn : Form
    {
        bool parolaViz = false;

        public LogIn()
        {
            InitializeComponent();
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            textBoxParola.UseSystemPasswordChar = true;
            pictureBoxVisibility.Image = Image.FromFile("C:\\Users\\Cris\\source\\repos\\ShelfLog\\visibilityOffImg.png");

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            var ta = new lucrare_atestatDataSet1TableAdapters.UtilizatoriTableAdapter();
            var dt = ta.GetDataByEmailAndPassword(textBoxEmail.Text, textBoxParola.Text);

            if (dt.Rows.Count == 1)
            {
                UserSess.UserId = (int)dt.Rows[0]["UserId"];
                UserSess.Username = (string)dt.Rows[0]["username"];
                FormDashboard formDashboard = new FormDashboard();
                formDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email sau parolă greșită.");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void pictureBoxVisibility_Click(object sender, EventArgs e)
        {
            parolaViz = !parolaViz;

            if (parolaViz)
            {
                textBoxParola.UseSystemPasswordChar = false;
                pictureBoxVisibility.Image = Image.FromFile("C:\\Users\\Cris\\source\\repos\\ShelfLog\\visibilityImg.png");
            }
            else
            {
                textBoxParola.UseSystemPasswordChar = true;
                pictureBoxVisibility.Image = Image.FromFile("C:\\Users\\Cris\\source\\repos\\ShelfLog\\visibilityOffImg.png");
            }
        }
    }
}
