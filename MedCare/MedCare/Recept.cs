using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class Recept
    {
        private Zaposlenik liječnik { get; set; }
        private Pacijent pacijent { get; set; }
        private DateTime datumIzdavanja { get; set; }
        private DateTime datumIsteka { get; set; }
        private Lijek lijek { get; set; }
        private string doza { get; set; }
        private string napomena { get; set; }
    }
}
