namespace MedCare
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlButtoni = new System.Windows.Forms.Panel();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnPacijenti = new System.Windows.Forms.Button();
            this.btnLijekovi = new System.Windows.Forms.Button();
            this.btnLijecnici = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trakica = new System.Windows.Forms.Panel();
            this.pnlGlavni = new System.Windows.Forms.Panel();
            this.pnlButtoni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtoni
            // 
            this.pnlButtoni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.pnlButtoni.Controls.Add(this.trakica);
            this.pnlButtoni.Controls.Add(this.pictureBox1);
            this.pnlButtoni.Controls.Add(this.btnLogout);
            this.pnlButtoni.Controls.Add(this.btnLijecnici);
            this.pnlButtoni.Controls.Add(this.btnLijekovi);
            this.pnlButtoni.Controls.Add(this.btnPacijenti);
            this.pnlButtoni.Controls.Add(this.btnPocetna);
            this.pnlButtoni.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtoni.Location = new System.Drawing.Point(0, 0);
            this.pnlButtoni.Name = "pnlButtoni";
            this.pnlButtoni.Size = new System.Drawing.Size(265, 644);
            this.pnlButtoni.TabIndex = 0;
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.Color.Transparent;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.ForeColor = System.Drawing.Color.White;
            this.btnPocetna.Image = ((System.Drawing.Image)(resources.GetObject("btnPocetna.Image")));
            this.btnPocetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.Location = new System.Drawing.Point(12, 128);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(233, 59);
            this.btnPocetna.TabIndex = 0;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.button1_Click_1);
            this.btnPocetna.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnPocetna.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btnPacijenti
            // 
            this.btnPacijenti.BackColor = System.Drawing.Color.Transparent;
            this.btnPacijenti.FlatAppearance.BorderSize = 0;
            this.btnPacijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacijenti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPacijenti.ForeColor = System.Drawing.Color.White;
            this.btnPacijenti.Image = ((System.Drawing.Image)(resources.GetObject("btnPacijenti.Image")));
            this.btnPacijenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacijenti.Location = new System.Drawing.Point(12, 196);
            this.btnPacijenti.Name = "btnPacijenti";
            this.btnPacijenti.Size = new System.Drawing.Size(233, 59);
            this.btnPacijenti.TabIndex = 1;
            this.btnPacijenti.Text = "Pacijenti";
            this.btnPacijenti.UseVisualStyleBackColor = false;
            this.btnPacijenti.Click += new System.EventHandler(this.button2_Click);
            this.btnPacijenti.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.btnPacijenti.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // btnLijekovi
            // 
            this.btnLijekovi.BackColor = System.Drawing.Color.Transparent;
            this.btnLijekovi.FlatAppearance.BorderSize = 0;
            this.btnLijekovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLijekovi.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLijekovi.ForeColor = System.Drawing.Color.White;
            this.btnLijekovi.Image = ((System.Drawing.Image)(resources.GetObject("btnLijekovi.Image")));
            this.btnLijekovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLijekovi.Location = new System.Drawing.Point(12, 264);
            this.btnLijekovi.Name = "btnLijekovi";
            this.btnLijekovi.Size = new System.Drawing.Size(233, 59);
            this.btnLijekovi.TabIndex = 2;
            this.btnLijekovi.Text = "Lijekovi";
            this.btnLijekovi.UseVisualStyleBackColor = false;
            this.btnLijekovi.Click += new System.EventHandler(this.button3_Click);
            this.btnLijekovi.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.btnLijekovi.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // btnLijecnici
            // 
            this.btnLijecnici.BackColor = System.Drawing.Color.Transparent;
            this.btnLijecnici.FlatAppearance.BorderSize = 0;
            this.btnLijecnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLijecnici.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLijecnici.ForeColor = System.Drawing.Color.White;
            this.btnLijecnici.Image = ((System.Drawing.Image)(resources.GetObject("btnLijecnici.Image")));
            this.btnLijecnici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLijecnici.Location = new System.Drawing.Point(12, 332);
            this.btnLijecnici.Name = "btnLijecnici";
            this.btnLijecnici.Size = new System.Drawing.Size(233, 59);
            this.btnLijecnici.TabIndex = 3;
            this.btnLijecnici.Text = "Liječnici";
            this.btnLijecnici.UseVisualStyleBackColor = false;
            this.btnLijecnici.Click += new System.EventHandler(this.button4_Click);
            this.btnLijecnici.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.btnLijecnici.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 585);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(265, 59);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedCare.Properties.Resources.MedCare_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // trakica
            // 
            this.trakica.BackColor = System.Drawing.Color.White;
            this.trakica.Location = new System.Drawing.Point(250, 128);
            this.trakica.Name = "trakica";
            this.trakica.Size = new System.Drawing.Size(12, 59);
            this.trakica.TabIndex = 5;
            // 
            // pnlGlavni
            // 
            this.pnlGlavni.Location = new System.Drawing.Point(271, 12);
            this.pnlGlavni.Name = "pnlGlavni";
            this.pnlGlavni.Size = new System.Drawing.Size(700, 620);
            this.pnlGlavni.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 644);
            this.Controls.Add(this.pnlGlavni);
            this.Controls.Add(this.pnlButtoni);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlButtoni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtoni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLijecnici;
        private System.Windows.Forms.Button btnLijekovi;
        private System.Windows.Forms.Button btnPacijenti;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Panel trakica;
        private System.Windows.Forms.Panel pnlGlavni;
    }
}