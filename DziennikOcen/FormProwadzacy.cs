using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DziennikOcen
{
    public partial class FormProwadzacy : Form
    {
        DziennikOcenEntities db = new DziennikOcenEntities();
        PROWADZĄCY zalogowany;
        String String_imie_prowadzacego, String_nazwisko_prowadzacego, String_id_projektu, Email, Haslo;

        public FormProwadzacy(string Email, string Haslo)
        {
            InitializeComponent();
            this.Email = Email;
            this.Haslo = Haslo;
            this.zalogowany = ZnajdzProwadzacego(Email, Haslo);

            dgvStudenci.Visible = false;
            dgvStudenciProjekty.Visible = false;
            dgvprojekty.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            btnDodajStudenta.Visible = false;
            btnEdytujProjekt.Visible = false;
            btnEdytujStudenta.Visible = false;
            btnUsunProjekt.Visible = false;
            btnUsunStudenta.Visible = false;
            label3.Visible = false;
            btnDodajProjektt.Visible = false;
            btnEdytujProjektt.Visible = false;
            btnUsunProjektt.Visible = false;
        }

        private STUDENT AktualnieZaznaczonyStudent
        {
            get { return bsStudenci.Current as STUDENT; }
        }

        private PROJEKT AktualnieZaznaczonyProjekt
        {
            get { return bsprojektyy.Current as PROJEKT; }
        }

        private void ZaladujStudentow()
        {
            bsStudenci.DataSource = null;
            bsStudenci.DataSource = db.STUDENT.ToList();
        }

        private void ZaladujProjekty()
        {
            bsprojektyy.DataSource = null;
            bsprojektyy.DataSource = db.PROJEKT.ToList(); 
        }

        private void studenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvprojekty.Visible = false;
            dgvStudenci.Visible = true;
            dgvStudenciProjekty.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            btnDodajStudenta.Visible = true;
            btnEdytujProjekt.Visible = true;
            btnEdytujStudenta.Visible = true;
            btnUsunProjekt.Visible = true;
            btnUsunStudenta.Visible = true;
            label3.Visible = false;
            btnDodajProjektt.Visible = false;
            btnEdytujProjektt.Visible = false;
            btnUsunProjektt.Visible = false;
            ZaladujStudentow();
        }

        private void ZaladujProjekty(STUDENT AktualnieZaznaczonyStudent)
        {
            dgvStudenciProjekty.DataSource = null;
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = "SELECT projekty.id_PROJEKTU as \"ID projektu\", PROJEKT.nazwa_projektu as \"Nazwa\", PROJEKT.opis_projektu as \"Opis\", projekty.ocena_projektu as \"Ocena\", projekty.data_projektu as \"data\", projekty.uwagi_projektu as \"Uwagi\", PROWADZĄCY.imie as \"Imię prowadzącego\", PROWADZĄCY.nazwisko as \"Nazwisko prowadzącego\" FROM PROJEKT INNER JOIN projekty on PROJEKT.id_PROJEKTU=projekty.id_PROJEKTU INNER JOIN PROWADZĄCY ON PROWADZĄCY.id_PROWADZĄCEGO=projekty.id_PROWADZĄCEGO WHERE projekty.id_STUDENTA = @idstudenta";

                cmd.Parameters.AddWithValue("@idstudenta", AktualnieZaznaczonyStudent.id_STUDENTA);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvStudenciProjekty.DataSource = ds.Tables[0].DefaultView;
                dgvStudenciProjekty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                connection.Close();
            }
        }

        public projekty ZnajdzProjekt(int id, int idst)
        {
            projekty projekt = new projekty();
            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT projekty.id_STUDENTA, projekty.id_PROJEKTU, projekty.id_PROWADZĄCEGO, projekty.ocena_projektu, projekty.data_projektu, projekty.uwagi_projektu FROM projekty 
                                        WHERE [id_PROJEKTU] like @id and [id_STUDENTA] like @idst", Connection);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@idst", idst);

                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        projekt.id_STUDENTA = Int32.Parse(oReader["id_STUDENTA"].ToString());
                        projekt.id_PROJEKTU = Int32.Parse(oReader["id_PROJEKTU"].ToString());
                        projekt.id_PROWADZĄCEGO = Int32.Parse(oReader["id_PROWADZĄCEGO"].ToString());
                        if (!String.IsNullOrEmpty(oReader["ocena_projektu"].ToString())) projekt.ocena_projektu = Int32.Parse(oReader["ocena_projektu"].ToString());
                        if (!String.IsNullOrEmpty(oReader["data_projektu"].ToString())) projekt.data_projektu = DateTime.Parse(oReader["data_projektu"].ToString());
                       projekt.uwagi_projektu = oReader["uwagi_projektu"].ToString();
                        
                    }

                    Connection.Close();
                }
            }
            return projekt;
        }

        public PROWADZĄCY ZnajdzProwadzacego(string Email, string Haslo)
        {
            PROWADZĄCY prowadzacy = new PROWADZĄCY();
            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT PROWADZĄCY.id_PROWADZĄCEGO, PROWADZĄCY.imie, PROWADZĄCY.nazwisko, PROWADZĄCY.telefon, PROWADZĄCY.adres, PROWADZĄCY.[e-mail], PROWADZĄCY.haslo, PROWADZĄCY.stanowisko FROM PROWADZĄCY INNER JOIN przedmioty ON PROWADZĄCY.id_PROWADZĄCEGO=przedmioty.id_PROWADZĄCEGO INNER JOIN PRZEDMIOT ON przedmioty.id_PRZEDMIOTU=PRZEDMIOT.id_PRZEDMIOTU  
                                        WHERE [e-mail] like @email and [haslo] like @haslo", Connection);

                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@haslo", Haslo);
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

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            FormZarzadzajStudentem okno = new FormZarzadzajStudentem(null, db.GRUPA.ToList());
            if (okno.ShowDialog() == DialogResult.OK)
            {
                STUDENT nowy = okno.Student;
                db.STUDENT.Add(nowy);
                db.SaveChanges();
                ZaladujStudentow();
            }
        }

        private void btnEdytujStudenta_Click(object sender, EventArgs e)
        {
            FormZarzadzajStudentem okno = new FormZarzadzajStudentem(AktualnieZaznaczonyStudent, db.GRUPA.ToList());
            if (okno.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                ZaladujStudentow();
            }
        }

        private void btnUsunProjekt_Click(object sender, EventArgs e)
        {
            int idst = AktualnieZaznaczonyStudent.id_STUDENTA;
            projekty projekt = ZnajdzProjekt(Int32.Parse(String_id_projektu), idst);
            
            db.projekty.Attach(projekt);
            var entry = db.Entry(projekt);
            db.projekty.Remove(projekt);

            db.SaveChanges();
            ZaladujProjekty(AktualnieZaznaczonyStudent);
            
        }

        private void FormProwadzacy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void projektyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvStudenci.Visible = false;
            dgvStudenciProjekty.Visible = false;
            dgvprojekty.Visible = true;
            
            label1.Visible = false;
            label2.Visible = false;
            btnDodajStudenta.Visible = false;
            btnEdytujProjekt.Visible = false;
            btnEdytujStudenta.Visible = false;
            btnUsunProjekt.Visible = false;
            btnUsunStudenta.Visible = false;

            label3.Visible = true;
            btnDodajProjektt.Visible = true;
            btnEdytujProjektt.Visible = true;
            btnUsunProjektt.Visible = true;
            ZaladujProjekty();
        }

        private void btnDodajProjektt_Click(object sender, EventArgs e)
        {
           FormProjekt okno = new FormProjekt(null, db.PRZEDMIOT.ToList(), zalogowany.id_PROWADZĄCEGO);
            if (okno.ShowDialog() == DialogResult.OK)
            {
                PROJEKT nowy = okno.Projekt;
                db.PROJEKT.Add(nowy);
                db.SaveChanges();
                ZaladujProjekty();
            }
        }

        
        private void btnEdytujProjektt_Click(object sender, EventArgs e)
        {
            FormProjekt okno = new FormProjekt(AktualnieZaznaczonyProjekt, db.PRZEDMIOT.ToList(), zalogowany.id_PROWADZĄCEGO);
            if (okno.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                ZaladujProjekty();
            }
        }

        private void btnUsunProjektt_Click(object sender, EventArgs e)
        {
            db.PROJEKT.Remove(AktualnieZaznaczonyProjekt);
            db.SaveChanges();
            ZaladujProjekty();
        }

        private void btnUsunStudenta_Click(object sender, EventArgs e)
        {
            db.STUDENT.Remove(AktualnieZaznaczonyStudent);
            db.SaveChanges();
            ZaladujStudentow();
        }

        private void dgvStudenciProjekty_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudenciProjekty.SelectedRows)
            {
                String_id_projektu = row.Cells[0].Value.ToString();
                String_imie_prowadzacego = row.Cells[6].Value.ToString();
                String_nazwisko_prowadzacego = row.Cells[7].Value.ToString();
            }
        }

        private void dgvStudenci_MouseClick(object sender, MouseEventArgs e)
        {
            dgvStudenciProjekty.DataSource = null;
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = "SELECT projekty.id_PROJEKTU as \"ID projektu\", PROJEKT.nazwa_projektu as \"Nazwa\", PROJEKT.opis_projektu as \"Opis\", projekty.ocena_projektu as \"Ocena\", projekty.data_projektu as \"data\", projekty.uwagi_projektu as \"Uwagi\", PROWADZĄCY.imie as \"Imię prowadzącego\", PROWADZĄCY.nazwisko as \"Nazwisko prowadzącego\" FROM PROJEKT INNER JOIN projekty on PROJEKT.id_PROJEKTU=projekty.id_PROJEKTU INNER JOIN PROWADZĄCY ON PROWADZĄCY.id_PROWADZĄCEGO=projekty.id_PROWADZĄCEGO WHERE projekty.id_STUDENTA = @idstudenta";

                cmd.Parameters.AddWithValue("@idstudenta", AktualnieZaznaczonyStudent.id_STUDENTA);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvStudenciProjekty.DataSource = ds.Tables[0].DefaultView;
                dgvStudenciProjekty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                connection.Close();
            }
        }

        private void btnEdytujProjekt_Click(object sender, EventArgs e)
        {
            int idst = AktualnieZaznaczonyStudent.id_STUDENTA;
            projekty projekt = ZnajdzProjekt(Int32.Parse(String_id_projektu), idst);
            
            if (projekt.id_PROWADZĄCEGO != zalogowany.id_PROWADZĄCEGO)
            {
                //nie Twój projekt
                MessageBox.Show("Nie Ty zarządzasz tym projektem!");
            }
            else
            {
                FormZarzadzajProjektem okno = new FormZarzadzajProjektem(projekt);
                if (okno.ShowDialog() == DialogResult.OK)
                {
                    db.projekty.Attach(projekt);
                    var entry = db.Entry(projekt);
                    entry.Property(p => p.ocena_projektu).IsModified = true;
                    entry.Property(p => p.data_projektu).IsModified = true;
                    entry.Property(p => p.uwagi_projektu).IsModified = true;
                    db.SaveChanges();
                    ZaladujProjekty(AktualnieZaznaczonyStudent);
                }
            }
            
        }

    }
}
