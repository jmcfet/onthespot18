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
    
    public partial class Original
    {
        public int StoreID { get; set; }
        public bool OrigInvoice { get; set; }
        public int CustomerID { get; set; }
        public int InvoiceID { get; set; }
        public int DepartmentID { get; set; }
        public int EmployeeID { get; set; }
        public string Department { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> AdjustDate { get; set; }
        public bool Voided { get; set; }
        public float bPieces { get; set; }
        public decimal bTotal { get; set; }
        public decimal bGarmLine { get; set; }
        public decimal bMerchLine { get; set; }
        public decimal bSFeeLine { get; set; }
        public decimal bCoupLine { get; set; }
        public decimal bDiscLine { get; set; }
        public decimal bCoupPct { get; set; }
        public decimal bDiscPct { get; set; }
        public decimal bSFeePct { get; set; }
        public decimal bTaxTotal { get; set; }
        public decimal bTaxTotal1 { get; set; }
        public decimal bTaxTotal2 { get; set; }
        public decimal bTaxTotal3 { get; set; }
        public float aPieces { get; set; }
        public decimal aTotal { get; set; }
        public decimal aGarmLine { get; set; }
        public decimal aMerchLine { get; set; }
        public decimal aSFeeLine { get; set; }
        public decimal aCoupLine { get; set; }
        public decimal aDiscLine { get; set; }
        public decimal aCoupPct { get; set; }
        public decimal aDiscPct { get; set; }
        public decimal aSFeePct { get; set; }
        public decimal aTaxTotal { get; set; }
        public decimal aTaxTotal1 { get; set; }
        public decimal aTaxTotal2 { get; set; }
        public decimal aTaxTotal3 { get; set; }
    }
}
