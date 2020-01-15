using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class Zaposlenik : Osoba
    {
        private string šifra { get; set; }
        private RadnoMjesto radnoMjesto { get; set; }
        private TipZaposlenika tipZaposlenika { get; set; }
        private bool aktivan { get; set; }
        private string korisnickoIme { get; set; }
        private string lozinka { get; set; } //razmisli jel nam to treba
        private List<string> listaPacijenata = new List<string>();
    }
}
