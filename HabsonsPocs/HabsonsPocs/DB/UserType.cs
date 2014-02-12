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
    
    public partial class UserType
    {
        public UserType()
        {
            this.Privileges = new HashSet<Privilege>();
            this.Roles = new HashSet<Role>();
        }
    
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual ICollection<Privilege> Privileges { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}