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
    
    public partial class MyCarTrxExpense
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Remarks { get; set; }
        public int MyCarTrxId { get; set; }
        public int MyCarExpenseTypeId { get; set; }
    
        public virtual MyCarTrx MyCarTrx { get; set; }
        public virtual MyCarExpenseType MyCarExpenseType { get; set; }
    }
}
