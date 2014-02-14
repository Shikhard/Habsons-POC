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
    
    public partial class Member
    {
        public Member()
        {
            this.ApplicantMembers = new HashSet<ApplicantMember>();
            this.ChoiceGroups = new HashSet<ChoiceGroup>();
            this.MemberKeyfacts = new HashSet<MemberKeyfact>();
            this.MemberRecPersonaSubTypes = new HashSet<MemberRecPersonaSubType>();
            this.RecAssignments = new HashSet<RecAssignment>();
            this.RecForms = new HashSet<RecForm>();
            this.ReqGroups = new HashSet<ReqGroup>();
            this.RoleMembers = new HashSet<RoleMember>();
            this.Screens = new HashSet<Screen>();
            this.SDSConfigs = new HashSet<SDSConfig>();
            this.SupressionMemberConfigs = new HashSet<SupressionMemberConfig>();
            this.Terms = new HashSet<Term>();
            this.UserProfiles = new HashSet<UserProfile>();
            this.ValGroups = new HashSet<ValGroup>();
        }
    
        public decimal MemberId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string SortingName { get; set; }
        public string ContactEmail { get; set; }
        public string Website { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> ActiveDate { get; set; }
        public Nullable<System.DateTime> InactiveDate { get; set; }
        public Nullable<float> Latitude { get; set; }
        public Nullable<float> Longitude { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public Nullable<bool> CAOExclusive { get; set; }
        public Nullable<bool> AcceptTransfer { get; set; }
        public Nullable<short> HasSupp { get; set; }
        public Nullable<bool> ArtsSupp { get; set; }
        public Nullable<bool> AcceptFirstYrSpring { get; set; }
        public Nullable<bool> PaymentRequired { get; set; }
        public Nullable<bool> EDParentRequired { get; set; }
        public Nullable<sbyte> NACACFeeWaiver { get; set; }
        public Nullable<sbyte> CBFeeWaiver { get; set; }
        public Nullable<sbyte> OtherFeeWaiver { get; set; }
        public Nullable<sbyte> TEEvalMin { get; set; }
        public Nullable<sbyte> TEEvalMax { get; set; }
        public Nullable<sbyte> OtherEvalMin { get; set; }
        public Nullable<sbyte> OtherEvalMax { get; set; }
        public string TestPolicy { get; set; }
        public Nullable<bool> MidYearReport { get; set; }
        public Nullable<bool> FinalReport { get; set; }
        public string AlternateSearchName { get; set; }
        public sbyte Status { get; set; }
        public string MediaUrl { get; set; }
        public string RequestInfoUrl { get; set; }
        public Nullable<bool> SavesSFAfterMatriculation { get; set; }
        public string AdditionalInfo { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }
        public bool DeleteStatus { get; set; }
        public Nullable<sbyte> CollegeInstructorMin { get; set; }
        public Nullable<sbyte> CollegeInstructorMax { get; set; }
        public Nullable<long> MemberTypeID { get; set; }
        public string ArtsURL { get; set; }
        public Nullable<int> MemberPaymentConfigId { get; set; }
        public string TestPolicyUrl { get; set; }
        public string FYFeeWaiverChoiceValues { get; set; }
        public string TRFeeWaiverChoiceValues { get; set; }
        public string SATACTTests { get; set; }
        public string InternationalTest { get; set; }
        public Nullable<bool> PaymentGatewayAvailable { get; set; }
    
        public virtual ICollection<ApplicantMember> ApplicantMembers { get; set; }
        public virtual ICollection<ChoiceGroup> ChoiceGroups { get; set; }
        public virtual MemberPaymentConfig MemberPaymentConfig { get; set; }
        public virtual MemberType MemberType { get; set; }
        public virtual ICollection<MemberKeyfact> MemberKeyfacts { get; set; }
        public virtual ICollection<MemberRecPersonaSubType> MemberRecPersonaSubTypes { get; set; }
        public virtual ICollection<RecAssignment> RecAssignments { get; set; }
        public virtual ICollection<RecForm> RecForms { get; set; }
        public virtual ICollection<ReqGroup> ReqGroups { get; set; }
        public virtual ICollection<RoleMember> RoleMembers { get; set; }
        public virtual ICollection<Screen> Screens { get; set; }
        public virtual ICollection<SDSConfig> SDSConfigs { get; set; }
        public virtual ICollection<SupressionMemberConfig> SupressionMemberConfigs { get; set; }
        public virtual ICollection<Term> Terms { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
        public virtual ICollection<ValGroup> ValGroups { get; set; }
    }
}