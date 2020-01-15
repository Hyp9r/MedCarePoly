using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class Narudžbenica
    {
        private string šifra { get; set; }
        private DateTime datum { get; set; }
        private PoslovniPartner partner { get; set; }
        private Proizvod proizvod { get; set; }
        private Zaposlenik zaposlenik { get; set; }
        private int količina { get; set; }
        private string napomena { get; set; }
    }
}
