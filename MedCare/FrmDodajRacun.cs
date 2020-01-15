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
    public partial class FrmDodajRacun : Form
    {

        private Pacijenti izdajeSePacijentu { get; set; }
        private Zaposlenici izdajeLijecnik { get; set; }

        UpravljanjeRacunima upravljanjeRacunima = new UpravljanjeRacunima();

        public FrmDodajRacun()
        {
            InitializeComponent();
            izdajeSePacijentu = ucPacijenti.Instance.selektiraniPacijent;
            izdajeLijecnik = FrmMain.zaposlenik;
        }

        private void FrmDodajRacun_Load(object sender, EventArgs e)
        {
            lblTrenutniDatumRacuna.Text = DateTime.Now.ToShortDateString();
            lblIzdaoLijecnik.Text = izdajeLijecnik.Ime + " " + izdajeLijecnik.Prezime;
            lblIzdajePacijentu.Text = izdajeSePacijentu.Ime + " " + izdajeSePacijentu.Prezime;

            PopuniProizvode();
        }

        private void PopuniProizvode()
        {
            dgvProizvodi.DataSource = null;
            dgvProizvodi.AutoGenerateColumns = false;
            dgvProizvodi.DataSource = upravljanjeRacunima.DohvatiSveProizvode();
        }

        private void btnSpremiRacun_Click(object sender, EventArgs e)
        {
            decimal ukupanIznos = 0;
            List<Proizvodi> oznaceniProizvodi = new List<Proizvodi>();
            List<decimal> kolicinaProizvoda = new List<decimal>();

            foreach (DataGridViewRow row in dgvProizvodi.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Dodaj"];
                if (chk.Value == chk.TrueValue)
                {
                    //MessageBox.Show("Not Checked!");
                }
                else
                {
                    //MessageBox.Show("Checked!");
                    var trenutniProizvod = row.DataBoundItem as Proizvodi;

                    decimal cijena = Convert.ToDecimal(row.Cells[2].Value);
                    decimal kolicina = Convert.ToDecimal(row.Cells[3].Value);
                    ukupanIznos += cijena * kolicina;
                    oznaceniProizvodi.Add(trenutniProizvod);
                    kolicinaProizvoda.Add(kolicina);
                }

                lblTrenutniIznos.Text = ukupanIznos.ToString();
            }

            using (var db = new MedCareEntities())
            {
                Racuni noviRacun = new Racuni
                {
                    Datum = DateTime.Parse(DateTime.Now.ToShortDateString()),
                    PacijentiId = izdajeSePacijentu.Id,
                    ZaposleniciId = izdajeLijecnik.Id,
                    Iznos = ukupanIznos
                };

                db.Racuni.Add(noviRacun);
                db.SaveChanges();

                foreach (var proizvod in oznaceniProizvodi)
                {
                    StavkeRacuna novaStavka = new StavkeRacuna
                    {
                        RačuniId = noviRacun.Id,
                        ProizvodiId = proizvod.Id
                    };

                    db.StavkeRacuna.Add(novaStavka);
                    db.SaveChanges();
                }
            }

            ucPacijenti.Instance.PrikaziRacune();
            MessageBox.Show("Uspješno ste dodali novi račun!");
        }
    }
}