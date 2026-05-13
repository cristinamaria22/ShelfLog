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
    public partial class FormCarti : Form
    {
        public FormCarti()
        {
            InitializeComponent();
        }

        private void DisplayBooks(IEnumerable<lucrare_atestatDataSet1.DataTable1Row> books)
        {
            // flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
           
            foreach (var book in books)
            {
                flowLayoutPanel1.Controls.Add(new BookCard(book));
            }
           // flowLayoutPanel1.ResumeLayout();
        }


        private void LoadFilters()
        {
            comboBoxFiltre.Items.Clear();
            comboBoxFiltre.Items.Add("Toate genurile");
            var books = dataTable1Adapter.GetBooksAndAuthorsDetails();
            var genuri = books.Select(b => b.Gen).Distinct().ToList();
            foreach (var row in genuri)
                comboBoxFiltre.Items.Add("Gen: " + row);
            comboBoxFiltre.Items.Add("Toți autorii");
            var autori = books
                .Select(b => new { b.AutorId, b.Nume, b.Prenume })
                .Distinct()
                .ToList();

            foreach (var a in autori)
                comboBoxFiltre.Items.Add($"Autor: {a.Nume} {a.Prenume} | {a.AutorId}");

            comboBoxFiltre.Items.Add("Rating >=1");
            comboBoxFiltre.Items.Add("Rating >=2");
            comboBoxFiltre.Items.Add("Rating >=3");
            comboBoxFiltre.Items.Add("Rating >=4");
            comboBoxFiltre.Items.Add("Rating =5");

            comboBoxFiltre.SelectedIndex = 0;
        }

        private void LoadSortOptions()
        {
            comboBoxSort.Items.Clear();
            comboBoxSort.Items.Add("Titlu A-Z");
            comboBoxSort.Items.Add("Titlu Z-A");
            comboBoxSort.Items.Add("An publicație crescator");
            comboBoxSort.Items.Add("An publicație descrescator");
            comboBoxSort.SelectedIndex = 0;
        }
        DataTable1TableAdapter dataTable1Adapter = new DataTable1TableAdapter();
        AutoriTableAdapter autoriAdapter = new AutoriTableAdapter();

        private void FormCarti_Load(object sender, EventArgs e)
        {
            
            LoadFilters();
            LoadSortOptions();
            var books = dataTable1Adapter.GetBooksAndAuthorsDetails();
            DisplayBooks(books);

        }



        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Close();
        }
        private void favoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFavorites formFavorites = new FormFavorites();
            formFavorites.Show();
            this.Hide();
        }

        private void tBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void statisticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics();
            formStatistics.Show();
            this.Hide();
        }

        private void setăriToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void Search_Click(object sender, EventArgs e)
        {
            textBoxSearch_TextChanged(sender, e);
        }


        private void comboBoxFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = comboBoxSort.SelectedItem.ToString();
            var books = dataTable1Adapter.GetBooksAndAuthorsDetails();
            switch (option){
                case "Titlu A-Z":
                    books = dataTable1Adapter.SortByTitleASC();
                    break;
                case "Titlu Z-A":
                    books = dataTable1Adapter.SortByTitleDESC();
                    break;
                case "An publicație crescator":
                    books = dataTable1Adapter.SortByYearASC();
                    break;
                case "An publicație descrescator":
                    books = dataTable1Adapter.SortByYearDESC();
                    break;
            }
            DisplayBooks(books);
        }

        private void buttonFiltre_Click(object sender, EventArgs e)
        {
            string option = comboBoxFiltre.SelectedItem.ToString();
            IEnumerable<lucrare_atestatDataSet1.DataTable1Row> books =
         dataTable1Adapter.GetBooksAndAuthorsDetails();
            if (option == "Toate genurile")
            {
                books = dataTable1Adapter.GetBooksAndAuthorsDetails();
            }
            else if (option.StartsWith("Gen: "))
            {
                string gen = option.Replace("Gen: ", "");
                books = dataTable1Adapter.GetBooksByGenre(gen);
            }
            else if (option.StartsWith("Autor: "))
            {
                string[] parts = option.Split('|');
                int autorId = int.Parse(parts[1].Trim());
                books = books.Where(b => b.AutorId == autorId).ToList();

            }
            else if (option.StartsWith("Rating"))
            {
                int minrating = int.Parse(option.Split('=')[1].Trim());
                var dt = dataTable1Adapter.GetBooksByRating(minrating);
                books = dt.Cast<lucrare_atestatDataSet1.DataTable1Row>();
            }

            DisplayBooks(books);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxFiltre.SelectedIndex = 0;
           var books = dataTable1Adapter.GetBooksAndAuthorsDetails();
            DisplayBooks(books);
        }

      

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxSearch.Text.Trim().ToLower();
            var results = dataTable1Adapter.GetBooksAndAuthorsDetails();
            var books = dataTable1Adapter.GetBooksAndAuthorsDetails()
        .Where(b => b.Titlu.ToLower().Contains(text))
        .ToList();

            DisplayBooks(books);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tBRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormTBR formTBR = new FormTBR();
            formTBR.Show();
            this.Hide();
        }

        private void statisticiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics();
            formStatistics.Show();
            this.Hide();
        }

        private void setăriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
            this.Hide();
        }
    }      
}
