namespace MedCare
{
    partial class FrmDodajRacun
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDatumKreiranjaRacuna = new System.Windows.Forms.Label();
            this.lblTrenutniDatumRacuna = new System.Windows.Forms.Label();
            this.lblIzdaoRacun = new System.Windows.Forms.Label();
            this.lblRacunPacijenta = new System.Windows.Forms.Label();
            this.lblIzdaoLijecnik = new System.Windows.Forms.Label();
            this.lblIzdajePacijentu = new System.Windows.Forms.Label();
            this.lblUkupniIznosRacuna = new System.Windows.Forms.Label();
            this.lblTrenutniIznos = new System.Windows.Forms.Label();
            this.lblValuta = new System.Windows.Forms.Label();
            this.btnSpremiRacun = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.Dodaj = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProizvodi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatumKreiranjaRacuna
            // 
            this.lblDatumKreiranjaRacuna.AutoSize = true;
            this.lblDatumKreiranjaRacuna.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumKreiranjaRacuna.Location = new System.Drawing.Point(12, 31);
            this.lblDatumKreiranjaRacuna.Name = "lblDatumKreiranjaRacuna";
            this.lblDatumKreiranjaRacuna.Size = new System.Drawing.Size(68, 23);
            this.lblDatumKreiranjaRacuna.TabIndex = 1;
            this.lblDatumKreiranjaRacuna.Text = "Datum:";
            // 
            // lblTrenutniDatumRacuna
            // 
            this.lblTrenutniDatumRacuna.AutoSize = true;
            this.lblTrenutniDatumRacuna.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutniDatumRacuna.Location = new System.Drawing.Point(86, 32);
            this.lblTrenutniDatumRacuna.Name = "lblTrenutniDatumRacuna";
            this.lblTrenutniDatumRacuna.Size = new System.Drawing.Size(115, 21);
            this.lblTrenutniDatumRacuna.TabIndex = 2;
            this.lblTrenutniDatumRacuna.Text = "TrenutniDatum";
            // 
            // lblIzdaoRacun
            // 
            this.lblIzdaoRacun.AutoSize = true;
            this.lblIzdaoRacun.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzdaoRacun.Location = new System.Drawing.Point(12, 67);
            this.lblIzdaoRacun.Name = "lblIzdaoRacun";
            this.lblIzdaoRacun.Size = new System.Drawing.Size(109, 23);
            this.lblIzdaoRacun.TabIndex = 3;
            this.lblIzdaoRacun.Text = "Račun izdao:";
            // 
            // lblRacunPacijenta
            // 
            this.lblRacunPacijenta.AutoSize = true;
            this.lblRacunPacijenta.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRacunPacijenta.Location = new System.Drawing.Point(12, 103);
            this.lblRacunPacijenta.Name = "lblRacunPacijenta";
            this.lblRacunPacijenta.Size = new System.Drawing.Size(79, 23);
            this.lblRacunPacijenta.TabIndex = 4;
            this.lblRacunPacijenta.Text = "Pacijent:";
            // 
            // lblIzdaoLijecnik
            // 
            this.lblIzdaoLijecnik.AutoSize = true;
            this.lblIzdaoLijecnik.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzdaoLijecnik.Location = new System.Drawing.Point(127, 68);
            this.lblIzdaoLijecnik.Name = "lblIzdaoLijecnik";
            this.lblIzdaoLijecnik.Size = new System.Drawing.Size(98, 21);
            this.lblIzdaoLijecnik.TabIndex = 5;
            this.lblIzdaoLijecnik.Text = "IzdaoLijecnik";
            // 
            // lblIzdajePacijentu
            // 
            this.lblIzdajePacijentu.AutoSize = true;
            this.lblIzdajePacijentu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzdajePacijentu.Location = new System.Drawing.Point(97, 104);
            this.lblIzdajePacijentu.Name = "lblIzdajePacijentu";
            this.lblIzdajePacijentu.Size = new System.Drawing.Size(106, 21);
            this.lblIzdajePacijentu.TabIndex = 6;
            this.lblIzdajePacijentu.Text = "PrimaPacijent";
            // 
            // lblUkupniIznosRacuna
            // 
            this.lblUkupniIznosRacuna.AutoSize = true;
            this.lblUkupniIznosRacuna.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupniIznosRacuna.Location = new System.Drawing.Point(764, 131);
            this.lblUkupniIznosRacuna.Name = "lblUkupniIznosRacuna";
            this.lblUkupniIznosRacuna.Size = new System.Drawing.Size(173, 23);
            this.lblUkupniIznosRacuna.TabIndex = 9;
            this.lblUkupniIznosRacuna.Text = "Ukupni iznos računa:";
            // 
            // lblTrenutniIznos
            // 
            this.lblTrenutniIznos.AutoSize = true;
            this.lblTrenutniIznos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutniIznos.Location = new System.Drawing.Point(978, 133);
            this.lblTrenutniIznos.Name = "lblTrenutniIznos";
            this.lblTrenutniIznos.Size = new System.Drawing.Size(41, 21);
            this.lblTrenutniIznos.TabIndex = 10;
            this.lblTrenutniIznos.Text = "0.00";
            this.lblTrenutniIznos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValuta.Location = new System.Drawing.Point(1047, 133);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(30, 21);
            this.lblValuta.TabIndex = 11;
            this.lblValuta.Text = "KN";
            // 
            // btnSpremiRacun
            // 
            this.btnSpremiRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnSpremiRacun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnSpremiRacun.FlatAppearance.BorderSize = 0;
            this.btnSpremiRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiRacun.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiRacun.ForeColor = System.Drawing.Color.White;
            this.btnSpremiRacun.Location = new System.Drawing.Point(496, 518);
            this.btnSpremiRacun.Name = "btnSpremiRacun";
            this.btnSpremiRacun.Size = new System.Drawing.Size(130, 44);
            this.btnSpremiRacun.TabIndex = 21;
            this.btnSpremiRacun.Text = "Spremi";
            this.btnSpremiRacun.UseVisualStyleBackColor = false;
            this.btnSpremiRacun.Click += new System.EventHandler(this.btnSpremiRacun_Click);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToResizeColumns = false;
            this.dgvProizvodi.AllowUserToResizeRows = false;
            this.dgvProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dodaj,
            this.Naziv,
            this.Cijena,
            this.Količina});
            this.dgvProizvodi.Location = new System.Drawing.Point(13, 203);
            this.dgvProizvodi.Name = "dgvProizvodi";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProizvodi.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(1126, 279);
            this.dgvProizvodi.TabIndex = 8;
            // 
            // Dodaj
            // 
            this.Dodaj.HeaderText = "DODAJ";
            this.Dodaj.Name = "Dodaj";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "NAZIV";
            this.Naziv.Name = "Naziv";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "CIJENA";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.HeaderText = "KOLIČINA";
            this.Količina.Name = "Količina";
            // 
            // lblProizvodi
            // 
            this.lblProizvodi.AutoSize = true;
            this.lblProizvodi.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProizvodi.Location = new System.Drawing.Point(12, 165);
            this.lblProizvodi.Name = "lblProizvodi";
            this.lblProizvodi.Size = new System.Drawing.Size(124, 23);
            this.lblProizvodi.TabIndex = 23;
            this.lblProizvodi.Text = "Stavke računa:";
            // 
            // FrmDodajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 597);
            this.Controls.Add(this.lblProizvodi);
            this.Controls.Add(this.btnSpremiRacun);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.lblTrenutniIznos);
            this.Controls.Add(this.lblUkupniIznosRacuna);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.lblIzdajePacijentu);
            this.Controls.Add(this.lblIzdaoLijecnik);
            this.Controls.Add(this.lblRacunPacijenta);
            this.Controls.Add(this.lblIzdaoRacun);
            this.Controls.Add(this.lblTrenutniDatumRacuna);
            this.Controls.Add(this.lblDatumKreiranjaRacuna);
            this.MaximizeBox = false;
            this.Name = "FrmDodajRacun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi račun";
            this.Load += new System.EventHandler(this.FrmDodajRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatumKreiranjaRacuna;
        private System.Windows.Forms.Label lblTrenutniDatumRacuna;
        private System.Windows.Forms.Label lblIzdaoRacun;
        private System.Windows.Forms.Label lblRacunPacijenta;
        private System.Windows.Forms.Label lblIzdaoLijecnik;
        private System.Windows.Forms.Label lblIzdajePacijentu;
        private System.Windows.Forms.Label lblUkupniIznosRacuna;
        private System.Windows.Forms.Label lblTrenutniIznos;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.Button btnSpremiRacun;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Label lblProizvodi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
    }
}