//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C102575814Interest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C102575814Interest()
        {
            this.C102575814Customer = new HashSet<C102575814Customer>();
        }
    
        public string InterestCode { get; set; }
        public string InterestDesc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C102575814Customer> C102575814Customer { get; set; }
    }
}