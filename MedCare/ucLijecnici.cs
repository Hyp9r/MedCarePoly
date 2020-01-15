using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public partial class ucLijecnici : UserControl
    {

        private static ucLijecnici _instance;
        private UpravljanjeZaposlenicima upravljanjeZaposlenicima = new UpravljanjeZaposlenicima();
        public Zaposlenici selektiraniZaposlenik { get; set; }

        public static ucLijecnici Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucLijecnici();
                }

                return _instance;
            }
        }


        public ucLijecnici()
        {
            InitializeComponent();
            PrikaziListuZaposlenika();
        }

        public void PrikaziListuZaposlenika()
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            List<Zaposlenici> listaZaposlenika = new List<Zaposlenici>();
            listaZaposlenika = upravljanjeZaposlenicima.DohvatiSveZaposlenike();
            dataGridView1.DataSource = listaZaposlenika;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //obrisi zaposlenika
            UpravljanjeZaposlenicima upravljanjeZaposlenicima = new UpravljanjeZaposlenicima();
            upravljanjeZaposlenicima.ObrisiZaposlenika(selektiraniZaposlenik);
            PrikaziListuZaposlenika();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dodaj zaposlenika
            FrmDodajPromijeniZaposlenika frmDodajPromijeniZaposlenika = new FrmDodajPromijeniZaposlenika();
            frmDodajPromijeniZaposlenika.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selektiraniZaposlenik = dataGridView1.CurrentRow.DataBoundItem as Zaposlenici;
        }

        private void ucLijecnici_Load(object sender, EventArgs e)
        {
            PrikaziListuZaposlenika();
        }
    }
}
