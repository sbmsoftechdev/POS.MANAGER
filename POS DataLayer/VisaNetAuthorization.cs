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
    
    public partial class VisaNetAuthorization
    {
        public int ID { get; set; }
        public int StoreID { get; set; }
        public string RequestRecordFormat { get; set; }
        public string RequestApplicationType { get; set; }
        public string RequestAcquirerBIN { get; set; }
        public string RequestMerchantNumber { get; set; }
        public string RequestStoreNumber { get; set; }
        public string RequestTerminalNumber { get; set; }
        public string RequestDeviceCode { get; set; }
        public string RequestIndustryCode { get; set; }
        public string RequestCurrencyCode { get; set; }
        public string RequestCountryCode { get; set; }
        public string RequestCityCode { get; set; }
        public string RequestLanguageIndicator { get; set; }
        public string RequestTimeZoneDifferential { get; set; }
        public string RequestMerchantCategoryCode { get; set; }
        public string RequestRequestedACI { get; set; }
        public string RequestTransactionSequenceNumber { get; set; }
        public string RequestAuthorizationTransactionCode { get; set; }
        public string RequestCardholderIdentificationCode { get; set; }
        public string RequestAccountDataSource { get; set; }
        public string RequestTrack1Data { get; set; }
        public string RequestTrack2Data { get; set; }
        public string RequestManualAccountData { get; set; }
        public string RequestManualExpirationDate { get; set; }
        public string RequestCardholderIdentificationData { get; set; }
        public string RequestReceivingInstitutionID { get; set; }
        public Nullable<decimal> RequestTransactionAmount { get; set; }
        public Nullable<decimal> RequestSecondaryAmount { get; set; }
        public string RequestMarketSpecificData { get; set; }
        public string RequestCardAcceptorData { get; set; }
        public string RequestReversalTranID { get; set; }
        public string RequestReversalData { get; set; }
        public string RequestPurchaseIdentifier { get; set; }
        public string RequestGroupIIIVersionNumber { get; set; }
        public string ResponseRecordFormat { get; set; }
        public string ResponseApplicationType { get; set; }
        public string ResponseReturnedACI { get; set; }
        public string ResponseStoreNumber { get; set; }
        public string ResponseTerminalNumber { get; set; }
        public string ResponseAuthorizationSourceCode { get; set; }
        public string ResponseTransactionSequenceNumber { get; set; }
        public string ResponseResponseCode { get; set; }
        public string ResponseApprovalCode { get; set; }
        public Nullable<System.DateTime> ResponseLocalTransactionDateTime { get; set; }
        public string ResponseAuthorizationResponseText { get; set; }
        public string ResponseAVSResultCode { get; set; }
        public string ResponseRetrievalReferenceNumber { get; set; }
        public string ResponseMarketSpecificDataID { get; set; }
        public string ResponseTransactionID { get; set; }
        public string ResponseValidationCode { get; set; }
        public Nullable<int> VisaNetBatchID { get; set; }
        public Nullable<int> Status { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public string RequestSharingGroup { get; set; }
        public string ResponseSharingGroup { get; set; }
        public string ResponseSystemTraceAuditNumber { get; set; }
        public string ResponseHostMessageIdentifier { get; set; }
        public string ResponseTransactionStatusCode { get; set; }
        public string SettlementDate { get; set; }
        public Nullable<decimal> ResponseApprovedAmount { get; set; }
        public string ResponseCardLevel { get; set; }
    }
}
