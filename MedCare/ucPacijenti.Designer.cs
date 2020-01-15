namespace MedCare
{
    partial class ucPacijenti
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcPacijenti = new System.Windows.Forms.TabControl();
            this.tpPacijenti = new System.Windows.Forms.TabPage();
            this.btnObrisiPacijenta = new System.Windows.Forms.Button();
            this.btnNoviPacijent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.dgvListaPacijenata = new System.Windows.Forms.DataGridView();
            this.Oib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpRacuni = new System.Windows.Forms.TabPage();
            this.btnGenerirajRacun = new System.Windows.Forms.Button();
            this.btnObrisiRacun = new System.Windows.Forms.Button();
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcPacijenti.SuspendLayout();
            this.tpPacijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacijenata)).BeginInit();
            this.tpRacuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPacijenti
            // 
            this.tcPacijenti.Controls.Add(this.tpPacijenti);
            this.tcPacijenti.Controls.Add(this.tpRacuni);
            this.tcPacijenti.Location = new System.Drawing.Point(4, 4);
            this.tcPacijenti.Name = "tcPacijenti";
            this.tcPacijenti.SelectedIndex = 0;
            this.tcPacijenti.Size = new System.Drawing.Size(1251, 718);
            this.tcPacijenti.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPacijenti.TabIndex = 0;
            this.tcPacijenti.SelectedIndexChanged += new System.EventHandler(this.tcPacijenti_SelectedIndexChanged);
            // 
            // tpPacijenti
            // 
            this.tpPacijenti.Controls.Add(this.btnObrisiPacijenta);
            this.tpPacijenti.Controls.Add(this.btnNoviPacijent);
            this.tpPacijenti.Controls.Add(this.panel2);
            this.tpPacijenti.Controls.Add(this.panel1);
            this.tpPacijenti.Controls.Add(this.txtPretrazi);
            this.tpPacijenti.Controls.Add(this.lblPretrazivanje);
            this.tpPacijenti.Controls.Add(this.dgvListaPacijenata);
            this.tpPacijenti.Location = new System.Drawing.Point(4, 25);
            this.tpPacijenti.Name = "tpPacijenti";
            this.tpPacijenti.Padding = new System.Windows.Forms.Padding(3);
            this.tpPacijenti.Size = new System.Drawing.Size(1243, 689);
            this.tpPacijenti.TabIndex = 0;
            this.tpPacijenti.Text = "Pacijenti";
            this.tpPacijenti.UseVisualStyleBackColor = true;
            // 
            // btnObrisiPacijenta
            // 
            this.btnObrisiPacijenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnObrisiPacijenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnObrisiPacijenta.FlatAppearance.BorderSize = 0;
            this.btnObrisiPacijenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiPacijenta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiPacijenta.ForeColor = System.Drawing.Color.White;
            this.btnObrisiPacijenta.Location = new System.Drawing.Point(172, 397);
            this.btnObrisiPacijenta.Name = "btnObrisiPacijenta";
            this.btnObrisiPacijenta.Size = new System.Drawing.Size(123, 38);
            this.btnObrisiPacijenta.TabIndex = 6;
            this.btnObrisiPacijenta.Text = "Obriši pacijenta";
            this.btnObrisiPacijenta.UseVisualStyleBackColor = false;
            this.btnObrisiPacijenta.Click += new System.EventHandler(this.btnObrisiPacijenta_Click);
            // 
            // btnNoviPacijent
            // 
            this.btnNoviPacijent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNoviPacijent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNoviPacijent.FlatAppearance.BorderSize = 0;
            this.btnNoviPacijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviPacijent.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoviPacijent.ForeColor = System.Drawing.Color.White;
            this.btnNoviPacijent.Location = new System.Drawing.Point(22, 397);
            this.btnNoviPacijent.Name = "btnNoviPacijent";
            this.btnNoviPacijent.Size = new System.Drawing.Size(123, 38);
            this.btnNoviPacijent.TabIndex = 5;
            this.btnNoviPacijent.Text = "Dodaj pacijenta";
            this.btnNoviPacijent.UseVisualStyleBackColor = false;
            this.btnNoviPacijent.Click += new System.EventHandler(this.btnNoviPacijent_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(1004, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1004, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 1);
            this.panel1.TabIndex = 3;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.BackColor = System.Drawing.SystemColors.Window;
            this.txtPretrazi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretrazi.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(1004, 397);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(221, 16);
            this.txtPretrazi.TabIndex = 2;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazivanje.Location = new System.Drawing.Point(926, 398);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(70, 21);
            this.lblPretrazivanje.TabIndex = 1;
            this.lblPretrazivanje.Text = "Pretraži:";
            // 
            // dgvListaPacijenata
            // 
            this.dgvListaPacijenata.AllowUserToResizeColumns = false;
            this.dgvListaPacijenata.AllowUserToResizeRows = false;
            this.dgvListaPacijenata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPacijenata.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPacijenata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPacijenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPacijenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oib,
            this.Ime,
            this.Prezime,
            this.DatumRodenja,
            this.Adresa,
            this.Kontakt,
            this.Email,
            this.Spol});
            this.dgvListaPacijenata.Location = new System.Drawing.Point(7, 7);
            this.dgvListaPacijenata.Name = "dgvListaPacijenata";
            this.dgvListaPacijenata.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvListaPacijenata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaPacijenata.RowTemplate.Height = 24;
            this.dgvListaPacijenata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPacijenata.Size = new System.Drawing.Size(1230, 373);
            this.dgvListaPacijenata.TabIndex = 0;
            this.dgvListaPacijenata.SelectionChanged += new System.EventHandler(this.dgvListaPacijenata_SelectionChanged);
            // 
            // Oib
            // 
            this.Oib.DataPropertyName = "Oib";
            this.Oib.FillWeight = 86.08327F;
            this.Oib.HeaderText = "OIB";
            this.Oib.Name = "Oib";
            this.Oib.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.FillWeight = 108.8338F;
            this.Ime.HeaderText = "IME";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.FillWeight = 108.8338F;
            this.Prezime.HeaderText = "PREZIME";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // DatumRodenja
            // 
            this.DatumRodenja.DataPropertyName = "DatumRođenja";
            this.DatumRodenja.FillWeight = 108.8338F;
            this.DatumRodenja.HeaderText = "DATUM ROĐENJA";
            this.DatumRodenja.Name = "DatumRodenja";
            this.DatumRodenja.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.FillWeight = 108.8338F;
            this.Adresa.HeaderText = "ADRESA";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Kontakt
            // 
            this.Kontakt.DataPropertyName = "Kontakt";
            this.Kontakt.FillWeight = 108.8338F;
            this.Kontakt.HeaderText = "KONTAKT";
            this.Kontakt.Name = "Kontakt";
            this.Kontakt.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 108.8338F;
            this.Email.HeaderText = "EMAIL";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.FillWeight = 60.9137F;
            this.Spol.HeaderText = "SPOL";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // tpRacuni
            // 
            this.tpRacuni.Controls.Add(this.btnGenerirajRacun);
            this.tpRacuni.Controls.Add(this.btnObrisiRacun);
            this.tpRacuni.Controls.Add(this.btnNoviRacun);
            this.tpRacuni.Controls.Add(this.dgvRacuni);
            this.tpRacuni.Location = new System.Drawing.Point(4, 25);
            this.tpRacuni.Name = "tpRacuni";
            this.tpRacuni.Padding = new System.Windows.Forms.Padding(3);
            this.tpRacuni.Size = new System.Drawing.Size(1243, 689);
            this.tpRacuni.TabIndex = 1;
            this.tpRacuni.Text = "Računi";
            this.tpRacuni.UseVisualStyleBackColor = true;
            // 
            // btnGenerirajRacun
            // 
            this.btnGenerirajRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnGenerirajRacun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnGenerirajRacun.FlatAppearance.BorderSize = 0;
            this.btnGenerirajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerirajRacun.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerirajRacun.ForeColor = System.Drawing.Color.White;
            this.btnGenerirajRacun.Location = new System.Drawing.Point(1099, 397);
            this.btnGenerirajRacun.Name = "btnGenerirajRacun";
            this.btnGenerirajRacun.Size = new System.Drawing.Size(123, 38);
            this.btnGenerirajRacun.TabIndex = 8;
            this.btnGenerirajRacun.Text = "Generiraj račun";
            this.btnGenerirajRacun.UseVisualStyleBackColor = false;
            this.btnGenerirajRacun.Click += new System.EventHandler(this.btnGenerirajRacun_Click);
            // 
            // btnObrisiRacun
            // 
            this.btnObrisiRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnObrisiRacun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnObrisiRacun.FlatAppearance.BorderSize = 0;
            this.btnObrisiRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiRacun.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiRacun.ForeColor = System.Drawing.Color.White;
            this.btnObrisiRacun.Location = new System.Drawing.Point(172, 397);
            this.btnObrisiRacun.Name = "btnObrisiRacun";
            this.btnObrisiRacun.Size = new System.Drawing.Size(123, 38);
            this.btnObrisiRacun.TabIndex = 7;
            this.btnObrisiRacun.Text = "Obriši račun";
            this.btnObrisiRacun.UseVisualStyleBackColor = false;
            this.btnObrisiRacun.Click += new System.EventHandler(this.btnObrisiRacun_Click);
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNoviRacun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNoviRacun.FlatAppearance.BorderSize = 0;
            this.btnNoviRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviRacun.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoviRacun.ForeColor = System.Drawing.Color.White;
            this.btnNoviRacun.Location = new System.Drawing.Point(22, 397);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(123, 38);
            this.btnNoviRacun.TabIndex = 6;
            this.btnNoviRacun.Text = "Dodaj račun";
            this.btnNoviRacun.UseVisualStyleBackColor = false;
            this.btnNoviRacun.Click += new System.EventHandler(this.btnNoviRacun_Click);
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToResizeColumns = false;
            this.dgvRacuni.AllowUserToResizeRows = false;
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dgvRacuni.Location = new System.Drawing.Point(7, 7);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvRacuni.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRacuni.RowTemplate.Height = 24;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(1230, 373);
            this.dgvRacuni.TabIndex = 1;
            this.dgvRacuni.SelectionChanged += new System.EventHandler(this.dgvRacuni_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn1.FillWeight = 86.08327F;
            this.dataGridViewTextBoxColumn1.HeaderText = "DATUM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ZaposleniciId";
            this.dataGridViewTextBoxColumn2.FillWeight = 108.8338F;
            this.dataGridViewTextBoxColumn2.HeaderText = "IZDAO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Iznos";
            this.dataGridViewTextBoxColumn4.FillWeight = 108.8338F;
            this.dataGridViewTextBoxColumn4.HeaderText = "IZNOS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ucPacijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcPacijenti);
            this.Name = "ucPacijenti";
            this.Size = new System.Drawing.Size(1258, 725);
            this.Load += new System.EventHandler(this.ucPacijenti_Load);
            this.tcPacijenti.ResumeLayout(false);
            this.tpPacijenti.ResumeLayout(false);
            this.tpPacijenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacijenata)).EndInit();
            this.tpRacuni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPacijenti;
        private System.Windows.Forms.TabPage tpPacijenti;
        private System.Windows.Forms.TabPage tpRacuni;
        private System.Windows.Forms.DataGridView dgvListaPacijenata;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.Button btnNoviPacijent;
        private System.Windows.Forms.Button btnObrisiPacijenta;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnObrisiRacun;
        private System.Windows.Forms.Button btnNoviRacun;
        private System.Windows.Forms.Button btnGenerirajRacun;
    }
}
