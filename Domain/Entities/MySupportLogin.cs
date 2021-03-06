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
    
    public partial class MySupportLogin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MySupportLogin()
        {
            this.MyGarageLogins = new HashSet<MyGarageLogin>();
            this.MyDriverLogins = new HashSet<MyDriverLogin>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int MyAccountId { get; set; }
        public string LoginId { get; set; }
        public string Remarks { get; set; }
    
        public virtual MyAccount MyAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyGarageLogin> MyGarageLogins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyDriverLogin> MyDriverLogins { get; set; }
    }
}
