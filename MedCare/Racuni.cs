//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedCare
{
    using System;
    using System.Collections.Generic;
    
    public partial class Racuni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racuni()
        {
            this.StavkeRacuna = new HashSet<StavkeRacuna>();
        }
    
        public int Id { get; set; }
        public System.DateTime Datum { get; set; }
        public int PacijentiId { get; set; }
        public int ZaposleniciId { get; set; }
        public decimal Iznos { get; set; }
    
        public virtual Pacijenti Pacijenti { get; set; }
        public virtual Zaposlenici Zaposlenici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkeRacuna> StavkeRacuna { get; set; }
    }
}
