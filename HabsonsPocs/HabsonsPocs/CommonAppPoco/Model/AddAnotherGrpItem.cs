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
    
    public partial class AddAnotherGrpItem
    {
        public AddAnotherGrpItem()
        {
            this.AddAnotherGrpItemDetails = new HashSet<AddAnotherGrpItemDetail>();
        }
    
        public int AddAnotherGrpItemId { get; set; }
        public string ItemName { get; set; }
        public int AddAnotherGrpId { get; set; }
        public Nullable<short> OrderSeq { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> MemberAAGrpItemTemplateId { get; set; }
    
        public virtual AddAnotherGrp AddAnotherGrp { get; set; }
        public virtual MemberAddAnotherGrpItemTemplate MemberAddAnotherGrpItemTemplate { get; set; }
        public virtual ICollection<AddAnotherGrpItemDetail> AddAnotherGrpItemDetails { get; set; }
    }
}
