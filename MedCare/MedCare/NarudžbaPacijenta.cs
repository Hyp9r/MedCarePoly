using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class NarudžbaPacijenta
    {
        private DateTime datumVrijeme { get; set; }
        private Zaposlenik liječnik { get; set; }
        private Pacijent pacijent { get; set; }
        private string opis { get; set; }
    }
}
