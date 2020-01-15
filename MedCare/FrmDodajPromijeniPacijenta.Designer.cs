namespace MedCare
{
    partial class FrmDodajPromijeniPacijenta
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
            this.lblOib = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumRodenja = new System.Windows.Forms.Label();
            this.dtpDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.lblSpol = new System.Windows.Forms.Label();
            this.cmbLijecnik = new System.Windows.Forms.ComboBox();
            this.cmbStomatolog = new System.Windows.Forms.ComboBox();
            this.lblLijecnik = new System.Windows.Forms.Label();
            this.lblStomatolog = new System.Windows.Forms.Label();
            this.btnSpremiPacijenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOib
            // 
            this.lblOib.AutoSize = true;
            this.lblOib.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOib.Location = new System.Drawing.Point(25, 23);
            this.lblOib.Name = "lblOib";
            this.lblOib.Size = new System.Drawing.Size(39, 21);
            this.lblOib.TabIndex = 0;
            this.lblOib.Text = "OIB:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(25, 86);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(41, 21);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(25, 149);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(71, 21);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblDatumRodenja
            // 
            this.lblDatumRodenja.AutoSize = true;
            this.lblDatumRodenja.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumRodenja.Location = new System.Drawing.Point(27, 214);
            this.lblDatumRodenja.Name = "lblDatumRodenja";
            this.lblDatumRodenja.Size = new System.Drawing.Size(119, 21);
            this.lblDatumRodenja.TabIndex = 3;
            this.lblDatumRodenja.Text = "Datum rođenja:";
            // 
            // dtpDatumRodenja
            // 
            this.dtpDatumRodenja.CalendarFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatumRodenja.CustomFormat = "yyyy-MM-dd";
            this.dtpDatumRodenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodenja.Location = new System.Drawing.Point(29, 253);
            this.dtpDatumRodenja.Name = "dtpDatumRodenja";
            this.dtpDatumRodenja.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumRodenja.TabIndex = 4;
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(29, 47);
            this.txtOib.MaxLength = 11;
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(158, 22);
            this.txtOib.TabIndex = 5;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(29, 110);
            this.txtIme.MaxLength = 30;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(158, 22);
            this.txtIme.TabIndex = 6;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(29, 173);
            this.txtPrezime.MaxLength = 30;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(158, 22);
            this.txtPrezime.TabIndex = 7;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(270, 23);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(63, 21);
            this.lblAdresa.TabIndex = 8;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontakt.Location = new System.Drawing.Point(270, 86);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(70, 21);
            this.lblKontakt.TabIndex = 9;
            this.lblKontakt.Text = "Kontakt:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(270, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 21);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(274, 47);
            this.txtAdresa.MaxLength = 50;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(158, 22);
            this.txtAdresa.TabIndex = 11;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(274, 110);
            this.txtKontakt.MaxLength = 15;
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(158, 22);
            this.txtKontakt.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 173);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cmbSpol.Location = new System.Drawing.Point(274, 251);
            this.cmbSpol.MaxDropDownItems = 2;
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(80, 24);
            this.cmbSpol.TabIndex = 14;
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpol.Location = new System.Drawing.Point(270, 214);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(45, 21);
            this.lblSpol.TabIndex = 15;
            this.lblSpol.Text = "Spol:";
            // 
            // cmbLijecnik
            // 
            this.cmbLijecnik.FormattingEnabled = true;
            this.cmbLijecnik.Location = new System.Drawing.Point(503, 47);
            this.cmbLijecnik.Name = "cmbLijecnik";
            this.cmbLijecnik.Size = new System.Drawing.Size(148, 24);
            this.cmbLijecnik.TabIndex = 16;
            // 
            // cmbStomatolog
            // 
            this.cmbStomatolog.FormattingEnabled = true;
            this.cmbStomatolog.Location = new System.Drawing.Point(503, 110);
            this.cmbStomatolog.Name = "cmbStomatolog";
            this.cmbStomatolog.Size = new System.Drawing.Size(148, 24);
            this.cmbStomatolog.TabIndex = 17;
            // 
            // lblLijecnik
            // 
            this.lblLijecnik.AutoSize = true;
            this.lblLijecnik.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLijecnik.Location = new System.Drawing.Point(499, 23);
            this.lblLijecnik.Name = "lblLijecnik";
            this.lblLijecnik.Size = new System.Drawing.Size(66, 21);
            this.lblLijecnik.TabIndex = 18;
            this.lblLijecnik.Text = "Liječnik:";
            // 
            // lblStomatolog
            // 
            this.lblStomatolog.AutoSize = true;
            this.lblStomatolog.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStomatolog.Location = new System.Drawing.Point(499, 86);
            this.lblStomatolog.Name = "lblStomatolog";
            this.lblStomatolog.Size = new System.Drawing.Size(96, 21);
            this.lblStomatolog.TabIndex = 19;
            this.lblStomatolog.Text = "Stomatolog:";
            // 
            // btnSpremiPacijenta
            // 
            this.btnSpremiPacijenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnSpremiPacijenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnSpremiPacijenta.FlatAppearance.BorderSize = 0;
            this.btnSpremiPacijenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiPacijenta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiPacijenta.ForeColor = System.Drawing.Color.White;
            this.btnSpremiPacijenta.Location = new System.Drawing.Point(387, 472);
            this.btnSpremiPacijenta.Name = "btnSpremiPacijenta";
            this.btnSpremiPacijenta.Size = new System.Drawing.Size(119, 53);
            this.btnSpremiPacijenta.TabIndex = 20;
            this.btnSpremiPacijenta.Text = "Spremi";
            this.btnSpremiPacijenta.UseVisualStyleBackColor = false;
            this.btnSpremiPacijenta.Click += new System.EventHandler(this.btnSpremiPacijenta_Click);
            // 
            // FrmDodajPromijeniPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 561);
            this.Controls.Add(this.btnSpremiPacijenta);
            this.Controls.Add(this.lblStomatolog);
            this.Controls.Add(this.lblLijecnik);
            this.Controls.Add(this.cmbStomatolog);
            this.Controls.Add(this.cmbLijecnik);
            this.Controls.Add(this.lblSpol);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.dtpDatumRodenja);
            this.Controls.Add(this.lblDatumRodenja);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblOib);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDodajPromijeniPacijenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj/promijeni pacijenta";
            this.Load += new System.EventHandler(this.FrmDodajPromijeniPacijenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOib;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumRodenja;
        private System.Windows.Forms.DateTimePicker dtpDatumRodenja;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.Label lblSpol;
        private System.Windows.Forms.ComboBox cmbLijecnik;
        private System.Windows.Forms.ComboBox cmbStomatolog;
        private System.Windows.Forms.Label lblLijecnik;
        private System.Windows.Forms.Label lblStomatolog;
        private System.Windows.Forms.Button btnSpremiPacijenta;
    }
}