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
    
    public partial class GLAccount
    {
        public Nullable<int> GLAccountID { get; set; }
        public string Description { get; set; }
        public Nullable<float> SortOrder { get; set; }
        public Nullable<int> TypeID { get; set; }
        public string TypeDescription { get; set; }
        public bool DebitBalance { get; set; }
        public bool IsSysAccount { get; set; }
        public Nullable<int> ParentID { get; set; }
        public bool IsSubAccount { get; set; }
        public Nullable<int> GovTaxTypeID { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string GLNumber { get; set; }
        public bool Deleted { get; set; }
    }
}
