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
    public partial class SignUp : Form
    {
        bool parolaViz=false;
        bool ReParolaViz = false;
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBoxVerifPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxVerifPassword.Text)
            {
                MessageBox.Show("Parolele nu se potrivesc.");
                return;
            }
            var ta = new lucrare_atestatDataSet1TableAdapters.UtilizatoriTableAdapter();
            var dt = ta.GetDataByEmail(textBoxEmail.Text);
            var dtUser= ta.GetDataByUsername(textBoxUsername.Text);
            if (dtUser.Rows.Count > 0)
            {
                MessageBox.Show("Acest username este deja folosit.");
                return;
            }
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Acest email este deja folosit.");
                return;
            }
            ta.Insert1(textBoxName.Text, textBoxEmail.Text, textBoxUsername.Text, textBoxPassword.Text);

            var newUser = ta.GetDataByEmail(textBoxEmail.Text);

            UserSess.UserId = (int)newUser.Rows[0]["UserId"];
            UserSess.Username = (string)newUser.Rows[0]["username"];

            MessageBox.Show("Cont creat cu succes!");

            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxVerifPassword.UseSystemPasswordChar = true;
            pictureBoxPassword.Image = Image.FromFile("C:\\Users\\Cris\\source\\repos\\ShelfLog\\visibilityOffImg.png");
            pictureBoxRecPas.Image = Image.FromFile("C:\\Users\\Cris\\source\\repos\\ShelfLog\\visibilityOffImg.png");
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPassword_Click(object sender, EventArgs e)
        {
            parolaViz = !parolaViz;
            if (parolaViz)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                pictureBoxPassword.Image = Image.FromFile("C:\\Users\\Cris\\source\\repos\\ShelfLog\\visibilityImg.png");
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                pictureBoxPassword.Image = Image.FromFile("C:\\Users\\Cris\\source\\repos\\ShelfLog\\visibilityOffImg.png");
            }
        }

        private void pictureBoxRecPas_Click(object sender, EventArgs e)
        {
            ReParolaViz = !ReParolaViz;
            if (ReParolaViz)
            {
                textBoxVerifPassword.UseSystemPasswordChar=false;
                pictureBoxRecPas.Image=Image.FromFile("C:\\Users\\Cris\\source\\repos\\ShelfLog\\visibilityImg.png");
            }
            else
            {
                textBoxVerifPassword.UseSystemPasswordChar=true;
                pictureBoxRecPas.Image=Image.FromFile("C:\\Users\\Cris\\source\\repos\\ShelfLog\\visibilityOffImg.png");
            }
        }
    }
}
