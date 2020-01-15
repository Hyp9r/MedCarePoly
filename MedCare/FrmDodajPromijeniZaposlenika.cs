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
    public partial class FrmDodajPromijeniZaposlenika : Form
    {
        public FrmDodajPromijeniZaposlenika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpravljanjeZaposlenicima upravljanjeZaposlenicima = new UpravljanjeZaposlenicima();
            upravljanjeZaposlenicima.DodajZaposlenika(txtOIB.Text, txtIME.Text, txtPREZIME.Text, DateTime.Parse(dateTimePicker1.Text),
                txtADRESA.Text, txtKONTAKT.Text, txtEMAIL.Text, cmbSPOL.Text, txtKORISNICKO.Text, txtLOZINKA.Text,
                int.Parse(txtTIPZAPOSLENIKA.Text), int.Parse(txtRADNO.Text));
            ucLijecnici.Instance.PrikaziListuZaposlenika();
        }
    }
}
