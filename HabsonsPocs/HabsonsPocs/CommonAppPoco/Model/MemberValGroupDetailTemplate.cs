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
    
    public partial class MemberValGroupDetailTemplate
    {
        public MemberValGroupDetailTemplate()
        {
            this.ValGroupDetails = new HashSet<ValGroupDetail>();
        }
    
        public int MemberValGroupDetailTemplateId { get; set; }
        public int MemberValGroupTemplateId { get; set; }
        public int MemberQuestionTemplateId { get; set; }
        public Nullable<short> OrderSeq { get; set; }
        public bool DeleteStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
    
        public virtual MemberQuestionTemplate MemberQuestionTemplate { get; set; }
        public virtual MemberValGroupTemplate MemberValGroupTemplate { get; set; }
        public virtual ICollection<ValGroupDetail> ValGroupDetails { get; set; }
    }
}
