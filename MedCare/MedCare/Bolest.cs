using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class Bolest
    {
        private DateTime datumPregleda { get; set; }
        private Zaposlenik liječnik { get; set; }
        private string dijagnoza { get; set; }
        private string terapija { get; set; }
    }
}
