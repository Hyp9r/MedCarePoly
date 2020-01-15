namespace MedCare
{
    partial class ucPocetna
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.card_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_dodaj_narudzbu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pregled_svih_narudzbi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.monthCalendar1.Location = new System.Drawing.Point(920, 71);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // card_panel
            // 
            this.card_panel.AutoScroll = true;
            this.card_panel.Location = new System.Drawing.Point(14, 71);
            this.card_panel.Name = "card_panel";
            this.card_panel.Size = new System.Drawing.Size(852, 519);
            this.card_panel.TabIndex = 1;
            // 
            // btn_dodaj_narudzbu
            // 
            this.btn_dodaj_narudzbu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btn_dodaj_narudzbu.FlatAppearance.BorderSize = 0;
            this.btn_dodaj_narudzbu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.btn_dodaj_narudzbu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(230)))), ((int)(((byte)(115)))));
            this.btn_dodaj_narudzbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dodaj_narudzbu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj_narudzbu.ForeColor = System.Drawing.Color.White;
            this.btn_dodaj_narudzbu.Location = new System.Drawing.Point(237, 610);
            this.btn_dodaj_narudzbu.Name = "btn_dodaj_narudzbu";
            this.btn_dodaj_narudzbu.Size = new System.Drawing.Size(301, 84);
            this.btn_dodaj_narudzbu.TabIndex = 2;
            this.btn_dodaj_narudzbu.Text = "Dodaj narudžbu";
            this.btn_dodaj_narudzbu.UseVisualStyleBackColor = false;
            this.btn_dodaj_narudzbu.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sljedeće narudžbe";
            // 
            // btn_pregled_svih_narudzbi
            // 
            this.btn_pregled_svih_narudzbi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btn_pregled_svih_narudzbi.FlatAppearance.BorderSize = 0;
            this.btn_pregled_svih_narudzbi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.btn_pregled_svih_narudzbi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(230)))), ((int)(((byte)(115)))));
            this.btn_pregled_svih_narudzbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pregled_svih_narudzbi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pregled_svih_narudzbi.ForeColor = System.Drawing.Color.White;
            this.btn_pregled_svih_narudzbi.Location = new System.Drawing.Point(565, 610);
            this.btn_pregled_svih_narudzbi.Name = "btn_pregled_svih_narudzbi";
            this.btn_pregled_svih_narudzbi.Size = new System.Drawing.Size(301, 84);
            this.btn_pregled_svih_narudzbi.TabIndex = 4;
            this.btn_pregled_svih_narudzbi.Text = "Pregled svih narudžbi";
            this.btn_pregled_svih_narudzbi.UseVisualStyleBackColor = false;
            this.btn_pregled_svih_narudzbi.Click += new System.EventHandler(this.btn_pregled_svih_narudzbi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(912, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum:";
            // 
            // ucPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pregled_svih_narudzbi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dodaj_narudzbu);
            this.Controls.Add(this.card_panel);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "ucPocetna";
            this.Size = new System.Drawing.Size(1258, 725);
            this.Load += new System.EventHandler(this.ucPocetna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel card_panel;
        private System.Windows.Forms.Button btn_dodaj_narudzbu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pregled_svih_narudzbi;
        private System.Windows.Forms.Label label2;
    }
}
