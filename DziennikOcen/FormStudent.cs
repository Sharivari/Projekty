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
    public partial class FormStudent : Form
    {
        STUDENT student;
        DziennikOcenEntities db = new DziennikOcenEntities();
        String Haslo;
        String Email;
        projekty projekty;
        PROJEKT projekt;
        PROWADZĄCY prowadzacy;
        String String_nazwa_projektu;
        String String_nazwa_przedmiotu;
        public FormStudent(string Email, string Haslo)
        {
            InitializeComponent();
            dgvPrzedmioty.Visible = false;
            dgvStudent.Visible = false;
            dgvMojeProjekty.Visible = false;
            dgvProjekty.Visible = false;
            button1.Visible = false;
            this.Haslo = Haslo;
            this.Email = Email;
            student = ZnajdzStudenta(Email, Haslo);
            
        }

        public STUDENT ZnajdzStudenta(string Email, string Haslo)
        {
            STUDENT student = new STUDENT();
            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM STUDENT 
                                        WHERE [haslo] like @haslo and 
                                        [e-mail] like @email", Connection);

                cmd.Parameters.AddWithValue("@haslo", Haslo);
                cmd.Parameters.AddWithValue("@email", Email);

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        student.id_STUDENTA = Int32.Parse(oReader["id_STUDENTA"].ToString());
                        student.imie = oReader["imie"].ToString();
                        student.nazwisko = oReader["nazwisko"].ToString();
                        student.telefon = oReader["telefon"].ToString();
                        student.adres = oReader["adres"].ToString();
                        student.e_mail = oReader["e-mail"].ToString();
                        student.haslo = oReader["haslo"].ToString();

                    }

                    Connection.Close();
                }
            }
            return student;
        }

        public PROJEKT ZnajdzProjekt(string nazwa)
        {
            PROJEKT projekt = new PROJEKT();
            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM PROJEKT 
                                        WHERE [nazwa_projektu] like @nazwa", Connection);

                cmd.Parameters.AddWithValue("@nazwa", nazwa);

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        projekt.id_PROJEKTU = Int32.Parse(oReader["id_PROJEKTU"].ToString());
                        projekt.id_PRZEDMIOTU = Int32.Parse(oReader["id_PRZEDMIOTU"].ToString());
                        projekt.nazwa_projektu = oReader["nazwa_projektu"].ToString();
                        projekt.opis_projektu = oReader["opis_projektu"].ToString();

                    }

                    Connection.Close();
                }
            }
            return projekt;
        }

        public PROWADZĄCY ZnajdzProwadzacego(string nazwa_przedmiotu)
        {
            PROWADZĄCY prowadzacy = new PROWADZĄCY();
            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT PROWADZĄCY.id_PROWADZĄCEGO, PROWADZĄCY.imie, PROWADZĄCY.nazwisko, PROWADZĄCY.telefon, PROWADZĄCY.adres, PROWADZĄCY.[e-mail], PROWADZĄCY.haslo, PROWADZĄCY.stanowisko FROM PROWADZĄCY INNER JOIN przedmioty ON PROWADZĄCY.id_PROWADZĄCEGO=przedmioty.id_PROWADZĄCEGO INNER JOIN PRZEDMIOT ON przedmioty.id_PRZEDMIOTU=PRZEDMIOT.id_PRZEDMIOTU  
                                        WHERE [nazwa_przedmiotu] like @nazwa", Connection);

                cmd.Parameters.AddWithValue("@nazwa", nazwa_przedmiotu);

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        prowadzacy.id_PROWADZĄCEGO = Int32.Parse(oReader["id_PROWADZĄCEGO"].ToString());
                        prowadzacy.imie = oReader["imie"].ToString();
                        prowadzacy.nazwisko = oReader["nazwisko"].ToString();
                        prowadzacy.telefon = oReader["telefon"].ToString();
                        prowadzacy.adres = oReader["adres"].ToString();
                        prowadzacy.e_mail = oReader["e-mail"].ToString();
                        prowadzacy.haslo = oReader["haslo"].ToString();
                        prowadzacy.stanowisko = oReader["stanowisko"].ToString();
                    }
                    Connection.Close();
                }
            }
            return prowadzacy;
        }

        private void ZaladujPrzedmioty()
        {
            dgvPrzedmioty.DataSource = null;
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = "SELECT PRZEDMIOT.nazwa_przedmiotu, PRZEDMIOT.ECTS, PROWADZĄCY.imie, PROWADZĄCY.nazwisko, przedmioty.[ocena przedmiotu], przedmioty.data_zaliczenia_przedmiotu, przedmioty.uwagi_przedmiotu FROM PRZEDMIOT INNER JOIN przedmioty ON PRZEDMIOT.id_PRZEDMIOTU = przedmioty.id_PRZEDMIOTU INNER JOIN PROWADZĄCY ON PROWADZĄCY.id_PROWADZĄCEGO = przedmioty.id_PROWADZĄCEGO";
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvPrzedmioty.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void ZaladujDaneStudenta()
        {
            dgvStudent.DataSource = null;
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = "SELECT STUDENT.id_GRUPY, STUDENT.imie, STUDENT.nazwisko, STUDENT.telefon, STUDENT.adres, STUDENT.[e-mail], STUDENT.haslo FROM STUDENT WHERE [haslo] like @haslo and  [e-mail] like @email";
                cmd.Parameters.AddWithValue("@haslo", Haslo);
                cmd.Parameters.AddWithValue("@email", Email); 
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvStudent.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void ZaladujProjekty()
        {

            
            dgvProjekty.DataSource = null;
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = "SELECT PROJEKT.nazwa_projektu as \"Nazwa projektu\", PROJEKT.opis_projektu as \"Opis\", PRZEDMIOT.nazwa_przedmiotu as \"Przedmiot\" FROM PROJEKT INNER JOIN PRZEDMIOT on PROJEKT.id_PRZEDMIOTU = PRZEDMIOT.id_PRZEDMIOTU";
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvProjekty.DataSource = ds.Tables[0].DefaultView;
                dgvProjekty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            
        }

        private void ZaladujMojeProjekty()
        {
            dgvMojeProjekty.DataSource = null;
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = "SELECT PROJEKT.nazwa_projektu as \"Nazwa projektu\", PROJEKT.opis_projektu as \"Opis\", PRZEDMIOT.nazwa_przedmiotu as \"Przedmiot\", projekty.data_projektu as \"Data\", projekty.ocena_projektu as \"Ocena\", projekty.uwagi_projektu as \"Uwagi\" FROM PROJEKT INNER JOIN PRZEDMIOT on PROJEKT.id_PRZEDMIOTU = PRZEDMIOT.id_PRZEDMIOTU INNER JOIN projekty on projekty.id_PROJEKTU=PROJEKT.id_PROJEKTU WHERE projekty.id_STUDENTA = @idstudenta";
                cmd.Parameters.AddWithValue("@idstudenta", student.id_STUDENTA);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvMojeProjekty.DataSource = ds.Tables[0].DefaultView;
                dgvMojeProjekty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }



        private void przedmiotyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPrzedmioty.Visible = true;
            dgvStudent.Visible = false;
            dgvMojeProjekty.Visible = false;
            dgvProjekty.Visible = false;
            button1.Visible = false;
            ZaladujPrzedmioty();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPrzedmioty.Visible = false;
            dgvStudent.Visible = true;
            dgvMojeProjekty.Visible = false;
            dgvProjekty.Visible = false;
            button1.Visible = false;
            ZaladujDaneStudenta();
        }

        private void projektyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPrzedmioty.Visible = false;
            dgvStudent.Visible = false;
            dgvMojeProjekty.Visible = true;
            dgvProjekty.Visible = true;
            button1.Visible = true;
            ZaladujMojeProjekty();
            ZaladujProjekty();
        }

        private void dgvProjekty_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProjekty.SelectedRows)
            {
                String_nazwa_projektu = row.Cells[0].Value.ToString();
                String_nazwa_przedmiotu = row.Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.projekt = ZnajdzProjekt(String_nazwa_projektu);
            this.projekty = new projekty();
            this.prowadzacy = ZnajdzProwadzacego(String_nazwa_przedmiotu);
            projekty.id_STUDENTA = student.id_STUDENTA;
            projekty.id_PROJEKTU = projekt.id_PROJEKTU;
            projekty.id_PROWADZĄCEGO = prowadzacy.id_PROWADZĄCEGO;

            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM projekty WHERE [id_PROJEKTU] = @idprojektu", Connection);
                    cmd.Parameters.AddWithValue("@idprojektu", projekt.id_PROJEKTU);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 2)
                    {
                        MessageBox.Show("Ten projekt osiągnął maksymalną ilość przypisanych studentów (3)");
                    }
                    else
                    {
                        using (SqlConnection Connection2 = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
                        {
                            try
                            {
                                Connection2.Open();
                                SqlCommand cmd2 = new SqlCommand(@"SELECT Count(*) FROM projekty WHERE [id_PROJEKTU] = @idprojektu and [id_STUDENTA] = @idstudenta", Connection2);
                                cmd2.Parameters.AddWithValue("@idprojektu", projekt.id_PROJEKTU);
                                cmd2.Parameters.AddWithValue("@idstudenta", student.id_STUDENTA);
                                int result2 = (int)cmd2.ExecuteScalar();
                                if (result2 > 0)
                                {
                                    MessageBox.Show("Jesteś już zapisany do tego projektu!");
                                }
                                else
                                {
                                    db.projekty.Add(projekty);
                                    db.SaveChanges();
                                    ZaladujMojeProjekty();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Unexpected error1: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error2: " + ex.Message);
                }
            }

            

        }

        private void FormStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
