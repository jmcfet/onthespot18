//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EFStuff.Stores
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvPaid
    {
        public int InvPaidID { get; set; }
        public int StoreID { get; set; }
        public int InvoiceID { get; set; }
        public int PaymentID { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public decimal PaidAmount { get; set; }
        public bool Deleted { get; set; }
        public int AccountType { get; set; }
    }
}
