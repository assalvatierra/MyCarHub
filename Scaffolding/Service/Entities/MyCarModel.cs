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
    
    public partial class MyCarModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MyCarModel()
        {
            this.MyCars = new HashSet<MyCar>();
        }
    
        public int Id { get; set; }
        public string Model { get; set; }
        public int MyCarMakeId { get; set; }
        public int MyCarTypeId { get; set; }
    
        public virtual MyCarMake MyCarMake { get; set; }
        public virtual MyCarType MyCarType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyCar> MyCars { get; set; }
    }
}
