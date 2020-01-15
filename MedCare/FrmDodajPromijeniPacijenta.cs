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
    public partial class FrmDodajPromijeniPacijenta : Form
    {
        public FrmDodajPromijeniPacijenta()
        {
            InitializeComponent();
        }

        UpravljanjeZaposlenicima upravljanjeZaposlenicima = new UpravljanjeZaposlenicima();
        UpravljanjePacijentima upravljanjePacijentima = new UpravljanjePacijentima();

        private void FrmDodajPromijeniPacijenta_Load(object sender, EventArgs e)
        {
            cmbLijecnik.DataSource = upravljanjeZaposlenicima.DohvatiLijecnikeOpcePrakse();
            cmbStomatolog.DataSource = upravljanjeZaposlenicima.DohvatiSveStomatologe();
        }

        private void btnSpremiPacijenta_Click(object sender, EventArgs e)
        {
            Zaposlenici lijecnik = cmbLijecnik.SelectedItem as Zaposlenici;
            Zaposlenici stomatolog = cmbStomatolog.SelectedItem as Zaposlenici;

            upravljanjePacijentima.DodajPacijenta(txtOib.Text, txtIme.Text, txtPrezime.Text, DateTime.Parse(dtpDatumRodenja.Text), txtAdresa.Text, txtKontakt.Text, txtEmail.Text, cmbSpol.Text, lijecnik.Id, stomatolog.Id);
            ucPacijenti.Instance.PrikaziListuPacijenata();
        }
    }
}