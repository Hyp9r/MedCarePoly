using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class Prijava
    {
        public Zaposlenici ProvjeraZaposlenika(string korisnickoIme, string lozinka)
        {

            Zaposlenici prijavljeniZaposlenik = new Zaposlenici();

            using (var db = new MedCareEntities())
            {
                var queryZaposlenici = from z in db.Zaposlenici
                                       where z.KorisnickoIme == korisnickoIme && z.Lozinka == lozinka
                                       select z;

                prijavljeniZaposlenik = queryZaposlenici.FirstOrDefault();

                return prijavljeniZaposlenik;
            }
        }
    }
}
