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
    
    public partial class CCPaymentContract
    {
        public int CCPaymentContractID { get; set; }
        public int StoreID { get; set; }
        public int CustomerID { get; set; }
        public string CardNo { get; set; }
        public string CardMasked { get; set; }
        public string CardExpDate { get; set; }
        public string AVSStreet { get; set; }
        public string AVSZip { get; set; }
        public Nullable<System.DateTime> LastBatchRunDate { get; set; }
        public decimal LastBatchRunTotal { get; set; }
        public Nullable<System.DateTime> LastTokenDate { get; set; }
        public string CardToken { get; set; }
        public string EcBlock { get; set; }
        public string EcKey { get; set; }
        public bool EcSwiped { get; set; }
        public int CCKeyID { get; set; }
        public Nullable<System.DateTime> ResetDate { get; set; }
        public bool Locked { get; set; }
        public bool Deleted { get; set; }
    }
}
