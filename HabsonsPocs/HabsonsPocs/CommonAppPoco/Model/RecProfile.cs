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
    
    public partial class RecProfile
    {
        public decimal RecommenderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HsCEEBCode { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }
        public string Title { get; set; }
        public Nullable<bool> OptOut { get; set; }
        public Nullable<bool> RefreshScreen { get; set; }
    }
}
