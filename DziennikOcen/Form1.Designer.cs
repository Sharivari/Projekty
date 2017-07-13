namespace DziennikOcen
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
            this.lblLogowanie = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxHaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnProwadzacy = new System.Windows.Forms.Button();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogowanie
            // 
            this.lblLogowanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogowanie.AutoSize = true;
            this.lblLogowanie.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogowanie.Location = new System.Drawing.Point(226, 144);
            this.lblLogowanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogowanie.Name = "lblLogowanie";
            this.lblLogowanie.Size = new System.Drawing.Size(235, 55);
            this.lblLogowanie.TabIndex = 0;
            this.lblLogowanie.Text = "Logowanie";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(285, 284);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(217, 22);
            this.tbxEmail.TabIndex = 1;
            // 
            // tbxHaslo
            // 
            this.tbxHaslo.Location = new System.Drawing.Point(285, 340);
            this.tbxHaslo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxHaslo.Name = "tbxHaslo";
            this.tbxHaslo.Size = new System.Drawing.Size(217, 22);
            this.tbxHaslo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Location = new System.Drawing.Point(331, 388);
            this.btnZaloguj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(100, 28);
            this.btnZaloguj.TabIndex = 5;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 106);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dziennik Ocen";
            // 
            // btnStudent
            // 
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStudent.Location = new System.Drawing.Point(204, 226);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(100, 28);
            this.btnStudent.TabIndex = 9;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnProwadzacy
            // 
            this.btnProwadzacy.Location = new System.Drawing.Point(331, 226);
            this.btnProwadzacy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProwadzacy.Name = "btnProwadzacy";
            this.btnProwadzacy.Size = new System.Drawing.Size(100, 28);
            this.btnProwadzacy.TabIndex = 10;
            this.btnProwadzacy.Text = "Prowadzący";
            this.btnProwadzacy.UseVisualStyleBackColor = true;
            this.btnProwadzacy.Click += new System.EventHandler(this.btnProwadzacy_Click);
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Location = new System.Drawing.Point(461, 226);
            this.btnAdministrator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(100, 28);
            this.btnAdministrator.TabIndex = 11;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(788, 490);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.btnProwadzacy);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnZaloguj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxHaslo);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblLogowanie);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Dziennik Ocen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogowanie;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxHaslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnProwadzacy;
        private System.Windows.Forms.Button btnAdministrator;
    }
}

