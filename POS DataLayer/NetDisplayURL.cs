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
    
    public partial class NetDisplayURL
    {
        public int ID { get; set; }
        public int ChannelID { get; set; }
        public string URL { get; set; }
        public int Seconds { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public int OrderPosition { get; set; }
        public byte[] DBTimeStamp { get; set; }
    }
}