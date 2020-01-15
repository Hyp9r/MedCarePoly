using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public abstract class Osoba
    {
        private string ime { get; set; }
        private string prezime { get; set; }
        private DateTime datumRođenja { get; set; }
        private string adresa { get; set; }
        private string oib { get; set; }
        private char spol { get; set; }
        private string kontakt { get; set; }
        private string mail { get; set; }
    }
}
