namespace DziennikOcen
{
    partial class FormZarzadzajStudentem
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
            this.cbxGrupa = new System.Windows.Forms.ComboBox();
            this.bsGRUPA = new System.Windows.Forms.BindingSource(this.components);
            this.tbxImie = new System.Windows.Forms.TextBox();
            this.tbxNazwisko = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsGRUPA)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGrupa
            // 
            this.cbxGrupa.DataSource = this.bsGRUPA;
            this.cbxGrupa.DisplayMember = "nazwa_grupy";
            this.cbxGrupa.FormattingEnabled = true;
            this.cbxGrupa.Location = new System.Drawing.Point(139, 58);
            this.cbxGrupa.Name = "cbxGrupa";
            this.cbxGrupa.Size = new System.Drawing.Size(121, 21);
            this.cbxGrupa.TabIndex = 0;
            // 
            // bsGRUPA
            // 
            this.bsGRUPA.DataSource = typeof(DziennikOcen.GRUPA);
            // 
            // tbxImie
            // 
            this.tbxImie.Location = new System.Drawing.Point(139, 86);
            this.tbxImie.Name = "tbxImie";
            this.tbxImie.Size = new System.Drawing.Size(100, 20);
            this.tbxImie.TabIndex = 1;
            // 
            // tbxNazwisko
            // 
            this.tbxNazwisko.Location = new System.Drawing.Point(139, 112);
            this.tbxNazwisko.Name = "tbxNazwisko";
            this.tbxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.tbxNazwisko.TabIndex = 2;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(139, 138);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefon.TabIndex = 3;
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(139, 164);
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(100, 20);
            this.tbxAdres.TabIndex = 4;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(139, 190);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 5;
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Location = new System.Drawing.Point(32, 58);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(39, 13);
            this.lblGrupa.TabIndex = 6;
            this.lblGrupa.Text = "Grupa:";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(32, 86);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(29, 13);
            this.lblImie.TabIndex = 7;
            this.lblImie.Text = "Imię:";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Location = new System.Drawing.Point(32, 112);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(56, 13);
            this.lblNazwisko.TabIndex = 8;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(32, 164);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 10;
            this.lblAdres.Text = "Adres:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(32, 138);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon:";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(35, 236);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Location = new System.Drawing.Point(139, 236);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 13;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // FormZarzadzajStudentem
            // 
            this.AcceptButton = this.btnZapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.CancelButton = this.btnAnuluj;
            this.ClientSize = new System.Drawing.Size(318, 305);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxAdres);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxNazwisko);
            this.Controls.Add(this.tbxImie);
            this.Controls.Add(this.cbxGrupa);
            this.Name = "FormZarzadzajStudentem";
            this.Text = "FormZarzadzajStudentem";
            this.Load += new System.EventHandler(this.FormZarzadzajStudentem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsGRUPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGrupa;
        private System.Windows.Forms.TextBox tbxImie;
        private System.Windows.Forms.TextBox tbxNazwisko;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblGrupa;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.BindingSource bsGRUPA;
    }
}