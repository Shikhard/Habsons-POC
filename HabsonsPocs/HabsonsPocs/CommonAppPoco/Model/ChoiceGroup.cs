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
    
    public partial class ChoiceGroup
    {
        public ChoiceGroup()
        {
            this.ChoiceValues = new HashSet<ChoiceValue>();
            this.MemberQuestionTemplates = new HashSet<MemberQuestionTemplate>();
            this.Questions = new HashSet<Question>();
        }
    
        public decimal ChoiceGroupId { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> MemberId { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }
        public bool CommonChoiceGroup { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual ICollection<ChoiceValue> ChoiceValues { get; set; }
        public virtual ICollection<MemberQuestionTemplate> MemberQuestionTemplates { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}