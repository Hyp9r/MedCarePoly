using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public class UpravljanjePacijentima
    {
        public List<Pacijenti> DohvatiPacijente(Zaposlenici prijavljeniZaposlenik)
        {
            List<Pacijenti> listaPacijenata = new List<Pacijenti>();

            using (var db = new MedCareEntities())
            {
                var queryPacijenti = from p in db.Pacijenti
                                     where p.ZaposleniciId == prijavljeniZaposlenik.Id
                                     select p;

                listaPacijenata = queryPacijenti.ToList();
            }

            return listaPacijenata;
        }

        public List<Pacijenti> DohvatiPacijente()
        {
            List<Pacijenti> listaPacijenata = new List<Pacijenti>();

            using (var db = new MedCareEntities())
            {
                var queryPacijenti = from p in db.Pacijenti select p;

                listaPacijenata = queryPacijenti.ToList();
            }

            return listaPacijenata;
        }


        public List<Pacijenti> TraziPacijenta(string trazeniPacijent)
        {
            List<Pacijenti> trazeniPacijenti = new List<Pacijenti>();
            using (var db = new MedCareEntities())
            {
                var queryTrazeniPacijent = from p in db.Pacijenti
                                           where p.Prezime == trazeniPacijent
                                           select p;

                trazeniPacijenti = queryTrazeniPacijent.ToList();
            }

            return trazeniPacijenti;
        }

        public Pacijenti TraziPacijenta(int pacijentID)
        {
            Pacijenti pacijent;
            using (var db = new MedCareEntities())
            {
                var queryTrazeniPacijent = from p in db.Pacijenti
                                           where p.Id == pacijentID
                                           select p;

                pacijent = queryTrazeniPacijent.ToList().Last();
            }

            return pacijent;
        }

        public void DodajPacijenta(string oib, string ime, string prezime, DateTime datumRodenja, string adresa, string kontakt, string email, string spol, int lijecnikID, int stomatologID)
        {
            using (var db = new MedCareEntities())
            {
                Pacijenti pacijent = new Pacijenti
                {
                    Oib = oib,
                    Ime = ime,
                    Prezime = prezime,
                    DatumRođenja = datumRodenja,
                    Adresa = adresa,
                    Kontakt = kontakt,
                    Email = email,
                    Spol = spol,
                    ZaposleniciId = lijecnikID,
                    ZaposleniciIdStomatolog = stomatologID
                };

                db.Pacijenti.Add(pacijent);
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno ste dodali novog pacijenta!");
        }

        public void ObrisiPacijenta(Pacijenti selektiraniPacijent)
        {
            if(selektiraniPacijent != null)
            {
                if(MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new MedCareEntities())
                    {
                        db.Pacijenti.Attach(selektiraniPacijent);
                        db.Pacijenti.Remove(selektiraniPacijent);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Uspješno ste obrisali označenog pacijenta!");
                }
            }
        }
    }
}
