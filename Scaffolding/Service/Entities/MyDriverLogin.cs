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
    
    public partial class MyDriverLogin
    {
        public int Id { get; set; }
        public int MyDriverId { get; set; }
        public int MySupportLoginId { get; set; }
    
        public virtual MyDriver MyDriver { get; set; }
        public virtual MySupportLogin MySupportLogin { get; set; }
    }
}
