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
    
    public partial class AddAnotherGrpItemDetail
    {
        public int AddAnotherGrpItemDetailId { get; set; }
        public int AddAnotherGrpItemId { get; set; }
        public decimal ReqGroupId { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> MemberAAGrpItemDetTemplateId { get; set; }
    
        public virtual AddAnotherGrpItem AddAnotherGrpItem { get; set; }
        public virtual MemberAddAnotherGrpItemDetTemplate MemberAddAnotherGrpItemDetTemplate { get; set; }
        public virtual ReqGroup ReqGroup { get; set; }
    }
}
