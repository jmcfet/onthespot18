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
    
    public partial class InvoiceAdjust
    {
        public int AdjustID { get; set; }
        public int StoreID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int InvoiceID { get; set; }
        public string AdjDescription { get; set; }
        public int AdjType { get; set; }
        public Nullable<System.DateTime> AdjustDate { get; set; }
        public float Pieces { get; set; }
        public decimal AdjAmount { get; set; }
        public decimal AdjTax { get; set; }
        public bool Deleted { get; set; }
    }
}
