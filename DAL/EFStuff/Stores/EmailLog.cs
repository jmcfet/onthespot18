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
    
    public partial class EmailLog
    {
        public int EmailLogID { get; set; }
        public int StoreID { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public bool SendResult { get; set; }
        public int EmailID { get; set; }
        public int CustomerID { get; set; }
        public int TransID { get; set; }
        public int TransType { get; set; }
        public string Description { get; set; }
        public int EmailTypeID { get; set; }
    }
}
