//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS_DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaxEntry
    {
        public int StoreID { get; set; }
        public int ID { get; set; }
        public int TaxID { get; set; }
        public int TransactionNumber { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxableAmount { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public int TransactionEntryID { get; set; }
    }
}
