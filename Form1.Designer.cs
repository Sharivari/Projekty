namespace XML
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnDodajAktora = new System.Windows.Forms.Button();
            this.tbxActorName = new System.Windows.Forms.TextBox();
            this.tbxBirthDate = new System.Windows.Forms.TextBox();
            this.tbxPlaceOFBirth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdytujAktora = new System.Windows.Forms.Button();
            this.tbxFilmName = new System.Windows.Forms.TextBox();
            this.tbxFilmDate = new System.Windows.Forms.TextBox();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFilmGenres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.treeViewFilms = new System.Windows.Forms.TreeView();
            this.btnEdytujFilm = new System.Windows.Forms.Button();
            this.cbxActor = new System.Windows.Forms.ComboBox();
            this.cbxFilm = new System.Windows.Forms.ComboBox();
            this.tbxCharacter = new System.Windows.Forms.TextBox();
            this.btnDodajFilmDoAktora = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(19, 22);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(445, 362);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnDodajAktora
            // 
            this.btnDodajAktora.Location = new System.Drawing.Point(953, 19);
            this.btnDodajAktora.Name = "btnDodajAktora";
            this.btnDodajAktora.Size = new System.Drawing.Size(133, 23);
            this.btnDodajAktora.TabIndex = 3;
            this.btnDodajAktora.Text = "Dodaj aktora";
            this.btnDodajAktora.UseVisualStyleBackColor = true;
            this.btnDodajAktora.Click += new System.EventHandler(this.btnDodajAktora_Click);
            // 
            // tbxActorName
            // 
            this.tbxActorName.Location = new System.Drawing.Point(470, 22);
            this.tbxActorName.Name = "tbxActorName";
            this.tbxActorName.Size = new System.Drawing.Size(206, 20);
            this.tbxActorName.TabIndex = 4;
            // 
            // tbxBirthDate
            // 
            this.tbxBirthDate.Location = new System.Drawing.Point(682, 22);
            this.tbxBirthDate.Name = "tbxBirthDate";
            this.tbxBirthDate.Size = new System.Drawing.Size(100, 20);
            this.tbxBirthDate.TabIndex = 6;
            // 
            // tbxPlaceOFBirth
            // 
            this.tbxPlaceOFBirth.Location = new System.Drawing.Point(788, 22);
            this.tbxPlaceOFBirth.Name = "tbxPlaceOFBirth";
            this.tbxPlaceOFBirth.Size = new System.Drawing.Size(159, 20);
            this.tbxPlaceOFBirth.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imię i nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(796, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Miejsce urodzenia";
            // 
            // btnEdytujAktora
            // 
            this.btnEdytujAktora.Location = new System.Drawing.Point(470, 59);
            this.btnEdytujAktora.Name = "btnEdytujAktora";
            this.btnEdytujAktora.Size = new System.Drawing.Size(616, 23);
            this.btnEdytujAktora.TabIndex = 12;
            this.btnEdytujAktora.Text = "Edytuj aktorów";
            this.btnEdytujAktora.UseVisualStyleBackColor = true;
            this.btnEdytujAktora.Click += new System.EventHandler(this.btnEdytujAktora_Click);
            // 
            // tbxFilmName
            // 
            this.tbxFilmName.Location = new System.Drawing.Point(472, 403);
            this.tbxFilmName.Name = "tbxFilmName";
            this.tbxFilmName.Size = new System.Drawing.Size(206, 20);
            this.tbxFilmName.TabIndex = 13;
            // 
            // tbxFilmDate
            // 
            this.tbxFilmDate.Location = new System.Drawing.Point(684, 403);
            this.tbxFilmDate.Name = "tbxFilmDate";
            this.tbxFilmDate.Size = new System.Drawing.Size(100, 20);
            this.tbxFilmDate.TabIndex = 14;
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Location = new System.Drawing.Point(955, 403);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(133, 23);
            this.btnDodajFilm.TabIndex = 15;
            this.btnDodajFilm.Text = "Dodaj film";
            this.btnDodajFilm.UseVisualStyleBackColor = true;
            this.btnDodajFilm.Click += new System.EventHandler(this.btnDodajFilm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nazwa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data wydania";
            // 
            // tbxFilmGenres
            // 
            this.tbxFilmGenres.Location = new System.Drawing.Point(790, 403);
            this.tbxFilmGenres.Name = "tbxFilmGenres";
            this.tbxFilmGenres.Size = new System.Drawing.Size(159, 20);
            this.tbxFilmGenres.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(844, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Rodzaje";
            // 
            // treeViewFilms
            // 
            this.treeViewFilms.Location = new System.Drawing.Point(19, 390);
            this.treeViewFilms.Name = "treeViewFilms";
            this.treeViewFilms.Size = new System.Drawing.Size(447, 289);
            this.treeViewFilms.TabIndex = 20;
            // 
            // btnEdytujFilm
            // 
            this.btnEdytujFilm.Location = new System.Drawing.Point(472, 442);
            this.btnEdytujFilm.Name = "btnEdytujFilm";
            this.btnEdytujFilm.Size = new System.Drawing.Size(616, 23);
            this.btnEdytujFilm.TabIndex = 21;
            this.btnEdytujFilm.Text = "Edytuj filmy";
            this.btnEdytujFilm.UseVisualStyleBackColor = true;
            this.btnEdytujFilm.Click += new System.EventHandler(this.btnEdytujFilm_Click);
            // 
            // cbxActor
            // 
            this.cbxActor.FormattingEnabled = true;
            this.cbxActor.Location = new System.Drawing.Point(470, 135);
            this.cbxActor.Name = "cbxActor";
            this.cbxActor.Size = new System.Drawing.Size(154, 21);
            this.cbxActor.TabIndex = 22;
            // 
            // cbxFilm
            // 
            this.cbxFilm.FormattingEnabled = true;
            this.cbxFilm.Location = new System.Drawing.Point(630, 136);
            this.cbxFilm.Name = "cbxFilm";
            this.cbxFilm.Size = new System.Drawing.Size(152, 21);
            this.cbxFilm.TabIndex = 23;
            // 
            // tbxCharacter
            // 
            this.tbxCharacter.Location = new System.Drawing.Point(788, 136);
            this.tbxCharacter.Name = "tbxCharacter";
            this.tbxCharacter.Size = new System.Drawing.Size(159, 20);
            this.tbxCharacter.TabIndex = 24;
            // 
            // btnDodajFilmDoAktora
            // 
            this.btnDodajFilmDoAktora.Location = new System.Drawing.Point(953, 133);
            this.btnDodajFilmDoAktora.Name = "btnDodajFilmDoAktora";
            this.btnDodajFilmDoAktora.Size = new System.Drawing.Size(133, 23);
            this.btnDodajFilmDoAktora.TabIndex = 25;
            this.btnDodajFilmDoAktora.Text = "Dodaj film do aktora";
            this.btnDodajFilmDoAktora.UseVisualStyleBackColor = true;
            this.btnDodajFilmDoAktora.Click += new System.EventHandler(this.btnDodajFilmDoAktora_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Aktor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(694, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Film";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(844, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Postać";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Usuń aktora";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDodajFilmDoAktora);
            this.Controls.Add(this.tbxCharacter);
            this.Controls.Add(this.cbxFilm);
            this.Controls.Add(this.cbxActor);
            this.Controls.Add(this.btnEdytujFilm);
            this.Controls.Add(this.treeViewFilms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxFilmGenres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajFilm);
            this.Controls.Add(this.tbxFilmDate);
            this.Controls.Add(this.tbxFilmName);
            this.Controls.Add(this.btnEdytujAktora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPlaceOFBirth);
            this.Controls.Add(this.tbxBirthDate);
            this.Controls.Add(this.tbxActorName);
            this.Controls.Add(this.btnDodajAktora);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnDodajAktora;
        private System.Windows.Forms.TextBox tbxActorName;
        private System.Windows.Forms.TextBox tbxBirthDate;
        private System.Windows.Forms.TextBox tbxPlaceOFBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdytujAktora;
        private System.Windows.Forms.TextBox tbxFilmName;
        private System.Windows.Forms.TextBox tbxFilmDate;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFilmGenres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeViewFilms;
        private System.Windows.Forms.Button btnEdytujFilm;
        private System.Windows.Forms.ComboBox cbxActor;
        private System.Windows.Forms.ComboBox cbxFilm;
        private System.Windows.Forms.TextBox tbxCharacter;
        private System.Windows.Forms.Button btnDodajFilmDoAktora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

