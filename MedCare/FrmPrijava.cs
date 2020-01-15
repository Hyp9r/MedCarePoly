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
    public partial class FrmPrijava : Form
    {
        Prijava prijava = new Prijava();

        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Zaposlenici prijavljeniZaposlenik = prijava.ProvjeraZaposlenika(txtKorisnickoIme.Text, txtLozinka.Text);

            if(prijavljeniZaposlenik != null)
            {
                FrmMain frmMain = new FrmMain(prijavljeniZaposlenik);
                frmMain.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Krivi podaci za prijavu!");
            }
        }

        private void FrmPrijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
