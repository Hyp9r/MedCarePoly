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
    public partial class FrmDodajNarudzbu : Form
    {

        private Boolean Update;
        private int id;

        public FrmDodajNarudzbu()
        {
            InitializeComponent();
            Update = false;
        }

        public FrmDodajNarudzbu(int id)
        {
            InitializeComponent();
            this.id = id;
            Update = true;
            PopuniFormu();
        }

        UpravljanjePacijentima upravljanjePacijentima = new UpravljanjePacijentima();
        UpravljanjeNarudzbama upravljanjeNarudzbama = new UpravljanjeNarudzbama();

        private void PopuniFormu()
        {
            Narudžbe narudzba;
            using (var db = new MedCareEntities())
            {
                var query = (from n in db.Narudžbe where n.Id == this.id select n);
                narudzba = query.FirstOrDefault();
            }

            richTextBox1.Text = narudzba.Napomena;
            dateTimePicker2.Value = narudzba.Datum;
            cmb_Pacijent.Hide();
            label2.Hide();
        }

        private void FrmDodajNarudzbu_Load(object sender, EventArgs e)
        {
            cmb_Pacijent.DataSource = upravljanjePacijentima.DohvatiPacijente(FrmMain.zaposlenik);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datumNarudzbe = dateTimePicker2.Value;
            string napomena = richTextBox1.Text;

            if (Update)
            {
                upravljanjeNarudzbama.UpdateNarudzbu(this.id, datumNarudzbe, napomena);
            }
            else
            {
                Pacijenti pacijent = cmb_Pacijent.SelectedItem as Pacijenti;
                Zaposlenici zaposlenik = FrmMain.zaposlenik;
                upravljanjeNarudzbama.DodajNarudzbu(datumNarudzbe, pacijent.Id, zaposlenik.Id, napomena);
            }
            ucPocetna.Instance.osvjezi();
            this.Close();
        }
    }
}
