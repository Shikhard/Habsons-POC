//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentResponse
    {
        public int PaymentResponseID { get; set; }
        public string SuccessIndicator { get; set; }
        public Nullable<float> Amount { get; set; }
        public string TransactionCode { get; set; }
        public string PaymentIndicator { get; set; }
        public string UserDefined1 { get; set; }
        public string UserDefined2 { get; set; }
        public string OrderId { get; set; }
        public string AuthenticationCode { get; set; }
        public Nullable<int> ApplicantMemberId { get; set; }
        public string HostName { get; set; }
        public string ErrorDescription { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
    }
}