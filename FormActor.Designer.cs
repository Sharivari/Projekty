namespace XML
{
    partial class FormActor
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPlaceBirth = new System.Windows.Forms.TextBox();
            this.tbxBirth = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.cbxActor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(95, 49);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxPlaceBirth
            // 
            this.tbxPlaceBirth.Location = new System.Drawing.Point(95, 102);
            this.tbxPlaceBirth.Name = "tbxPlaceBirth";
            this.tbxPlaceBirth.Size = new System.Drawing.Size(100, 20);
            this.tbxPlaceBirth.TabIndex = 3;
            // 
            // tbxBirth
            // 
            this.tbxBirth.Location = new System.Drawing.Point(95, 75);
            this.tbxBirth.Name = "tbxBirth";
            this.tbxBirth.Size = new System.Drawing.Size(100, 20);
            this.tbxBirth.TabIndex = 2;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(50, 172);
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
            this.btnAnuluj.Location = new System.Drawing.Point(148, 172);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 5;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // cbxActor
            // 
            this.cbxActor.FormattingEnabled = true;
            this.cbxActor.Location = new System.Drawing.Point(74, 12);
            this.cbxActor.Name = "cbxActor";
            this.cbxActor.Size = new System.Drawing.Size(121, 21);
            this.cbxActor.TabIndex = 6;
            this.cbxActor.SelectedIndexChanged += new System.EventHandler(this.cbxActor_SelectedIndexChanged);
            // 
            // FormActor
            // 
            this.AcceptButton = this.btnZapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuluj;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbxActor);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.tbxPlaceBirth);
            this.Controls.Add(this.tbxBirth);
            this.Controls.Add(this.tbxName);
            this.Name = "FormActor";
            this.Text = "FormActor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPlaceBirth;
        private System.Windows.Forms.TextBox tbxBirth;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.ComboBox cbxActor;
    }
}