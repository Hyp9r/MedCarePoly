using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public class UpravljanjeRacunima
    {
        public List<Racuni> DohvatiRacune(Pacijenti selektiraniPacijent)
        {
            List<Racuni> sviRacuni = new List<Racuni>();
            try
            {
                using (var db = new MedCareEntities())
                {
                    var querySviRacuni = from r in db.Racuni
                                         where r.PacijentiId == selektiraniPacijent.Id
                                         select r;

                    sviRacuni = querySviRacuni.ToList();
                }

                return sviRacuni;
            }
            catch(Exception e)
            {
                MessageBox.Show("Trenutni doktor nema dodanih pacijenata!" + "\nError: " + e.Message);
            }
            return sviRacuni;
            
        }

        public List<Proizvodi> DohvatiSveProizvode()
        {
            List<Proizvodi> sviProizvodi = new List<Proizvodi>();
            using (var db = new MedCareEntities())
            {
                var querySviProizvodi = from p in db.Proizvodi
                                        select p;

                sviProizvodi = querySviProizvodi.ToList();
            }

            return sviProizvodi;
        }

        public void ObrisiPacijenta(Pacijenti selektiraniPacijent)
        {
            if (selektiraniPacijent != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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

        public void ObrisiRacun(Racuni selektiraniRacun)
        {
            if (selektiraniRacun != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new MedCareEntities())
                    {
                        db.Racuni.Attach(selektiraniRacun);
                        db.Racuni.Remove(selektiraniRacun);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Uspješno ste obrisali označeni račun!");
                }
            }
        }
    }
}
