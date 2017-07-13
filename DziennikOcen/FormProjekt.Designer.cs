namespace DziennikOcen
{
    partial class FormProjekt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbxNazwaProjektu = new System.Windows.Forms.TextBox();
            this.tbxOpisProjektu = new System.Windows.Forms.TextBox();
            this.lblnazwaprojektu = new System.Windows.Forms.Label();
            this.lblopisprojektu = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPrzedmiot = new System.Windows.Forms.Label();
            this.bsPrzedmioty = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsPrzedmioty)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNazwaProjektu
            // 
            this.tbxNazwaProjektu.Location = new System.Drawing.Point(169, 65);
            this.tbxNazwaProjektu.Name = "tbxNazwaProjektu";
            this.tbxNazwaProjektu.Size = new System.Drawing.Size(452, 20);
            this.tbxNazwaProjektu.TabIndex = 0;
            // 
            // tbxOpisProjektu
            // 
            this.tbxOpisProjektu.Location = new System.Drawing.Point(169, 105);
            this.tbxOpisProjektu.Name = "tbxOpisProjektu";
            this.tbxOpisProjektu.Size = new System.Drawing.Size(452, 20);
            this.tbxOpisProjektu.TabIndex = 1;
            // 
            // lblnazwaprojektu
            // 
            this.lblnazwaprojektu.AutoSize = true;
            this.lblnazwaprojektu.Location = new System.Drawing.Point(31, 65);
            this.lblnazwaprojektu.Name = "lblnazwaprojektu";
            this.lblnazwaprojektu.Size = new System.Drawing.Size(84, 13);
            this.lblnazwaprojektu.TabIndex = 2;
            this.lblnazwaprojektu.Text = "Nazwa projektu:";
            // 
            // lblopisprojektu
            // 
            this.lblopisprojektu.AutoSize = true;
            this.lblopisprojektu.Location = new System.Drawing.Point(31, 105);
            this.lblopisprojektu.Name = "lblopisprojektu";
            this.lblopisprojektu.Size = new System.Drawing.Size(72, 13);
            this.lblopisprojektu.TabIndex = 3;
            this.lblopisprojektu.Text = "Opis projektu:";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(234, 146);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 4;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Location = new System.Drawing.Point(357, 146);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 5;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bsPrzedmioty;
            this.comboBox1.DisplayMember = "nazwa_przedmiotu";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(452, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lblPrzedmiot
            // 
            this.lblPrzedmiot.AutoSize = true;
            this.lblPrzedmiot.Location = new System.Drawing.Point(31, 23);
            this.lblPrzedmiot.Name = "lblPrzedmiot";
            this.lblPrzedmiot.Size = new System.Drawing.Size(56, 13);
            this.lblPrzedmiot.TabIndex = 7;
            this.lblPrzedmiot.Text = "Przedmiot:";
            // 
            // bsPrzedmioty
            // 
            this.bsPrzedmioty.DataSource = typeof(DziennikOcen.PRZEDMIOT);
            // 
            // FormProjekt
            // 
            this.AcceptButton = this.btnZapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.CancelButton = this.btnAnuluj;
            this.ClientSize = new System.Drawing.Size(689, 200);
            this.Controls.Add(this.lblPrzedmiot);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.lblopisprojektu);
            this.Controls.Add(this.lblnazwaprojektu);
            this.Controls.Add(this.tbxOpisProjektu);
            this.Controls.Add(this.tbxNazwaProjektu);
            this.Name = "FormProjekt";
            this.Text = "FormProjekt";
            ((System.ComponentModel.ISupportInitialize)(this.bsPrzedmioty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNazwaProjektu;
        private System.Windows.Forms.TextBox tbxOpisProjektu;
        private System.Windows.Forms.Label lblnazwaprojektu;
        private System.Windows.Forms.Label lblopisprojektu;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bsPrzedmioty;
        private System.Windows.Forms.Label lblPrzedmiot;
    }
}