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
    
    public partial class Screen
    {
        public Screen()
        {
            this.Sections = new HashSet<Section>();
        }
    
        public decimal ScreenId { get; set; }
        public Nullable<decimal> FormId { get; set; }
        public Nullable<decimal> MemberId { get; set; }
        public Nullable<short> OrderSeq { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }
        public int ScreenTypeId { get; set; }
        public Nullable<int> MemberScreenTemplateId { get; set; }
        public Nullable<bool> HelpTopic { get; set; }
        public Nullable<bool> FY { get; set; }
        public Nullable<bool> TR { get; set; }
        public string ScreenMode { get; set; }
    
        public virtual Form Form { get; set; }
        public virtual Member Member { get; set; }
        public virtual MemberScreenTemplate MemberScreenTemplate { get; set; }
        public virtual ScreenType ScreenType { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}