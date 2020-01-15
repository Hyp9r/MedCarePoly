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
    public partial class NarudzbaKartica : UserControl
    {
        public int ID { get; set; }

        public NarudzbaKartica()
        {
            InitializeComponent();
        }

        public NarudzbaKartica(int id, string ime_i_prezime_pacijenta, string ime_i_prezime_liječnika, string napomena, string datum)
        {
            InitializeComponent();
            ID = id;
            lbl_pacijent.Text = ime_i_prezime_pacijenta;
            lbl_ime_i_prezime.Text = ime_i_prezime_liječnika;
            lbl_napomena.Text = napomena;
            lbl_datum.Text = datum;
        }

        public NarudzbaKartica(Narudžbe narudžbe)
        {
            InitializeComponent();
            lbl_pacijent.Text = narudžbe.Pacijenti.Ime + " " + narudžbe.Pacijenti.Prezime;
            lbl_ime_i_prezime.Text = narudžbe.Zaposlenici.Ime + " " + narudžbe.Zaposlenici.Prezime;
            lbl_napomena.Text = narudžbe.Napomena;
            lbl_datum.Text = narudžbe.Datum.ToShortDateString();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            //button koji sluzi za editiranje narudžbe
            FrmDodajNarudzbu frmDodajNarudzbu = new FrmDodajNarudzbu(ID);
            frmDodajNarudzbu.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            UpravljanjeNarudzbama upravljanjeNarudzbama = new UpravljanjeNarudzbama();
            upravljanjeNarudzbama.ObrisiNarudzbu(ID);
            ucPocetna.Instance.osvjezi();
        }
    }
}
