namespace DziennikOcen
{
    partial class FormProwadzacy
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
            this.studenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvStudenci = new System.Windows.Forms.DataGridView();
            this.dgvStudenciProjekty = new System.Windows.Forms.DataGridView();
            this.btnDodajStudenta = new System.Windows.Forms.Button();
            this.btnEdytujStudenta = new System.Windows.Forms.Button();
            this.btnUsunStudenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUsunProjekt = new System.Windows.Forms.Button();
            this.btnEdytujProjekt = new System.Windows.Forms.Button();
            this.dgvprojekty = new System.Windows.Forms.DataGridView();
            this.btnDodajProjektt = new System.Windows.Forms.Button();
            this.btnEdytujProjektt = new System.Windows.Forms.Button();
            this.btnUsunProjektt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_PRZEDMIOTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa_projektu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis_projektu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProjekty = new System.Windows.Forms.BindingSource(this.components);
            this.idPROJEKTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsprojektyy = new System.Windows.Forms.BindingSource(this.components);
            this.idSTUDENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGRUPYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStudenci = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenciProjekty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprojekty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjekty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprojektyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudenci)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studenciToolStripMenuItem,
            this.projektyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(905, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studenciToolStripMenuItem
            // 
            this.studenciToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studenciToolStripMenuItem.Name = "studenciToolStripMenuItem";
            this.studenciToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.studenciToolStripMenuItem.Text = "Studenci";
            this.studenciToolStripMenuItem.Click += new System.EventHandler(this.studenciToolStripMenuItem_Click);
            // 
            // projektyToolStripMenuItem
            // 
            this.projektyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.projektyToolStripMenuItem.Name = "projektyToolStripMenuItem";
            this.projektyToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.projektyToolStripMenuItem.Text = "Projekty";
            this.projektyToolStripMenuItem.Click += new System.EventHandler(this.projektyToolStripMenuItem_Click);
            // 
            // dgvStudenci
            // 
            this.dgvStudenci.AutoGenerateColumns = false;
            this.dgvStudenci.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvStudenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSTUDENTADataGridViewTextBoxColumn,
            this.idGRUPYDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvStudenci.DataSource = this.bsStudenci;
            this.dgvStudenci.Location = new System.Drawing.Point(9, 33);
            this.dgvStudenci.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudenci.Name = "dgvStudenci";
            this.dgvStudenci.RowTemplate.Height = 24;
            this.dgvStudenci.Size = new System.Drawing.Size(803, 188);
            this.dgvStudenci.TabIndex = 1;
            this.dgvStudenci.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvStudenci_MouseClick);
            // 
            // dgvStudenciProjekty
            // 
            this.dgvStudenciProjekty.AllowUserToAddRows = false;
            this.dgvStudenciProjekty.AllowUserToDeleteRows = false;
            this.dgvStudenciProjekty.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvStudenciProjekty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenciProjekty.Location = new System.Drawing.Point(9, 225);
            this.dgvStudenciProjekty.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudenciProjekty.Name = "dgvStudenciProjekty";
            this.dgvStudenciProjekty.RowTemplate.Height = 24;
            this.dgvStudenciProjekty.Size = new System.Drawing.Size(803, 290);
            this.dgvStudenciProjekty.TabIndex = 2;
            this.dgvStudenciProjekty.SelectionChanged += new System.EventHandler(this.dgvStudenciProjekty_SelectionChanged);
            // 
            // btnDodajStudenta
            // 
            this.btnDodajStudenta.Location = new System.Drawing.Point(817, 52);
            this.btnDodajStudenta.Name = "btnDodajStudenta";
            this.btnDodajStudenta.Size = new System.Drawing.Size(75, 23);
            this.btnDodajStudenta.TabIndex = 3;
            this.btnDodajStudenta.Text = "Dodaj studenta";
            this.btnDodajStudenta.UseVisualStyleBackColor = true;
            this.btnDodajStudenta.Click += new System.EventHandler(this.btnDodajStudenta_Click);
            // 
            // btnEdytujStudenta
            // 
            this.btnEdytujStudenta.Location = new System.Drawing.Point(817, 82);
            this.btnEdytujStudenta.Name = "btnEdytujStudenta";
            this.btnEdytujStudenta.Size = new System.Drawing.Size(75, 23);
            this.btnEdytujStudenta.TabIndex = 4;
            this.btnEdytujStudenta.Text = "Edytuj";
            this.btnEdytujStudenta.UseVisualStyleBackColor = true;
            this.btnEdytujStudenta.Click += new System.EventHandler(this.btnEdytujStudenta_Click);
            // 
            // btnUsunStudenta
            // 
            this.btnUsunStudenta.Location = new System.Drawing.Point(817, 112);
            this.btnUsunStudenta.Name = "btnUsunStudenta";
            this.btnUsunStudenta.Size = new System.Drawing.Size(75, 23);
            this.btnUsunStudenta.TabIndex = 5;
            this.btnUsunStudenta.Text = "Usuń";
            this.btnUsunStudenta.UseVisualStyleBackColor = true;
            this.btnUsunStudenta.Click += new System.EventHandler(this.btnUsunStudenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(817, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Studenci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(820, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Projekty:";
            // 
            // btnUsunProjekt
            // 
            this.btnUsunProjekt.Location = new System.Drawing.Point(817, 271);
            this.btnUsunProjekt.Name = "btnUsunProjekt";
            this.btnUsunProjekt.Size = new System.Drawing.Size(75, 23);
            this.btnUsunProjekt.TabIndex = 10;
            this.btnUsunProjekt.Text = "Usuń";
            this.btnUsunProjekt.UseVisualStyleBackColor = true;
            this.btnUsunProjekt.Click += new System.EventHandler(this.btnUsunProjekt_Click);
            // 
            // btnEdytujProjekt
            // 
            this.btnEdytujProjekt.Location = new System.Drawing.Point(817, 241);
            this.btnEdytujProjekt.Name = "btnEdytujProjekt";
            this.btnEdytujProjekt.Size = new System.Drawing.Size(75, 23);
            this.btnEdytujProjekt.TabIndex = 9;
            this.btnEdytujProjekt.Text = "Edytuj";
            this.btnEdytujProjekt.UseVisualStyleBackColor = true;
            this.btnEdytujProjekt.Click += new System.EventHandler(this.btnEdytujProjekt_Click);
            // 
            // dgvprojekty
            // 
            this.dgvprojekty.AutoGenerateColumns = false;
            this.dgvprojekty.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvprojekty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprojekty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPROJEKTUDataGridViewTextBoxColumn,
            this.id_PRZEDMIOTU,
            this.nazwa_projektu,
            this.opis_projektu});
            this.dgvprojekty.DataSource = this.bsprojektyy;
            this.dgvprojekty.Location = new System.Drawing.Point(9, 52);
            this.dgvprojekty.Name = "dgvprojekty";
            this.dgvprojekty.Size = new System.Drawing.Size(805, 438);
            this.dgvprojekty.TabIndex = 11;
            // 
            // btnDodajProjektt
            // 
            this.btnDodajProjektt.Location = new System.Drawing.Point(817, 53);
            this.btnDodajProjektt.Name = "btnDodajProjektt";
            this.btnDodajProjektt.Size = new System.Drawing.Size(75, 23);
            this.btnDodajProjektt.TabIndex = 12;
            this.btnDodajProjektt.Text = "Dodaj";
            this.btnDodajProjektt.UseVisualStyleBackColor = true;
            this.btnDodajProjektt.Click += new System.EventHandler(this.btnDodajProjektt_Click);
            // 
            // btnEdytujProjektt
            // 
            this.btnEdytujProjektt.Location = new System.Drawing.Point(817, 83);
            this.btnEdytujProjektt.Name = "btnEdytujProjektt";
            this.btnEdytujProjektt.Size = new System.Drawing.Size(75, 23);
            this.btnEdytujProjektt.TabIndex = 13;
            this.btnEdytujProjektt.Text = "Edytuj";
            this.btnEdytujProjektt.UseVisualStyleBackColor = true;
            this.btnEdytujProjektt.Click += new System.EventHandler(this.btnEdytujProjektt_Click);
            // 
            // btnUsunProjektt
            // 
            this.btnUsunProjektt.Location = new System.Drawing.Point(817, 112);
            this.btnUsunProjektt.Name = "btnUsunProjektt";
            this.btnUsunProjektt.Size = new System.Drawing.Size(75, 23);
            this.btnUsunProjektt.TabIndex = 14;
            this.btnUsunProjektt.Text = "Usuń";
            this.btnUsunProjektt.UseVisualStyleBackColor = true;
            this.btnUsunProjektt.Click += new System.EventHandler(this.btnUsunProjektt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(820, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Projekty:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRZEDMIOT";
            this.dataGridViewTextBoxColumn1.HeaderText = "PRZEDMIOT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // id_PRZEDMIOTU
            // 
            this.id_PRZEDMIOTU.DataPropertyName = "id_PRZEDMIOTU";
            this.id_PRZEDMIOTU.HeaderText = "id_PRZEDMIOTU";
            this.id_PRZEDMIOTU.Name = "id_PRZEDMIOTU";
            // 
            // nazwa_projektu
            // 
            this.nazwa_projektu.DataPropertyName = "nazwa_projektu";
            this.nazwa_projektu.HeaderText = "Nazwa projektu";
            this.nazwa_projektu.Name = "nazwa_projektu";
            this.nazwa_projektu.Width = 200;
            // 
            // opis_projektu
            // 
            this.opis_projektu.DataPropertyName = "opis_projektu";
            this.opis_projektu.HeaderText = "Opis";
            this.opis_projektu.Name = "opis_projektu";
            this.opis_projektu.Width = 350;
            // 
            // idPROJEKTUDataGridViewTextBoxColumn
            // 
            this.idPROJEKTUDataGridViewTextBoxColumn.DataPropertyName = "id_PROJEKTU";
            this.idPROJEKTUDataGridViewTextBoxColumn.HeaderText = "id_PROJEKTU";
            this.idPROJEKTUDataGridViewTextBoxColumn.Name = "idPROJEKTUDataGridViewTextBoxColumn";
            // 
            // bsprojektyy
            // 
            this.bsprojektyy.DataSource = typeof(DziennikOcen.PROJEKT);
            // 
            // idSTUDENTADataGridViewTextBoxColumn
            // 
            this.idSTUDENTADataGridViewTextBoxColumn.DataPropertyName = "id_STUDENTA";
            this.idSTUDENTADataGridViewTextBoxColumn.HeaderText = "ID";
            this.idSTUDENTADataGridViewTextBoxColumn.Name = "idSTUDENTADataGridViewTextBoxColumn";
            this.idSTUDENTADataGridViewTextBoxColumn.Width = 40;
            // 
            // idGRUPYDataGridViewTextBoxColumn
            // 
            this.idGRUPYDataGridViewTextBoxColumn.DataPropertyName = "id_GRUPY";
            this.idGRUPYDataGridViewTextBoxColumn.HeaderText = "Grupa";
            this.idGRUPYDataGridViewTextBoxColumn.Name = "idGRUPYDataGridViewTextBoxColumn";
            this.idGRUPYDataGridViewTextBoxColumn.Width = 40;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 160;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e_mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 120;
            // 
            // bsStudenci
            // 
            this.bsStudenci.DataSource = typeof(DziennikOcen.STUDENT);
            // 
            // FormProwadzacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(905, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUsunProjektt);
            this.Controls.Add(this.btnEdytujProjektt);
            this.Controls.Add(this.btnDodajProjektt);
            this.Controls.Add(this.dgvprojekty);
            this.Controls.Add(this.btnUsunProjekt);
            this.Controls.Add(this.btnEdytujProjekt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsunStudenta);
            this.Controls.Add(this.btnEdytujStudenta);
            this.Controls.Add(this.btnDodajStudenta);
            this.Controls.Add(this.dgvStudenciProjekty);
            this.Controls.Add(this.dgvStudenci);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProwadzacy";
            this.Text = "FormProwadzacy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProwadzacy_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenciProjekty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprojekty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjekty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprojektyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStudenci;
        private System.Windows.Forms.DataGridView dgvStudenciProjekty;
        private System.Windows.Forms.BindingSource bsStudenci;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSTUDENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGRUPYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajStudenta;
        private System.Windows.Forms.Button btnEdytujStudenta;
        private System.Windows.Forms.Button btnUsunStudenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsProjekty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUsunProjekt;
        private System.Windows.Forms.Button btnEdytujProjekt;
        private System.Windows.Forms.BindingSource bsprojektyy;
        private System.Windows.Forms.DataGridView dgvprojekty;
        private System.Windows.Forms.Button btnDodajProjektt;
        private System.Windows.Forms.Button btnEdytujProjektt;
        private System.Windows.Forms.Button btnUsunProjektt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPROJEKTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_PRZEDMIOTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa_projektu;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis_projektu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}