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
    
    public partial class TenderEntry
    {
        public int BatchNumber { get; set; }
        public string CreditCardExpiration { get; set; }
        public int OrderHistoryID { get; set; }
        public int DropPayoutID { get; set; }
        public int StoreID { get; set; }
        public int ID { get; set; }
        public int TransactionNumber { get; set; }
        public int TenderID { get; set; }
        public int PaymentID { get; set; }
        public string Description { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public decimal Amount { get; set; }
        public string AccountHolder { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public decimal RoundingError { get; set; }
        public decimal AmountForeign { get; set; }
        public string BankNumber { get; set; }
        public string SerialNumber { get; set; }
        public string State { get; set; }
        public string License { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string TransitNumber { get; set; }
        public int VisaNetAuthorizationID { get; set; }
        public decimal DebitSurcharge { get; set; }
        public decimal CashBackSurcharge { get; set; }
        public bool IsCreateNew { get; set; }
    }
}
