namespace MedCare
{
    partial class FrmGeneniraniRacun
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvRacun = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RacuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StavkeRacunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RacuniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StavkeRacunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvRacun
            // 
            this.rvRacun.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DsRacuni";
            reportDataSource6.Value = this.RacuniBindingSource;
            reportDataSource7.Name = "DsStavkeRacuna";
            reportDataSource7.Value = this.StavkeRacunaBindingSource;
            reportDataSource8.Name = "DsProizvodi";
            reportDataSource8.Value = this.ProizvodiBindingSource;
            reportDataSource9.Name = "DsPacijenti";
            reportDataSource9.Value = this.PacijentiBindingSource;
            reportDataSource10.Name = "DsZaposlenici";
            reportDataSource10.Value = this.ZaposleniciBindingSource;
            this.rvRacun.LocalReport.DataSources.Add(reportDataSource6);
            this.rvRacun.LocalReport.DataSources.Add(reportDataSource7);
            this.rvRacun.LocalReport.DataSources.Add(reportDataSource8);
            this.rvRacun.LocalReport.DataSources.Add(reportDataSource9);
            this.rvRacun.LocalReport.DataSources.Add(reportDataSource10);
            this.rvRacun.LocalReport.ReportEmbeddedResource = "MedCare.RacuniReport.rdlc";
            this.rvRacun.Location = new System.Drawing.Point(0, 0);
            this.rvRacun.Name = "rvRacun";
            this.rvRacun.ServerReport.BearerToken = null;
            this.rvRacun.Size = new System.Drawing.Size(1168, 706);
            this.rvRacun.TabIndex = 0;
            // 
            // RacuniBindingSource
            // 
            this.RacuniBindingSource.DataSource = typeof(MedCare.Racuni);
            // 
            // StavkeRacunaBindingSource
            // 
            this.StavkeRacunaBindingSource.DataSource = typeof(MedCare.StavkeRacuna);
            // 
            // ProizvodiBindingSource
            // 
            this.ProizvodiBindingSource.DataSource = typeof(MedCare.Proizvodi);
            // 
            // PacijentiBindingSource
            // 
            this.PacijentiBindingSource.DataSource = typeof(MedCare.Pacijenti);
            // 
            // ZaposleniciBindingSource
            // 
            this.ZaposleniciBindingSource.DataSource = typeof(MedCare.Zaposlenici);
            // 
            // FrmGeneniraniRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 706);
            this.Controls.Add(this.rvRacun);
            this.Name = "FrmGeneniraniRacun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generiranje računa";
            this.Load += new System.EventHandler(this.FrmGeneniraniRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RacuniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StavkeRacunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposleniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvRacun;
        private System.Windows.Forms.BindingSource RacuniBindingSource;
        private System.Windows.Forms.BindingSource StavkeRacunaBindingSource;
        private System.Windows.Forms.BindingSource ProizvodiBindingSource;
        private System.Windows.Forms.BindingSource PacijentiBindingSource;
        private System.Windows.Forms.BindingSource ZaposleniciBindingSource;
    }
}