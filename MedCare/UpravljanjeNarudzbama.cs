using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace MedCare
{
    public class UpravljanjeNarudzbama
    {

        public List<Narudžbe> DohvatiNarudzbe()
        {
            List<Narudžbe> listaNarudzbi = new List<Narudžbe>();
            using (var db = new MedCareEntities())
            {
                var queryNarudzbe = from n in db.Narudžbe select n;

                listaNarudzbi = queryNarudzbe.ToList();
            }

            return listaNarudzbi;
        }

        public List<Narudžbe> DohvatiNarudzbe(DateTime zaDatum)
        {
            List<Narudžbe> listaNarudzbi = new List<Narudžbe>();
            using (var db = new MedCareEntities())
            {
                var queryNarudzbe = from n in db.Narudžbe where System.Data.Entity.DbFunctions.TruncateTime(n.Datum) == System.Data.Entity.DbFunctions.TruncateTime(zaDatum) select n;

                listaNarudzbi = queryNarudzbe.ToList();
            }

            return listaNarudzbi;
        }

        public List<NarudzbaKartica> GenerirajKartice(DateTime zaDatum)
        {
            List<NarudzbaKartica> listaKartica = new List<NarudzbaKartica>();
            List<Narudžbe> listaNarudzbi = DohvatiNarudzbe(zaDatum);
            UpravljanjePacijentima upravljanjePacijentima = new UpravljanjePacijentima();
            UpravljanjeZaposlenicima upravljanjeZaposlenicima = new UpravljanjeZaposlenicima();
            foreach (var item in listaNarudzbi)
            {
                int pacijentID = item.PacijentiId;
                int zaposlenikID = item.ZaposleniciId;
                string napomena = item.Napomena;
                DateTime datum = item.Datum;
                Pacijenti pacijent = upravljanjePacijentima.TraziPacijenta(pacijentID);
                Zaposlenici zaposlenik = upravljanjeZaposlenicima.TraziZaposlenika(zaposlenikID);
                string ime_i_prezime_pacijenta = pacijent.Ime + " " + pacijent.Prezime;
                string ime_i_prezime_zaposlenika = zaposlenik.Ime + " " + zaposlenik.Prezime;
                NarudzbaKartica kartica = new NarudzbaKartica(item.Id, ime_i_prezime_pacijenta, ime_i_prezime_zaposlenika, napomena, datum.ToShortDateString());
                listaKartica.Add(kartica);
            }
            return listaKartica;
        }

        public List<NarudzbaKartica> GenerirajKartice()
        {
            List<NarudzbaKartica> listaKartica = new List<NarudzbaKartica>();
            List<Narudžbe> listaNarudzbi = DohvatiNarudzbe();
            UpravljanjePacijentima upravljanjePacijentima = new UpravljanjePacijentima();
            UpravljanjeZaposlenicima upravljanjeZaposlenicima = new UpravljanjeZaposlenicima();
            foreach (var item in listaNarudzbi)
            {
                int pacijentID = item.PacijentiId;
                int zaposlenikID = item.ZaposleniciId;
                string napomena = item.Napomena;
                DateTime datum = item.Datum;
                Pacijenti pacijent = upravljanjePacijentima.TraziPacijenta(pacijentID);
                Zaposlenici zaposlenik = upravljanjeZaposlenicima.TraziZaposlenika(zaposlenikID);
                string ime_i_prezime_pacijenta = pacijent.Ime + " " + pacijent.Prezime;
                string ime_i_prezime_zaposlenika = zaposlenik.Ime + " " + zaposlenik.Prezime;
                NarudzbaKartica kartica = new NarudzbaKartica(item.Id, ime_i_prezime_pacijenta, ime_i_prezime_zaposlenika, napomena, datum.ToShortDateString());
                listaKartica.Add(kartica);
            }
            return listaKartica;
        }

        public void DodajNarudzbu(DateTime datum, int pacijentID, int lijecnikID, string napomena)
        {
            using (var db = new MedCareEntities())
            {
                Narudžbe narudzba = new Narudžbe
                {
                    Datum = datum,
                    PacijentiId = pacijentID,
                    Napomena = napomena,
                    ZaposleniciId = lijecnikID,
                };

                db.Narudžbe.Add(narudzba);
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno ste dodali novu narudžbu!");
        }


        public void ObrisiNarudzbu(int narudzbaID)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                using (var db = new MedCareEntities())
                {
                    var deleteQuery = (from n in db.Narudžbe where n.Id == narudzbaID select n).FirstOrDefault();
                    db.Narudžbe.Remove(deleteQuery);
                    db.SaveChanges();
                }
                MessageBox.Show("Uspješno ste obrisali označenu narudžbu!");
                }
        }

        public void UpdateNarudzbu(int narudzbaID, DateTime datum, string napomena)
        {
            Narudžbe narudzba;
            using(var db = new MedCareEntities())
            {
                var query = (from n in db.Narudžbe where n.Id == narudzbaID select n);
                narudzba = query.SingleOrDefault();
                narudzba.Datum = datum;
                narudzba.Napomena = napomena;

                db.SaveChanges();
            }
        }






    }
}
