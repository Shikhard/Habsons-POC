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
    
    public partial class SDSSchedule
    {
        public int SDSScheduleId { get; set; }
        public int SDSConfigId { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<bool> RunDaily { get; set; }
        public Nullable<int> DaysOfWeek { get; set; }
        public Nullable<bool> RunNow { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<bool> IsLive { get; set; }
        public Nullable<System.DateTime> NextRunTime { get; set; }
    
        public virtual SDSConfig SDSConfig { get; set; }
    }
}