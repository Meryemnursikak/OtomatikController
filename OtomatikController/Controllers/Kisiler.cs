//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtomatikController.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kisiler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kisiler()
        {
            this.Adres1 = new HashSet<Adres>();
        }
    
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public Nullable<int> Adres { get; set; }
        public Nullable<int> Yas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adres> Adres1 { get; set; }
    }
}