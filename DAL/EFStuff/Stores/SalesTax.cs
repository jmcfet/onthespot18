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
    
    public partial class SalesTax
    {
        public Nullable<int> TaxID { get; set; }
        public string Description { get; set; }
        public string TaxName { get; set; }
        public Nullable<float> TaxPercent { get; set; }
        public Nullable<int> GLAccountID { get; set; }
        public bool Deleted { get; set; }
        public int StoreID { get; set; }
        public int TaxAuthorityID { get; set; }
        public int TaxTableID { get; set; }
    }
}
