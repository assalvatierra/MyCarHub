//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MyGarage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MyGarage()
        {
            this.MyCarGarageTrxes = new HashSet<MyCarTrxGarage>();
            this.MyGarageAdmins = new HashSet<MyGarageLogin>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Remarks { get; set; }
        public int MyAccountId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyCarTrxGarage> MyCarGarageTrxes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyGarageLogin> MyGarageAdmins { get; set; }
        public virtual MyAccount MyAccount { get; set; }
    }
}
