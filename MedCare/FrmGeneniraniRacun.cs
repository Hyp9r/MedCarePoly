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
    public partial class FrmGeneniraniRacun : Form
    {
        private Racuni selektiraniRacun { get; set; }

        public FrmGeneniraniRacun(Racuni odabraniRacun)
        {
            InitializeComponent();
            selektiraniRacun = odabraniRacun;
        }

        private void FrmGeneniraniRacun_Load(object sender, EventArgs e)
        {
            using (var db = new MedCareEntities())
            {
                var queryRacuni = from r in db.Racuni
                                  where r.Id == selektiraniRacun.Id
                                  select r;

                Racuni racun = queryRacuni.Single();
                RacuniBindingSource.DataSource = racun;

                var queryZaposlenici = from z in db.Zaposlenici
                                       where z.Id == selektiraniRacun.ZaposleniciId
                                       select z;

                Zaposlenici zaposlenik = queryZaposlenici.Single();
                ZaposleniciBindingSource.DataSource = zaposlenik;

                var queryPacijenti = from p in db.Pacijenti
                                     where p.Id == selektiraniRacun.PacijentiId
                                     select p;

                Pacijenti pacijent = queryPacijenti.Single();
                PacijentiBindingSource.DataSource = pacijent;

                var queryProizvodi = from s in db.StavkeRacuna
                                     join pr in db.Proizvodi
                                     on s.ProizvodiId equals pr.Id
                                     where selektiraniRacun.Id == s.RačuniId
                                     select pr;

                List<Proizvodi> sviProizvodi = queryProizvodi.ToList();
                ProizvodiBindingSource.DataSource = sviProizvodi;  
            }

            this.rvRacun.RefreshReport();
        }
    }
}
