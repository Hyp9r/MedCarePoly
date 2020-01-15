using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public class UpravljanjeZaposlenicima
    {
        public List<Zaposlenici> DohvatiLijecnikeOpcePrakse()
        {
            List<Zaposlenici> lijecnikOpcePrakse = new List<Zaposlenici>();
            using (var db = new MedCareEntities())
            {
                var queryLijecnikOpcePrakse = from z in db.Zaposlenici
                                              where z.TipZaposlenikaId == 1 && z.RadnoMjestoId == 1
                                              select z;

                lijecnikOpcePrakse = queryLijecnikOpcePrakse.ToList();
            }

            return lijecnikOpcePrakse;
        }

        public List<Zaposlenici> DohvatiSveZaposlenike()
        {
            List<Zaposlenici> zaposlenici = new List<Zaposlenici>();
            using (var db = new MedCareEntities())
            {
                var query = from z in db.Zaposlenici select z;

                zaposlenici = query.ToList();
            }

            return zaposlenici;
        }

        public void DodajZaposlenika(string oib, string ime, string prezime, DateTime datumRodenja, string adresa, string kontakt, string email, string spol, string korisnickoIme, string lozinka, int tipZaposlenikaID, int radnoMjestoID)
        {
            using(var db = new MedCareEntities())
            {
                Zaposlenici zaposlenik = new Zaposlenici
                {
                    Oib = oib,
                    Ime = ime,
                    Prezime = prezime,
                    DatumRođenja = datumRodenja,
                    Adresa = adresa,
                    Kontakt = kontakt,
                    Email = email,
                    Spol = spol,
                    KorisnickoIme = korisnickoIme,
                    Lozinka = lozinka,
                    TipZaposlenikaId = tipZaposlenikaID,
                    RadnoMjestoId = radnoMjestoID
                };

                db.Zaposlenici.Add(zaposlenik);
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno ste dodali novog zaposlenika!");
        }

        public List<Zaposlenici> DohvatiSveStomatologe()
        {
            List<Zaposlenici> sviStomatolozi = new List<Zaposlenici>();
            using (var db = new MedCareEntities())
            {
                var querySviStomatolozi = from z in db.Zaposlenici
                                          where z.TipZaposlenikaId == 1 && z.RadnoMjestoId == 2
                                          select z;

                sviStomatolozi = querySviStomatolozi.ToList();
            }

            return sviStomatolozi;
        }

        public Zaposlenici TraziZaposlenika(int zaposlenikID)
        {
            Zaposlenici zaposlenik;
            using (var db = new MedCareEntities())
            {
                var queryTrazeniZaposlenik = from z in db.Zaposlenici
                                           where z.Id == zaposlenikID
                                           select z;

                zaposlenik = queryTrazeniZaposlenik.ToList().Last();
            }

            return zaposlenik;
        }

        public void ObrisiZaposlenika(Zaposlenici selektiraniZaposlenik)
        {
            if (selektiraniZaposlenik != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new MedCareEntities())
                    {
                        db.Zaposlenici.Attach(selektiraniZaposlenik);
                        db.Zaposlenici.Remove(selektiraniZaposlenik);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Uspješno ste obrisali označenog zaposlenika!");
                }
            }
        }


    }
}
