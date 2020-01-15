namespace MedCare
{
    partial class NarudzbaKartica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NarudzbaKartica));
            this.lbl_ime_i_prezime = new System.Windows.Forms.Label();
            this.lbl_pacijent = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.lbl_napomena = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ime_i_prezime
            // 
            this.lbl_ime_i_prezime.AutoSize = true;
            this.lbl_ime_i_prezime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ime_i_prezime.Location = new System.Drawing.Point(217, 135);
            this.lbl_ime_i_prezime.Name = "lbl_ime_i_prezime";
            this.lbl_ime_i_prezime.Size = new System.Drawing.Size(126, 22);
            this.lbl_ime_i_prezime.TabIndex = 0;
            this.lbl_ime_i_prezime.Text = "ime i prezime";
            // 
            // lbl_pacijent
            // 
            this.lbl_pacijent.AutoSize = true;
            this.lbl_pacijent.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_pacijent.Location = new System.Drawing.Point(70, 19);
            this.lbl_pacijent.Name = "lbl_pacijent";
            this.lbl_pacijent.Size = new System.Drawing.Size(83, 22);
            this.lbl_pacijent.TabIndex = 1;
            this.lbl_pacijent.Text = "Pacijent";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_datum.Location = new System.Drawing.Point(428, 139);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(69, 19);
            this.lbl_datum.TabIndex = 2;
            this.lbl_datum.Text = "7.9.2019.";
            // 
            // lbl_napomena
            // 
            this.lbl_napomena.AutoSize = true;
            this.lbl_napomena.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_napomena.Location = new System.Drawing.Point(70, 63);
            this.lbl_napomena.Name = "lbl_napomena";
            this.lbl_napomena.Size = new System.Drawing.Size(88, 19);
            this.lbl_napomena.TabIndex = 3;
            this.lbl_napomena.Text = "napomena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(70, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naručen kod: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Image = ((System.Drawing.Image)(resources.GetObject("delete_button.Image")));
            this.delete_button.Location = new System.Drawing.Point(757, 85);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(50, 82);
            this.delete_button.TabIndex = 6;
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_button.Image")));
            this.edit_button.Location = new System.Drawing.Point(757, 0);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(50, 82);
            this.edit_button.TabIndex = 7;
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // NarudzbaKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_napomena);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_pacijent);
            this.Controls.Add(this.lbl_ime_i_prezime);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "NarudzbaKartica";
            this.Size = new System.Drawing.Size(807, 167);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ime_i_prezime;
        private System.Windows.Forms.Label lbl_pacijent;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_napomena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
    }
}
