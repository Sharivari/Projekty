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
    public partial class FormProjekt : Form
    {
        private PROJEKT projekt;
        DziennikOcenEntities db = new DziennikOcenEntities();
        PRZEDMIOT WybranyPrzedmiot;

        public FormProjekt(PROJEKT projekt, IList<PRZEDMIOT> przedmiot, int id)
        {
            InitializeComponent();
            bsPrzedmioty.DataSource = przedmiot;
            this.Projekt = projekt;

            if (projekt == null)
            {
                //to tworzenie nowego
                this.Projekt = new PROJEKT();
            }
            else
            {
                //edycja
                comboBox1.SelectedItem = projekt.PRZEDMIOT.id_PRZEDMIOTU;
                if (!DBNull.Value.Equals(projekt.nazwa_projektu)) tbxNazwaProjektu.Text = projekt.nazwa_projektu.ToString();
                else tbxNazwaProjektu.Text = String.Empty;
                if (!DBNull.Value.Equals(projekt.opis_projektu)) tbxOpisProjektu.Text = projekt.opis_projektu.ToString();
                else tbxOpisProjektu.Text = String.Empty;
            }
        }

        public PROJEKT Projekt
        {
            get
            {
                return projekt;
            }

            set
            {
                projekt = value;
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            //WybranyPrzedmiot = db.PRZEDMIOT.Where(p => p.nazwa_przedmiotu.Contains(comboBox1.Text)).FirstOrDefault();
            Projekt.PRZEDMIOT = bsPrzedmioty.Current as PRZEDMIOT;
            if (!string.IsNullOrWhiteSpace(tbxNazwaProjektu.Text)) Projekt.nazwa_projektu = tbxNazwaProjektu.Text;
            if (!string.IsNullOrWhiteSpace(tbxOpisProjektu.Text)) Projekt.opis_projektu = tbxOpisProjektu.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
