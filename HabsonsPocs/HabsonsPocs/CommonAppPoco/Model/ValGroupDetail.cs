//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonAppPoco.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ValGroupDetail
    {
        public long ValGroupDetailId { get; set; }
        public decimal ValGroupId { get; set; }
        public Nullable<decimal> QuestionId { get; set; }
        public Nullable<short> Order { get; set; }
        public bool DeleteStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }
        public Nullable<int> MemberValGroupDetailTemplateId { get; set; }
        public Nullable<long> MemberQuestionTemplateId { get; set; }
    
        public virtual MemberValGroupDetailTemplate MemberValGroupDetailTemplate { get; set; }
        public virtual Question Question { get; set; }
        public virtual ValGroup ValGroup { get; set; }
    }
}