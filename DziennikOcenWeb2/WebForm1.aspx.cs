using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DziennikOcenWeb2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DziennikOcenEntities db = new DziennikOcenEntities();
        projekty projekty;
        PROJEKT projekt;
        PROWADZĄCY prowadzacy;
        STUDENT student;
        //Boolean first = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                Przedmiott.Visible = false;
                Projektt.Visible = false;
                Grupaa.Visible = false;
                Studentt.Visible = false;
                Prowadzacyy.Visible = false;
                Projektyy.Visible = false;
                Przedmiotyy.Visible = false;
                PrzedmiotyyKonkretny.Visible = false;
                ProjektyyKonkretny.Visible = false;
                //first = false;
            }
            
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            gvPrzedmiot.DataBind();
            //Response.Redirect("/WebForm1.aspx");
        }

        protected void Button_DodajProjekt_Click(object sender, EventArgs e)
        {
            PROJEKT nowy = new PROJEKT();
            nowy.id_PRZEDMIOTU = Convert.ToInt32(DropDownList_Projekt_idPrzedmiotu.SelectedValue);
            nowy.nazwa_projektu = TextBox_Projekt_nazwaProjektu.Text;
            nowy.opis_projektu = TextBox_Projekt_opisProjektu.Text;
            db.PROJEKT.Add(nowy);
            db.SaveChanges();
            gvProjekt.DataBind();
            //Response.Redirect("/WebForm1.aspx");
        }

        protected void Button_DodajStudent_Click(object sender, EventArgs e)
        {
            STUDENT nowy = new STUDENT();
            nowy.id_GRUPY = Convert.ToInt32(DropDownList_Student_idGrupy.SelectedValue);
            nowy.imie = TextBox_Student_imie.Text;
            nowy.nazwisko = TextBox_Student_nazwisko.Text;
            nowy.telefon = TextBox_Student_telefon.Text;
            nowy.adres = TextBox_Student_adres.Text;
            nowy.e_mail = TextBox_Student_email.Text;
            nowy.haslo = TextBox_Student_haslo.Text;
            db.STUDENT.Add(nowy);
            db.SaveChanges();
            gvStudent.DataBind();
            //Response.Redirect("/WebForm1.aspx");
        }

        protected void Button_DodajProjekty_Click(object sender, EventArgs e)
        {
            projekty nowy = new projekty();
            nowy.id_PROJEKTU = Convert.ToInt32(DropDownList_Projekty_idProjektu.SelectedValue);
            nowy.id_PROWADZĄCEGO = Convert.ToInt32(DropDownList_Projekty_idProwadzacego.SelectedValue);
            nowy.id_STUDENTA = Convert.ToInt32(DropDownList_Projekty_idStudenta.SelectedValue);
            if (TextBox_Projekty_ocena.Text != null && !String.IsNullOrWhiteSpace(TextBox_Projekty_ocena.Text)) nowy.ocena_projektu = Convert.ToInt32(TextBox_Projekty_ocena.Text);
            if (TextBox_Projekty_dataProjektu.Text != null && !String.IsNullOrWhiteSpace(TextBox_Projekty_dataProjektu.Text)) nowy.data_projektu = DateTime.Parse(TextBox_Projekty_dataProjektu.Text);
            if (TextBox_Projekty_uwagi.Text != null && !String.IsNullOrWhiteSpace(TextBox_Projekty_uwagi.Text)) nowy.uwagi_projektu = TextBox_Projekty_uwagi.Text;
            db.projekty.Add(nowy);
            db.SaveChanges();
            gvProjekty.DataBind();
            //Response.Redirect("/WebForm1.aspx");
        }

        protected void Button_DodajPrzedmioty_Click(object sender, EventArgs e)
        {
            przedmioty nowy = new przedmioty();
            nowy.id_PRZEDMIOTU = Convert.ToInt32(DropDownList_Przedmioty_idPrzedmiotu.SelectedValue);
            nowy.id_PROWADZĄCEGO = Convert.ToInt32(DropDownList_Przedmioty_idProwadzacego.SelectedValue);
            nowy.id_STUDENTA = Convert.ToInt32(DropDownList_Przedmioty_idStudenta.SelectedValue);
            nowy.ocena_przedmiotu = Convert.ToInt32(TextBox_Przedmioty_ocenaPrzedmiotu.Text);
            nowy.data_zaliczenia_przedmiotu = DateTime.Parse(TextBox_Przedmioty_dataZaliczenia.Text);
            nowy.uwagi_przedmiotu = TextBox_Przedmioty_uwagi.Text;
            db.przedmioty.Add(nowy);
            db.SaveChanges();
            gvPrzedmioty.DataBind();
            //Response.Redirect("/WebForm1.aspx");
        }

        protected void ZaladujStudent()
        {
            edsPrzedmioty.WhereParameters.Clear();
            edsProjekty.WhereParameters.Clear();
            Przedmiott.Visible = false;
            Projektt.Visible = true;
            Grupaa.Visible = false;
            Studentt.Visible = false;
            Prowadzacyy.Visible = false;
            Projektyy.Visible = true;
            Przedmiotyy.Visible = true;
            student = db.STUDENT.Where(p => p.e_mail.Contains(TextBoxEmail.Text)).FirstOrDefault();
            edsPrzedmioty.Where = "it.[id_STUDENTA] = @CategoryID";
            edsPrzedmioty.WhereParameters.Add("CategoryID", TypeCode.Int32, student.id_STUDENTA.ToString());
            //edsPrzedmioty.WhereParameters["SelectedValue"].DefaultValue = student.id_STUDENTA.ToString();
            ProjektyTable.Visible = false;
            PrzedmiotyTable.Visible = false;
            PrzedmiotyyKonkretny.Visible = false;
            ProjektyyKonkretny.Visible = false;

            Button_DodajProjekt.Visible = false;
            Button_Student_zapiszsiedoprojektu.Visible = true;
            DropDownList_Student_zapiszsiedoprojektu.Visible = true;
            ProjektTable.Visible = false;

            gvProjekt.Columns[0].Visible = false;
            gvProjekty.Columns[0].Visible = false;
            gvPrzedmioty.Columns[0].Visible = false;
        }
        protected void ZaladujProwadzacy()
        {

            Przedmiott.Visible = false;
            Projektt.Visible = true;
            Grupaa.Visible = false;
            Studentt.Visible = true;
            Prowadzacyy.Visible = false;
            Projektyy.Visible = false;
            ProjektyyKonkretny.Visible = true;
            PrzedmiotyyKonkretny.Visible = true;
            Przedmiotyy.Visible = false;

            ProjektyTable.Visible = true;
            PrzedmiotyTable.Visible = true;

            Button_DodajProjekt.Visible = true;
            Button_Student_zapiszsiedoprojektu.Visible = false;
            DropDownList_Student_zapiszsiedoprojektu.Visible = false;
            ProjektTable.Visible = true;


            /*

            edsPrzedmioty.WhereParameters.Clear();
            edsProjekty.WhereParameters.Clear();
            edsProjekty.Where = "";
            edsPrzedmioty.Where = "";

            PROWADZĄCY prowadzacy = db.PROWADZĄCY.Where(p => p.e_mail.Contains(TextBoxEmail.Text)).FirstOrDefault();
            edsPrzedmioty.Where = "it.[id_PROWADZĄCEGO] = @ID";
            edsPrzedmioty.WhereParameters.Add("ID", TypeCode.Int32, prowadzacy.id_PROWADZĄCEGO.ToString());
            edsProjekty.Where = "it.[id_PROWADZĄCEGO] = @ID";
            edsProjekty.WhereParameters.Add("ID", TypeCode.Int32, prowadzacy.id_PROWADZĄCEGO.ToString());
            */
            

            gvProjekt.Columns[0].Visible = true;
            gvProjekty.Columns[0].Visible = true;
            //gvPrzedmioty.Columns[0].Visible = true;

        }
        protected void ZaladujAdmin()
        {
            Przedmiott.Visible = true;
            Projektt.Visible = true;
            Grupaa.Visible = true;
            Studentt.Visible = true;
            Prowadzacyy.Visible = true;
            Projektyy.Visible = true;
            Przedmiotyy.Visible = true;
            PrzedmiotyyKonkretny.Visible = false;
            ProjektyyKonkretny.Visible = false;

            ProjektyTable.Visible = true;
            PrzedmiotyTable.Visible = true;
            Button_DodajProjekt.Visible = true;
            Button_Student_zapiszsiedoprojektu.Visible = false;
            DropDownList_Student_zapiszsiedoprojektu.Visible = false;
            ProjektTable.Visible = true;

            edsPrzedmioty.WhereParameters.Clear();
            edsProjekty.WhereParameters.Clear();

            gvProjekt.Columns[0].Visible = true;
            gvProjekty.Columns[0].Visible = true;
            gvPrzedmioty.Columns[0].Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM STUDENT WHERE [haslo] like @haslo and [e-mail] like @email", Connection);
                    cmd.Parameters.AddWithValue("@haslo", TextBoxHaslo.Text);
                    cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        ZaladujStudent();
                    }
                    else
                    {

                        SqlCommand cmdPr = new SqlCommand(@"SELECT Count(*) FROM PROWADZĄCY WHERE [haslo] like @haslo and [e-mail] like @email", Connection);
                        cmdPr.Parameters.AddWithValue("@haslo", TextBoxHaslo.Text);
                        cmdPr.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                        int resultPr = (int)cmdPr.ExecuteScalar();
                        if (resultPr > 0)
                        {
                            ZaladujProwadzacy();
                        }
                        else if (TextBoxHaslo.Text.Equals("admin") && TextBoxEmail.Text.Equals("admin"))
                        {
                            ZaladujAdmin();
                        }
                        else
                        {
                            string script = "alert(\"Błędny login lub hasło.\");";
                            ScriptManager.RegisterStartupScript(this, GetType(),
                                                  "ServerControlScript", script, true);
                        }
                    }

                }
                catch (Exception ex)
                {
                    string script = "alert(\"Unexpected error:\" +  ex.Message);";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Text = "ula@op.pl";
            TextBoxHaslo.Text = "bleble";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Text = "andrzej@op.pl";
            TextBoxHaslo.Text = "hasloo";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Text = "admin";
            TextBoxHaslo.Text = "admin";
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

        public PROJEKT ZnajdzProjekt(int id)
        {
            PROJEKT projekt = new PROJEKT();
            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM PROJEKT 
                                        WHERE [id_PROJEKTU] = @id", Connection);

                cmd.Parameters.AddWithValue("@id", id);

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

        public PROWADZĄCY ZnajdzProwadzacego(int id_przedmiotu)
        {
            PROWADZĄCY prowadzacy = new PROWADZĄCY();
            using (SqlConnection Connection = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true"))
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT PROWADZĄCY.id_PROWADZĄCEGO, PROWADZĄCY.imie, PROWADZĄCY.nazwisko, PROWADZĄCY.telefon, PROWADZĄCY.adres, PROWADZĄCY.[e-mail], PROWADZĄCY.haslo, PROWADZĄCY.stanowisko FROM PROWADZĄCY INNER JOIN przedmioty ON PROWADZĄCY.id_PROWADZĄCEGO=przedmioty.id_PROWADZĄCEGO INNER JOIN PRZEDMIOT ON przedmioty.id_PRZEDMIOTU=PRZEDMIOT.id_PRZEDMIOTU  
                                        WHERE PRZEDMIOT.[id_PRZEDMIOTU] = @id", Connection);

                cmd.Parameters.AddWithValue("@id", id_przedmiotu);

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

        
        protected void Button_Student_zapiszsiedoprojektu_Click(object sender, EventArgs e)
        {
            student = db.STUDENT.Where(p => p.e_mail.Contains(TextBoxEmail.Text)).FirstOrDefault();
            this.projekt = ZnajdzProjekt(Convert.ToInt32(DropDownList_Student_zapiszsiedoprojektu.SelectedValue));
            this.projekty = new projekty();
            this.prowadzacy = ZnajdzProwadzacego(Convert.ToInt32(projekt.id_PRZEDMIOTU));
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
                        string script = "alert(\"Ten projekt osiągnął maksymalną ilość przypisanych studentów (3)\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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
                                    string script = "alert(\"Jesteś już zapisany do tego projektu!\");";
                                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                }
                                else
                                {
                                    db.projekty.Add(projekty);
                                    db.SaveChanges();
                                    gvProjekty.DataBind();
                                }
                            }
                            catch (Exception ex)
                            {
                                string script = "alert(\"Unexpected error1: \" + ex.Message);";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string script = "alert(\"Unexpected error2:\"  + ex.Message);";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
        }

    }
}