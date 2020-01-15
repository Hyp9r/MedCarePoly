using MedCare.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public partial class FrmMain : Form
    {

        public static Zaposlenici zaposlenik { get; set; }

        public FrmMain(Zaposlenici prijavljeniZaposlenik)
        {
            InitializeComponent();

            lblImePrezimeZaposlenika.Text = prijavljeniZaposlenik.Ime + " " + prijavljeniZaposlenik.Prezime;
            ProvjeraSpolaZaposlenika(prijavljeniZaposlenik);
            zaposlenik = prijavljeniZaposlenik;


            if (!pnlMainView.Controls.Contains(ucPocetna.Instance))
            {
                pnlMainView.Controls.Add(ucPocetna.Instance);
                ucPocetna.Instance.Dock = DockStyle.Fill;
                ucPocetna.Instance.BringToFront();
            }
            else
            {
                ucPocetna.Instance.osvjezi();
                ucPocetna.Instance.BringToFront();
            }


        }

        private void ProvjeraSpolaZaposlenika(Zaposlenici prijavljeniZaposlenik)
        {
            if(prijavljeniZaposlenik.Spol == "M")
            {
                pbAvatar.Image = Resources.icons8_male_user_48;
            }
            else
            {
                pbAvatar.Image = Resources.icons8_female_profile_48;
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FrmPrijava frmPrijava = new FrmPrijava();

            this.Hide();
            frmPrijava.Show();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            if (!pnlMainView.Controls.Contains(ucPocetna.Instance))
            {
                pnlMainView.Controls.Add(ucPocetna.Instance);
                ucPocetna.Instance.Dock = DockStyle.Fill;
                ucPocetna.Instance.BringToFront();
            }
            else
            {
                ucPocetna.Instance.osvjezi();
                ucPocetna.Instance.BringToFront();
            }
        }

        private void btnPacijenti_Click(object sender, EventArgs e)
        {
            if (!pnlMainView.Controls.Contains(ucPacijenti.Instance))
            {
                pnlMainView.Controls.Add(ucPacijenti.Instance);
                ucPacijenti.Instance.Dock = DockStyle.Fill;
                ucPacijenti.Instance.BringToFront();
            }
            else
            {
                ucPacijenti.Instance.BringToFront();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            if (!pnlMainView.Controls.Contains(ucLijecnici.Instance))
            {
                pnlMainView.Controls.Add(ucLijecnici.Instance);
                ucLijecnici.Instance.Dock = DockStyle.Fill;
                ucLijecnici.Instance.BringToFront();
                ucLijecnici.Instance.PrikaziListuZaposlenika();
            }
            else
            {
                ucLijecnici.Instance.BringToFront();
            }
        }
    }
}
