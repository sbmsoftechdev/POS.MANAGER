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
    
    public partial class SalesRep
    {
        public int HQID { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string Number { get; set; }
        public int StoreID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public float PercentOfSale { get; set; }
        public float PercentOfProfit { get; set; }
        public decimal FixedRate { get; set; }
        public string EmailAddress { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public string Telephone { get; set; }
    }
}
