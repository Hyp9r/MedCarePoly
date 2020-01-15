using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MedCare
{
    public partial class ucPocetna : UserControl
    {
        private static ucPocetna _instance;
        List<NarudzbaKartica> listaKartica = new List<NarudzbaKartica>();
        UpravljanjeNarudzbama upravljanjeNarudzbama = new UpravljanjeNarudzbama();

        public static ucPocetna Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ucPocetna();
                }

                return _instance;
            }
        }

        public ucPocetna()
        {
            InitializeComponent();
            ocisti();
            postaviVrijednosti();
        }

        public void osvjezi()
        {
            ocisti();
            postaviVrijednosti();
        }

        private void ucPocetna_Load(object sender, EventArgs e)
        {
            ocisti();
            postaviVrijednosti();
        }

        private Boolean isCardPanelEmpty()
        {
            if (listaKartica.Count == 0)
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDodajNarudzbu frmDodajNarudzbu = new FrmDodajNarudzbu();
            frmDodajNarudzbu.Show();
        }

        private void btn_pregled_svih_narudzbi_Click(object sender, EventArgs e)
        {
            //dohvati sve narudžbe i prikazi ih u novoj formi
            ocisti();
            List<NarudzbaKartica> listaNarudzbi = upravljanjeNarudzbama.GenerirajKartice();
            foreach (var item in listaNarudzbi)
            {
                card_panel.Controls.Add(item);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ocisti();
            postaviVrijednosti();
        }

        private void postaviVrijednosti()
        {
            List<NarudzbaKartica> listaNarudzbi = upravljanjeNarudzbama.GenerirajKartice(getDateTimeFromCalendar());
            foreach (var item in listaNarudzbi)
            {
                card_panel.Controls.Add(item);
            }
        }

        private DateTime getDateTimeFromCalendar()
        {
            return monthCalendar1.SelectionRange.Start;
        }

        private void ocisti()
        {
            card_panel.Controls.Clear();
        }
    }
}
