using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DziennikOcen
{
    public partial class Form1 : Form
    {
        DziennikOcenEntities db = new DziennikOcenEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {

            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM STUDENT WHERE [haslo] like @haslo and [e-mail] like @email", Connection);
                    cmd.Parameters.AddWithValue("@haslo", tbxHaslo.Text);
                    cmd.Parameters.AddWithValue("@email", tbxEmail.Text);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    { 
                    FormStudent oknoStudenta = new FormStudent(tbxEmail.Text, tbxHaslo.Text);
                        oknoStudenta.Show();
                        this.Hide();
                    }
                    else
                    {
                        
                        SqlCommand cmdPr = new SqlCommand(@"SELECT Count(*) FROM PROWADZĄCY WHERE [haslo] like @haslo and [e-mail] like @email", Connection);
                        cmdPr.Parameters.AddWithValue("@haslo", tbxHaslo.Text);
                        cmdPr.Parameters.AddWithValue("@email", tbxEmail.Text);
                        int resultPr = (int)cmdPr.ExecuteScalar();
                        if (resultPr > 0)
                        {
                            FormProwadzacy oknoProwadzacego = new FormProwadzacy(tbxEmail.Text, tbxHaslo.Text);
                            oknoProwadzacego.Show();
                            this.Hide();
                        }
                        else if (tbxHaslo.Text.Equals("admin") && tbxEmail.Text.Equals("admin"))
                        {
                            FormAdmin oknoAdministrator = new FormAdmin();
                            oknoAdministrator.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("Błędny login lub hasło.");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            tbxEmail.Text = "ula@op.pl";
            tbxHaslo.Text = "bleble";
        }

        private void btnProwadzacy_Click(object sender, EventArgs e)
        {
            tbxEmail.Text = "andrzej@op.pl";
            tbxHaslo.Text = "hasloo";
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            tbxEmail.Text = "admin";
            tbxHaslo.Text = "admin";
        }
    }
}
