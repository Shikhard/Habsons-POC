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
    
    public partial class AddAnotherGrp
    {
        public AddAnotherGrp()
        {
            this.AddAnotherGrpItems = new HashSet<AddAnotherGrpItem>();
        }
    
        public int AddAnotherGrpId { get; set; }
        public string Name { get; set; }
        public Nullable<short> OrderSeq { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
        public Nullable<decimal> SectionId { get; set; }
        public Nullable<int> MemberAAGrpTemplateId { get; set; }
    
        public virtual ICollection<AddAnotherGrpItem> AddAnotherGrpItems { get; set; }
        public virtual MemberAddAnotherGrpTemplate MemberAddAnotherGrpTemplate { get; set; }
        public virtual Section Section { get; set; }
    }
}