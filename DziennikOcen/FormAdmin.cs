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
    public partial class FormAdmin : Form
    {
        DziennikOcenEntities db = new DziennikOcenEntities();
        int formHeight;
        int formWidth;
        int zapis;

        //SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter daGrupa = new SqlDataAdapter();
        SqlDataAdapter daPrzedmiot = new SqlDataAdapter();
        SqlDataAdapter daProjekt = new SqlDataAdapter();
        SqlDataAdapter daStudent = new SqlDataAdapter();
        SqlDataAdapter daProwadzacy = new SqlDataAdapter();
        SqlDataAdapter daProjekty = new SqlDataAdapter();
        SqlDataAdapter daPrzedmioty = new SqlDataAdapter();
        SqlCommandBuilder commandBuilder;
        DataSet dataset = new DataSet();


        public FormAdmin()
        {
            InitializeComponent();
            formHeight = this.Height - 30;
            formWidth = this.Width;

            dgvGrupa.Height = formHeight / 3;
            dgvGrupa.Width = formWidth / 4;
            dgvGrupa.Left = 3;
            dgvGrupa.Top = 30;

            dgvPrzedmiot.Height = formHeight / 3;
            dgvPrzedmiot.Width = formWidth / 4;
            dgvPrzedmiot.Left = formWidth / 4 + 6;
            dgvPrzedmiot.Top = 30;

            dgvProjekt.Height = formHeight / 3;
            dgvProjekt.Width = formWidth / 2 - 27;
            dgvProjekt.Left = formWidth / 2 + 7;
            dgvProjekt.Top = 30;

            dgvStudent.Height = formHeight / 3 - 26;
            dgvStudent.Width = formWidth / 2;
            dgvStudent.Left = 3;
            dgvStudent.Top = formHeight / 3 + 33;

            dgvProwadzacy.Height = formHeight / 3 - 26;
            dgvProwadzacy.Width = formWidth / 2 - 24;
            dgvProwadzacy.Left = formWidth / 2 + 6;
            dgvProwadzacy.Top = formHeight / 3 + 33;

            dgvProjekty.Height = formHeight / 3 - 20;
            dgvProjekty.Width = formWidth / 2;
            dgvProjekty.Left = 3;
            dgvProjekty.Top = (2 * formHeight / 3) + 10 ;

            dgvPrzedmioty.Height = formHeight / 3 - 21;
            dgvPrzedmioty.Width = formWidth / 2 - 24;
            dgvPrzedmioty.Left = formWidth / 2 + 6;
            dgvPrzedmioty.Top = (2 * formHeight / 3) + 10;

            GetDataGrupa("SELECT * FROM GRUPA", dgvGrupa, bsGrupa);
            GetDataPrzedmiot("SELECT * FROM PRZEDMIOT", dgvPrzedmiot, bsPrzedmiot);
            GetDataProjekt("SELECT * FROM PROJEKT", dgvProjekt, bsProjekt);
            GetDataStudent("SELECT * FROM STUDENT", dgvStudent, bsStudent);
            GetDataProwadzacy("SELECT * FROM PROWADZĄCY", dgvProwadzacy, bsProwadzacy);
            GetDataProjekty("SELECT * FROM projekty", dgvProjekty, bsProjekty);
            GetDataPrzedmioty("SELECT * FROM przedmioty", dgvPrzedmioty, bsPrzedmioty);


        }

        private void FormAdmin_Resize(object sender, EventArgs e)
        {
            formHeight = this.Height - 30;
            formWidth = this.Width;

            dgvGrupa.Height = formHeight / 3;
            dgvGrupa.Width = formWidth / 4;
            dgvGrupa.Left = 3;
            dgvGrupa.Top = 30;

            dgvPrzedmiot.Height = formHeight / 3;
            dgvPrzedmiot.Width = formWidth / 4;
            dgvPrzedmiot.Left = formWidth / 4 + 6;
            dgvPrzedmiot.Top = 30;

            dgvProjekt.Height = formHeight / 3;
            dgvProjekt.Width = formWidth / 2 - 27;
            dgvProjekt.Left = formWidth / 2 + 7;
            dgvProjekt.Top = 30;

            dgvStudent.Height = formHeight / 3 - 26;
            dgvStudent.Width = formWidth / 2;
            dgvStudent.Left = 3;
            dgvStudent.Top = formHeight / 3 + 33;

            dgvProwadzacy.Height = formHeight / 3 - 26;
            dgvProwadzacy.Width = formWidth / 2 - 24;
            dgvProwadzacy.Left = formWidth / 2 + 6;
            dgvProwadzacy.Top = formHeight / 3 + 33;

            dgvProjekty.Height = formHeight / 3 - 20;
            dgvProjekty.Width = formWidth / 2;
            dgvProjekty.Left = 3;
            dgvProjekty.Top = (2 * formHeight / 3) + 10;

            dgvPrzedmioty.Height = formHeight / 3 - 21;
            dgvPrzedmioty.Width = formWidth / 2 - 24;
            dgvPrzedmioty.Left = formWidth / 2 + 6;
            dgvPrzedmioty.Top = (2 * formHeight / 3) + 10;
        }

        void GetDataGrupa(string selectCommand, DataGridView dgv, BindingSource bs)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true");

            daGrupa = new SqlDataAdapter(selectCommand, conn);
            commandBuilder = new SqlCommandBuilder(daGrupa);
            commandBuilder.GetInsertCommand();

            DataTable table = new DataTable();
            daGrupa.Fill(table);

            bs.DataSource = table;
            dgv.DataSource = bs;

            /*
            for (int i = 0; i < dgv.Rows.Count; i++)
            { 
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dgv[3, i] = linkCell;
            }
            */

        }
        void GetDataPrzedmiot(string selectCommand, DataGridView dgv, BindingSource bs)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true");

            daPrzedmiot = new SqlDataAdapter(selectCommand, conn);
            commandBuilder = new SqlCommandBuilder(daPrzedmiot);
            commandBuilder.GetInsertCommand();

            DataTable table = new DataTable();
            daPrzedmiot.Fill(table);

            bs.DataSource = table;
            dgv.DataSource = bs;

        }
        void GetDataProjekt(string selectCommand, DataGridView dgv, BindingSource bs)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true");

            daProjekt = new SqlDataAdapter(selectCommand, conn);
            commandBuilder = new SqlCommandBuilder(daProjekt);
            commandBuilder.GetInsertCommand();

            DataTable table = new DataTable();
            daProjekt.Fill(table);

            bs.DataSource = table;
            dgv.DataSource = bs;

        }
        void GetDataStudent(string selectCommand, DataGridView dgv, BindingSource bs)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true");

            daStudent = new SqlDataAdapter(selectCommand, conn);
            commandBuilder = new SqlCommandBuilder(daStudent);
            commandBuilder.GetInsertCommand();

            DataTable table = new DataTable();
            daStudent.Fill(table);

            bs.DataSource = table;
            dgv.DataSource = bs;

        }
        void GetDataProwadzacy(string selectCommand, DataGridView dgv, BindingSource bs)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true");

            daProwadzacy = new SqlDataAdapter(selectCommand, conn);
            commandBuilder = new SqlCommandBuilder(daProwadzacy);
            commandBuilder.GetInsertCommand();

            DataTable table = new DataTable();
            daProwadzacy.Fill(table);

            bs.DataSource = table;
            dgv.DataSource = bs;
        }
        void GetDataProjekty(string selectCommand, DataGridView dgv, BindingSource bs)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true");

            daProjekty = new SqlDataAdapter(selectCommand, conn);
            commandBuilder = new SqlCommandBuilder(daProjekty);
            commandBuilder.GetInsertCommand();

            DataTable table = new DataTable();
            daProjekty.Fill(table);

            bs.DataSource = table;
            dgv.DataSource = bs;
        }
        void GetDataPrzedmioty(string selectCommand, DataGridView dgv, BindingSource bs)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-HT2SRPL;Database=DziennikOcen;Trusted_Connection=true");

            daPrzedmioty = new SqlDataAdapter(selectCommand, conn);
            commandBuilder = new SqlCommandBuilder(daPrzedmioty);
            commandBuilder.GetInsertCommand();

            DataTable table = new DataTable();
            daPrzedmioty.Fill(table);

            bs.DataSource = table;
            dgv.DataSource = bs;
        }

        private void dgvStudent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int lastRow = dgvStudent.Rows.Count - 2;
            if (e.RowIndex != lastRow)
            {
                bsStudent.EndEdit();
                DataTable dt = (DataTable)bsStudent.DataSource;
                DataTable changedTable = dt.GetChanges();
                int rowsUpdated = daStudent.Update(dt);
                db.SaveChanges();
            }
        }
        private void dgvGrupa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int lastRow = dgvGrupa.Rows.Count - 2;
            if (e.RowIndex != lastRow)
            {
                bsGrupa.EndEdit();
                DataTable dt = (DataTable)bsGrupa.DataSource;
                DataTable changedTable = dt.GetChanges();
                int rowsUpdated = daGrupa.Update(dt);
            }
        }
        private void dgvPrzedmiot_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int lastRow = dgvPrzedmiot.Rows.Count - 2;
            if (e.RowIndex != lastRow)
            {
                bsPrzedmiot.EndEdit();
                DataTable dt = (DataTable)bsPrzedmiot.DataSource;
                DataTable changedTable = dt.GetChanges();
                int rowsUpdated = daPrzedmiot.Update(dt);
            }
        }
        private void dgvProjekt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int lastRow = dgvProjekt.Rows.Count - 2;
            if (e.RowIndex != lastRow)
            {
                bsProjekt.EndEdit();
                DataTable dt = (DataTable)bsProjekt.DataSource;
                DataTable changedTable = dt.GetChanges();
                int rowsUpdated = daProjekt.Update(dt);
            }
        }
        private void dgvProwadzacy_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int lastRow = dgvProwadzacy.Rows.Count - 2;
            if (e.RowIndex != lastRow)
            {
                bsProwadzacy.EndEdit();
                DataTable dt = (DataTable)bsProwadzacy.DataSource;
                DataTable changedTable = dt.GetChanges();
                int rowsUpdated = daProwadzacy.Update(dt);
            }
        }
        private void dgvProjekty_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int lastRow = dgvProjekty.Rows.Count - 2;
            if (e.RowIndex != lastRow)
            {
                bsProjekty.EndEdit();
                DataTable dt = (DataTable)bsProjekty.DataSource;
                DataTable changedTable = dt.GetChanges();
                int rowsUpdated = daProjekty.Update(dt);
            }
        }
        private void dgvPrzedmioty_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int lastRow = dgvPrzedmioty.Rows.Count - 2;
            if (e.RowIndex != lastRow)
            {
                bsPrzedmioty.EndEdit();
                DataTable dt = (DataTable)bsPrzedmioty.DataSource;
                DataTable changedTable = dt.GetChanges();
                int rowsUpdated = daPrzedmioty.Update(dt);
            }
        }

        private void btnDodajStudent_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int row = dgvStudent.Rows.Count - 2;
            student.id_GRUPY = Int32.Parse(dgvStudent.Rows[row].Cells[1].Value.ToString());
            student.imie = dgvStudent.Rows[row].Cells[2].Value.ToString();
            student.nazwisko = dgvStudent.Rows[row].Cells[3].Value.ToString();
            student.telefon = dgvStudent.Rows[row].Cells[4].Value.ToString();
            student.adres = dgvStudent.Rows[row].Cells[5].Value.ToString();
            student.e_mail = dgvStudent.Rows[row].Cells[6].Value.ToString();
            student.haslo = dgvStudent.Rows[row].Cells[7].Value.ToString();
            db.STUDENT.Add(student);
            db.SaveChanges();
            GetDataStudent("SELECT * FROM STUDENT", dgvStudent, bsStudent);
        }

        private void btnDodajGrupa_Click(object sender, EventArgs e)
        {
            GRUPA grupa = new GRUPA();
            int row = dgvGrupa.Rows.Count - 2;
            grupa.nazwa_grupy = dgvGrupa.Rows[row].Cells[1].Value.ToString();
            db.GRUPA.Add(grupa);
            db.SaveChanges();
            GetDataGrupa("SELECT * FROM GRUPA", dgvGrupa, bsGrupa);
        }

        private void btnDodajPrzedmiot_Click(object sender, EventArgs e)
        {
            PRZEDMIOT przedmiot = new PRZEDMIOT();
            int row = dgvPrzedmiot.Rows.Count - 2;
            przedmiot.nazwa_przedmiotu = dgvPrzedmiot.Rows[row].Cells[1].Value.ToString();
            przedmiot.opis_przedmiotu = dgvPrzedmiot.Rows[row].Cells[2].Value.ToString();
            przedmiot.ECTS = Int32.Parse(dgvPrzedmiot.Rows[row].Cells[3].Value.ToString());
            db.PRZEDMIOT.Add(przedmiot);
            db.SaveChanges();
            GetDataPrzedmiot("SELECT * FROM PRZEDMIOT", dgvPrzedmiot, bsPrzedmiot);
        }

        private void btnDodajProjekt_Click(object sender, EventArgs e)
        {
            PROJEKT projekt = new PROJEKT();
            int row = dgvProjekt.Rows.Count - 2;
            projekt.id_PRZEDMIOTU = Int32.Parse(dgvProjekt.Rows[row].Cells[1].Value.ToString());
            projekt.nazwa_projektu = dgvProjekt.Rows[row].Cells[2].Value.ToString();
            projekt.opis_projektu = dgvProjekt.Rows[row].Cells[3].Value.ToString();
            db.PROJEKT.Add(projekt);
            db.SaveChanges();
            GetDataProjekt("SELECT * FROM PROJEKT", dgvProjekt, bsProjekt);
        }

        private void btnDodajProwadzacy_Click(object sender, EventArgs e)
        {
            PROWADZĄCY prowadzacy = new PROWADZĄCY();
            int row = dgvProwadzacy.Rows.Count - 2;
            prowadzacy.imie = dgvProwadzacy.Rows[row].Cells[1].Value.ToString();
            prowadzacy.nazwisko = dgvProwadzacy.Rows[row].Cells[2].Value.ToString();
            prowadzacy.telefon = dgvProwadzacy.Rows[row].Cells[3].Value.ToString();
            prowadzacy.adres = dgvProwadzacy.Rows[row].Cells[4].Value.ToString();
            prowadzacy.e_mail = dgvProwadzacy.Rows[row].Cells[5].Value.ToString();
            prowadzacy.haslo = dgvProwadzacy.Rows[row].Cells[6].Value.ToString();
            prowadzacy.stanowisko = dgvProwadzacy.Rows[row].Cells[7].Value.ToString();
            db.PROWADZĄCY.Add(prowadzacy);
            db.SaveChanges();
            GetDataProwadzacy("SELECT * FROM PROWADZĄCY", dgvProwadzacy, bsProwadzacy);
        }

        private void btnDodajProjekty_Click(object sender, EventArgs e)
        {
            projekty projekty = new projekty();
            int row = dgvProjekty.Rows.Count - 2;
            if (dgvProjekty.Rows[row].Cells[0].Value != null)
            {
                projekty.id_STUDENTA = Int32.Parse(dgvProjekty.Rows[row].Cells[0].Value.ToString());
                zapis = 1;
            }
            else
            {
                MessageBox.Show("id studenta jest wymagane!");
                zapis = 0;
            }
            if (zapis == 1 && dgvProjekty.Rows[row].Cells[1].Value != null && dgvProjekty.Rows[row].Cells[1].Value != DBNull.Value && !String.IsNullOrWhiteSpace(dgvProjekty.Rows[row].Cells[1].Value.ToString()))
            {
                projekty.id_PROJEKTU = Int32.Parse(dgvProjekty.Rows[row].Cells[1].Value.ToString());
                zapis = 1;

            }
            else
            {
                MessageBox.Show("id projektu jest wymagane!");
                zapis = 0;
            }
            if (zapis == 1 && dgvProjekty.Rows[row].Cells[2].Value != null && dgvProjekty.Rows[row].Cells[2].Value != DBNull.Value && !String.IsNullOrWhiteSpace(dgvProjekty.Rows[row].Cells[2].Value.ToString()))
            {
                projekty.id_PROWADZĄCEGO = Int32.Parse(dgvProjekty.Rows[row].Cells[2].Value.ToString());
                zapis = 1;
            }
            else
            {
                MessageBox.Show("id prowadzącego jest wymagane!");
                zapis = 0;
            }
            if (zapis == 1 && dgvProjekty.Rows[row].Cells[3].Value != null && dgvProjekty.Rows[row].Cells[3].Value != DBNull.Value && !String.IsNullOrWhiteSpace(dgvProjekty.Rows[row].Cells[3].Value.ToString()))
            {
                projekty.ocena_projektu = Int32.Parse(dgvProjekty.Rows[row].Cells[3].Value.ToString());
                zapis = 1;
            }        
            if (zapis == 1 && dgvProjekty.Rows[row].Cells[4].Value != null && dgvProjekty.Rows[row].Cells[4].Value != DBNull.Value && !String.IsNullOrWhiteSpace(dgvProjekty.Rows[row].Cells[4].Value.ToString()))
            {
                projekty.data_projektu = DateTime.Parse(dgvProjekty.Rows[row].Cells[4].Value.ToString());
                zapis = 1;
            }   
            if (zapis == 1 && dgvProjekty.Rows[row].Cells[5].Value != null && dgvProjekty.Rows[row].Cells[5].Value != DBNull.Value && !String.IsNullOrWhiteSpace(dgvProjekty.Rows[row].Cells[5].Value.ToString()))
            {
                projekty.uwagi_projektu = dgvProjekty.Rows[row].Cells[5].Value.ToString();
                zapis = 1;
            }
            if (zapis == 1)
            {
                db.projekty.Add(projekty);
                db.SaveChanges();
                GetDataProjekty("SELECT * FROM projekty", dgvProjekty, bsProjekty);
            }
            
        }

        private void btnDodajPrzedmioty_Click(object sender, EventArgs e)
        {
            przedmioty przedmioty = new przedmioty();
            int row = dgvPrzedmioty.Rows.Count - 2;
            if (dgvPrzedmioty.Rows[row].Cells[0].Value != null) przedmioty.id_STUDENTA = Int32.Parse(dgvPrzedmioty.Rows[row].Cells[0].Value.ToString());
            if (dgvPrzedmioty.Rows[row].Cells[1].Value != null) przedmioty.id_PROWADZĄCEGO = Int32.Parse(dgvPrzedmioty.Rows[row].Cells[1].Value.ToString());
            if (dgvPrzedmioty.Rows[row].Cells[2].Value != null) przedmioty.id_PRZEDMIOTU = Int32.Parse(dgvPrzedmioty.Rows[row].Cells[2].Value.ToString());
            if (dgvPrzedmioty.Rows[row].Cells[3].Value != null) przedmioty.ocena_przedmiotu = Int32.Parse(dgvPrzedmioty.Rows[row].Cells[3].Value.ToString());
            if (dgvPrzedmioty.Rows[row].Cells[4].Value != null) przedmioty.data_zaliczenia_przedmiotu = DateTime.Parse(dgvPrzedmioty.Rows[row].Cells[4].Value.ToString());
            if (dgvPrzedmioty.Rows[row].Cells[5].Value != null) przedmioty.uwagi_przedmiotu = dgvPrzedmioty.Rows[row].Cells[5].Value.ToString();
            db.przedmioty.Add(przedmioty);
            db.SaveChanges();
            GetDataPrzedmioty("SELECT * FROM przedmioty", dgvPrzedmioty, bsPrzedmioty);
        }


        private void dgvGrupa_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = dgvGrupa.SelectedRows[0].Index;
            int id = Int32.Parse(dgvGrupa.Rows[index].Cells[0].Value.ToString());
            GRUPA grupa = new GRUPA();
            grupa = db.GRUPA.Where(p => p.id_GRUPY == id).FirstOrDefault();
            db.GRUPA.Attach(grupa);
            var entry = db.Entry(grupa);
            db.GRUPA.Remove(grupa);
            db.SaveChanges();
        }

        private void dgvPrzedmiot_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = dgvPrzedmiot.SelectedRows[0].Index;
            int id = Int32.Parse(dgvPrzedmiot.Rows[index].Cells[0].Value.ToString());
            PRZEDMIOT przedmiot = new PRZEDMIOT();
            przedmiot = db.PRZEDMIOT.Where(p => p.id_PRZEDMIOTU == id).FirstOrDefault();
            db.PRZEDMIOT.Attach(przedmiot);
            var entry = db.Entry(przedmiot);
            db.PRZEDMIOT.Remove(przedmiot);
            db.SaveChanges();
        }

        private void dgvProjekt_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = dgvProjekt.SelectedRows[0].Index;
            int id = Int32.Parse(dgvProjekt.Rows[index].Cells[0].Value.ToString());
            PROJEKT projekt = new PROJEKT();
            projekt = db.PROJEKT.Where(p => p.id_PROJEKTU == id).FirstOrDefault();
            db.PROJEKT.Attach(projekt);
            var entry = db.Entry(projekt);
            db.PROJEKT.Remove(projekt);
            db.SaveChanges();
        }

        private void dgvStudent_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = dgvStudent.SelectedRows[0].Index;
            int id = Int32.Parse(dgvStudent.Rows[index].Cells[0].Value.ToString());
            STUDENT student = new STUDENT();
            student = db.STUDENT.Where(p => p.id_STUDENTA == id).FirstOrDefault();
            db.STUDENT.Attach(student);
            var entry = db.Entry(student);
            db.STUDENT.Remove(student);
            db.SaveChanges();
        }

        private void dgvProwadzacy_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = dgvProwadzacy.SelectedRows[0].Index;
            int id = Int32.Parse(dgvProwadzacy.Rows[index].Cells[0].Value.ToString());
            PROWADZĄCY prowadzacy = new PROWADZĄCY();
            prowadzacy = db.PROWADZĄCY.Where(p => p.id_PROWADZĄCEGO == id).FirstOrDefault();
            db.PROWADZĄCY.Attach(prowadzacy);
            var entry = db.Entry(prowadzacy);
            db.PROWADZĄCY.Remove(prowadzacy);
            db.SaveChanges();
        }

        private void dgvProjekty_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = dgvProjekty.SelectedRows[0].Index;
            int id = Int32.Parse(dgvProjekty.Rows[index].Cells[0].Value.ToString());
            int id2 = Int32.Parse(dgvProjekty.Rows[index].Cells[1].Value.ToString());
            projekty projekty = new projekty();
            projekty = db.projekty.Where(p => p.id_STUDENTA == id && p.id_PROJEKTU == id2).FirstOrDefault();
            db.projekty.Attach(projekty);
            var entry = db.Entry(projekty);
            db.projekty.Remove(projekty);
            db.SaveChanges();
        }

        private void dgvPrzedmioty_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = dgvPrzedmioty.SelectedRows[0].Index;
            int id = Int32.Parse(dgvPrzedmioty.Rows[index].Cells[0].Value.ToString());
            int id2 = Int32.Parse(dgvPrzedmioty.Rows[index].Cells[2].Value.ToString());
            przedmioty przedmioty = new przedmioty();
            przedmioty = db.przedmioty.Where(p => p.id_STUDENTA == id && p.id_PRZEDMIOTU == id2).FirstOrDefault();
            db.przedmioty.Attach(przedmioty);
            var entry = db.Entry(przedmioty);
            db.przedmioty.Remove(przedmioty);
            db.SaveChanges();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
