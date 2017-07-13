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
    public partial class FormZarzadzajProjektem : Form
    {
        private projekty projekt;
        DziennikOcenEntities db = new DziennikOcenEntities();
        public projekty Projekt
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


        public FormZarzadzajProjektem(projekty projekt)
        {
            InitializeComponent();
            this.Projekt = projekt;

            if (projekt == null)
            {
                //to tworzenie nowego
                this.Projekt = new projekty();
            }
            else
            {
                //edycja

                if (!DBNull.Value.Equals(projekt.ocena_projektu)) tbxOcena.Text = projekt.ocena_projektu.ToString();
                else tbxOcena.Text = String.Empty;
                if (!DBNull.Value.Equals(projekt.data_projektu)) tbxData.Text = projekt.data_projektu.ToString();
                else tbxData.Text = String.Empty;
                if (!DBNull.Value.Equals(projekt.uwagi_projektu)) tbxUwagi.Text = projekt.uwagi_projektu.ToString();
                else tbxUwagi.Text = String.Empty;
                //if (!string.IsNullOrWhiteSpace(projekt.ocena_projektu.ToString())) tbxOcena.Text = projekt.ocena_projektu.ToString();
                //if (!string.IsNullOrWhiteSpace(projekt.data_projektu.ToString())) tbxData.Text = projekt.data_projektu.ToString();
                //if (!string.IsNullOrWhiteSpace(projekt.uwagi_projektu.ToString())) tbxUwagi.Text = projekt.uwagi_projektu.ToString();

                
            }



        }



        private void btnZapisz_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(tbxOcena.Text, out parsedValue))
            {
                MessageBox.Show("Ocena musi być liczbą!");
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(tbxOcena.Text)) Projekt.ocena_projektu = Int32.Parse(tbxOcena.Text);
                if (!string.IsNullOrWhiteSpace(tbxData.Text)) Projekt.data_projektu = DateTime.Parse(tbxData.Text);
                if (!string.IsNullOrWhiteSpace(tbxUwagi.Text)) Projekt.uwagi_projektu = tbxUwagi.Text;
                this.DialogResult = DialogResult.OK;

            }
            
        }
    }
}
