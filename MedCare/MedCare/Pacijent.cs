using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class Pacijent : Osoba
    {
        private List<Bolest> povijestBolesti = new List<Bolest>();
        private Zaposlenik liječnik { get; set; }
    }
}
