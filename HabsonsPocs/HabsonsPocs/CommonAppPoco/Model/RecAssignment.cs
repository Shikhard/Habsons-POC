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
    
    public partial class RecAssignment
    {
        public decimal RecAssignmentId { get; set; }
        public decimal InvitationId { get; set; }
        public Nullable<decimal> MemberId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
    
        public virtual Invitation Invitation { get; set; }
        public virtual Member Member { get; set; }
    }
}