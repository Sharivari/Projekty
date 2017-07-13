using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DziennikOcen
{
    public partial class FormZarzadzajStudentem : Form
    {
        private STUDENT student;

        public STUDENT Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }

        public FormZarzadzajStudentem(STUDENT student, IList<GRUPA> GRUPA)
        {
            InitializeComponent();
            bsGRUPA.DataSource = GRUPA;
            this.Student = student;

            if (student == null)
            {
                //to tworzenie nowego
                this.Student = new STUDENT();
            }
            else
            {
                //edycja

                tbxImie.Text = student.imie;
                tbxNazwisko.Text = student.nazwisko;
                tbxTelefon.Text = student.telefon;
                tbxAdres.Text = student.adres;
                tbxEmail.Text = student.e_mail;
            }

        }

        private void FormZarzadzajStudentem_Load(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Student.GRUPA = bsGRUPA.Current as GRUPA;
            Student.imie = tbxImie.Text;
            Student.nazwisko = tbxNazwisko.Text;
            Student.telefon = tbxTelefon.Text;
            Student.adres = tbxAdres.Text;
            Student.e_mail = tbxEmail.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
