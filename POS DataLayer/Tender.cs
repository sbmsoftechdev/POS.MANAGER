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
    
    public partial class Tender
    {
        public int HQID { get; set; }
        public bool PreventOverTendering { get; set; }
        public int VerificationType { get; set; }
        public bool VerifyViaEDC { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public short AdditionalDetailType { get; set; }
        public bool PrinterValidation { get; set; }
        public string ValidationLine1 { get; set; }
        public string ValidationLine2 { get; set; }
        public string ValidationLine3 { get; set; }
        public string GLAccount { get; set; }
        public short ScanCode { get; set; }
        public decimal RoundToValue { get; set; }
        public string Code { get; set; }
        public decimal MaximumAmount { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public bool DoNotPopCashDrawer { get; set; }
        public int CurrencyID { get; set; }
        public int DisplayOrder { get; set; }
        public string ValidationMask { get; set; }
        public bool SignatureRequired { get; set; }
        public bool AllowMultipleEntries { get; set; }
        public decimal DebitSurcharge { get; set; }
        public bool SupportCashBack { get; set; }
        public decimal CashBackLimit { get; set; }
        public decimal CashBackFee { get; set; }
        public bool Inactive { get; set; }
    }
}