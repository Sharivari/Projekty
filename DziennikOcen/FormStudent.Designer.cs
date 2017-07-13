namespace DziennikOcen
{
    partial class FormStudent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przedmiotyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPrzedmioty = new System.Windows.Forms.DataGridView();
            this.nazwa_przedmiotu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie_prowadzacego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko_prowadzacego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocena_przedmiotu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dgvProjekty = new System.Windows.Forms.DataGridView();
            this.dgvMojeProjekty = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.idGRUPYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStudent = new System.Windows.Forms.BindingSource(this.components);
            this.datazaliczeniaprzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagiprzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPrzedmioty = new System.Windows.Forms.BindingSource(this.components);
            this.bsPrzedmiot = new System.Windows.Forms.BindingSource(this.components);
            this.bsProjekty = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzedmioty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeProjekty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrzedmioty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrzedmiot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjekty)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.przedmiotyToolStripMenuItem,
            this.projektyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // przedmiotyToolStripMenuItem
            // 
            this.przedmiotyToolStripMenuItem.Name = "przedmiotyToolStripMenuItem";
            this.przedmiotyToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.przedmiotyToolStripMenuItem.Text = "Przedmioty";
            this.przedmiotyToolStripMenuItem.Click += new System.EventHandler(this.przedmiotyToolStripMenuItem_Click);
            // 
            // projektyToolStripMenuItem
            // 
            this.projektyToolStripMenuItem.Name = "projektyToolStripMenuItem";
            this.projektyToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.projektyToolStripMenuItem.Text = "Projekty";
            this.projektyToolStripMenuItem.Click += new System.EventHandler(this.projektyToolStripMenuItem_Click);
            // 
            // dgvPrzedmioty
            // 
            this.dgvPrzedmioty.AllowUserToAddRows = false;
            this.dgvPrzedmioty.AllowUserToDeleteRows = false;
            this.dgvPrzedmioty.AutoGenerateColumns = false;
            this.dgvPrzedmioty.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPrzedmioty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrzedmioty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwa_przedmiotu,
            this.imie_prowadzacego,
            this.nazwisko_prowadzacego,
            this.ocena_przedmiotu,
            this.datazaliczeniaprzedmiotuDataGridViewTextBoxColumn,
            this.ECTS,
            this.uwagiprzedmiotuDataGridViewTextBoxColumn});
            this.dgvPrzedmioty.DataSource = this.bsPrzedmioty;
            this.dgvPrzedmioty.Location = new System.Drawing.Point(0, 27);
            this.dgvPrzedmioty.Name = "dgvPrzedmioty";
            this.dgvPrzedmioty.ReadOnly = true;
            this.dgvPrzedmioty.Size = new System.Drawing.Size(831, 481);
            this.dgvPrzedmioty.TabIndex = 1;
            // 
            // nazwa_przedmiotu
            // 
            this.nazwa_przedmiotu.DataPropertyName = "nazwa_przedmiotu";
            this.nazwa_przedmiotu.HeaderText = "Nazwa przedmiotu";
            this.nazwa_przedmiotu.Name = "nazwa_przedmiotu";
            this.nazwa_przedmiotu.ReadOnly = true;
            this.nazwa_przedmiotu.Width = 150;
            // 
            // imie_prowadzacego
            // 
            this.imie_prowadzacego.DataPropertyName = "imie";
            this.imie_prowadzacego.HeaderText = "Imię prowadzącego";
            this.imie_prowadzacego.Name = "imie_prowadzacego";
            this.imie_prowadzacego.ReadOnly = true;
            // 
            // nazwisko_prowadzacego
            // 
            this.nazwisko_prowadzacego.DataPropertyName = "nazwisko";
            this.nazwisko_prowadzacego.HeaderText = "Nazwisko prowadzącego";
            this.nazwisko_prowadzacego.Name = "nazwisko_prowadzacego";
            this.nazwisko_prowadzacego.ReadOnly = true;
            this.nazwisko_prowadzacego.Width = 150;
            // 
            // ocena_przedmiotu
            // 
            this.ocena_przedmiotu.DataPropertyName = "ocena przedmiotu";
            this.ocena_przedmiotu.HeaderText = "Ocena";
            this.ocena_przedmiotu.Name = "ocena_przedmiotu";
            this.ocena_przedmiotu.ReadOnly = true;
            this.ocena_przedmiotu.Width = 50;
            // 
            // ECTS
            // 
            this.ECTS.DataPropertyName = "ECTS";
            this.ECTS.HeaderText = "ECTS";
            this.ECTS.Name = "ECTS";
            this.ECTS.ReadOnly = true;
            this.ECTS.Width = 50;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGRUPYDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn});
            this.dgvStudent.DataSource = this.bsStudent;
            this.dgvStudent.Location = new System.Drawing.Point(0, 147);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(854, 110);
            this.dgvStudent.TabIndex = 2;
            // 
            // dgvProjekty
            // 
            this.dgvProjekty.AllowUserToAddRows = false;
            this.dgvProjekty.AllowUserToDeleteRows = false;
            this.dgvProjekty.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvProjekty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekty.Location = new System.Drawing.Point(0, 238);
            this.dgvProjekty.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProjekty.Name = "dgvProjekty";
            this.dgvProjekty.ReadOnly = true;
            this.dgvProjekty.RowTemplate.Height = 24;
            this.dgvProjekty.Size = new System.Drawing.Size(687, 270);
            this.dgvProjekty.TabIndex = 3;
            this.dgvProjekty.SelectionChanged += new System.EventHandler(this.dgvProjekty_SelectionChanged);
            // 
            // dgvMojeProjekty
            // 
            this.dgvMojeProjekty.AllowUserToAddRows = false;
            this.dgvMojeProjekty.AllowUserToDeleteRows = false;
            this.dgvMojeProjekty.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvMojeProjekty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeProjekty.Location = new System.Drawing.Point(0, 42);
            this.dgvMojeProjekty.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMojeProjekty.Name = "dgvMojeProjekty";
            this.dgvMojeProjekty.ReadOnly = true;
            this.dgvMojeProjekty.RowTemplate.Height = 24;
            this.dgvMojeProjekty.Size = new System.Drawing.Size(845, 192);
            this.dgvMojeProjekty.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zapisz się do projektu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idGRUPYDataGridViewTextBoxColumn
            // 
            this.idGRUPYDataGridViewTextBoxColumn.DataPropertyName = "id_GRUPY";
            this.idGRUPYDataGridViewTextBoxColumn.HeaderText = "Nr grupy dziekańskiej";
            this.idGRUPYDataGridViewTextBoxColumn.Name = "idGRUPYDataGridViewTextBoxColumn";
            this.idGRUPYDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGRUPYDataGridViewTextBoxColumn.Width = 80;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            this.imieDataGridViewTextBoxColumn.Width = 120;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwiskoDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.Width = 120;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Width = 250;
            // 
            // hasloDataGridViewTextBoxColumn
            // 
            this.hasloDataGridViewTextBoxColumn.DataPropertyName = "haslo";
            this.hasloDataGridViewTextBoxColumn.HeaderText = "Hasło";
            this.hasloDataGridViewTextBoxColumn.Name = "hasloDataGridViewTextBoxColumn";
            this.hasloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsStudent
            // 
            this.bsStudent.DataSource = typeof(DziennikOcen.STUDENT);
            // 
            // datazaliczeniaprzedmiotuDataGridViewTextBoxColumn
            // 
            this.datazaliczeniaprzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "data_zaliczenia_przedmiotu";
            this.datazaliczeniaprzedmiotuDataGridViewTextBoxColumn.HeaderText = "Data zaliczenia";
            this.datazaliczeniaprzedmiotuDataGridViewTextBoxColumn.Name = "datazaliczeniaprzedmiotuDataGridViewTextBoxColumn";
            this.datazaliczeniaprzedmiotuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uwagiprzedmiotuDataGridViewTextBoxColumn
            // 
            this.uwagiprzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "uwagi_przedmiotu";
            this.uwagiprzedmiotuDataGridViewTextBoxColumn.HeaderText = "Uwagi do przedmiotu";
            this.uwagiprzedmiotuDataGridViewTextBoxColumn.Name = "uwagiprzedmiotuDataGridViewTextBoxColumn";
            this.uwagiprzedmiotuDataGridViewTextBoxColumn.ReadOnly = true;
            this.uwagiprzedmiotuDataGridViewTextBoxColumn.Width = 350;
            // 
            // bsPrzedmioty
            // 
            this.bsPrzedmioty.DataSource = typeof(DziennikOcen.przedmioty);
            // 
            // bsPrzedmiot
            // 
            this.bsPrzedmiot.DataSource = typeof(DziennikOcen.PRZEDMIOT);
            // 
            // bsProjekty
            // 
            this.bsProjekty.DataSource = typeof(DziennikOcen.PROJEKT);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(863, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMojeProjekty);
            this.Controls.Add(this.dgvProjekty);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.dgvPrzedmioty);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStudent_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzedmioty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeProjekty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrzedmioty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrzedmiot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjekty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem przedmiotyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPrzedmioty;
        private System.Windows.Forms.BindingSource bsPrzedmioty;
        private System.Windows.Forms.BindingSource bsPrzedmiot;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa_przedmiotu;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie_prowadzacego;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko_prowadzacego;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocena_przedmiotu;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazaliczeniaprzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagiprzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.BindingSource bsStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGRUPYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvProjekty;
        private System.Windows.Forms.DataGridView dgvMojeProjekty;
        private System.Windows.Forms.BindingSource bsProjekty;
        private System.Windows.Forms.Button button1;
    }
}