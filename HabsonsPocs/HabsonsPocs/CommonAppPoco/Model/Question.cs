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
    
    public partial class Question
    {
        public Question()
        {
            this.ChoiceGrpReqRules = new HashSet<ChoiceGrpReqRule>();
            this.ChoiceGrpReqRules1 = new HashSet<ChoiceGrpReqRule>();
            this.ChoiceGrpReqRules2 = new HashSet<ChoiceGrpReqRule>();
            this.ChoiceGrpReqRules3 = new HashSet<ChoiceGrpReqRule>();
            this.ChoiceGrpReqRules4 = new HashSet<ChoiceGrpReqRule>();
            this.CommonAnswers = new HashSet<CommonAnswer>();
            this.MemberAnswers = new HashSet<MemberAnswer>();
            this.RecFormAnswers = new HashSet<RecFormAnswer>();
            this.RecProfileAnswers = new HashSet<RecProfileAnswer>();
            this.ReqGroupDetails = new HashSet<ReqGroupDetail>();
            this.ReqRuleExpressions = new HashSet<ReqRuleExpression>();
            this.ReqRuleTriggers = new HashSet<ReqRuleTrigger>();
            this.SuppressionGroupDetails = new HashSet<SuppressionGroupDetail>();
            this.ValGroupDetails = new HashSet<ValGroupDetail>();
        }
    
        public decimal QuestionId { get; set; }
        public decimal SectionId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public int QuestionTypeId { get; set; }
        public Nullable<decimal> QuestionTemplateId { get; set; }
        public Nullable<decimal> ChoiceGroupId { get; set; }
        public Nullable<bool> DeleteStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }
        public string ComplianceLabel { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string ParseToDataType { get; set; }
        public Nullable<int> MaxLength { get; set; }
        public bool IsExtnDisplayed { get; set; }
        public string PlaceholderText { get; set; }
        public string MaskInputPattern { get; set; }
        public string ValidationPattern { get; set; }
        public string AllowedCharacters { get; set; }
        public string AutoformatPattern { get; set; }
        public string ErrorMessage { get; set; }
        public short OrderSeq { get; set; }
        public bool IsCustomValidate { get; set; }
        public bool IsDynamicChoiceImpact { get; set; }
        public bool IsDynamicChoiceTrigger { get; set; }
        public Nullable<int> MemberQuestionTemplateId { get; set; }
        public Nullable<bool> HelpTopic { get; set; }
        public bool IsDynamicTriggerForOtherSections { get; set; }
        public string PrintLabel { get; set; }
        public Nullable<sbyte> ProsSuspExport { get; set; }
    
        public virtual ChoiceGroup ChoiceGroup { get; set; }
        public virtual ICollection<ChoiceGrpReqRule> ChoiceGrpReqRules { get; set; }
        public virtual ICollection<ChoiceGrpReqRule> ChoiceGrpReqRules1 { get; set; }
        public virtual ICollection<ChoiceGrpReqRule> ChoiceGrpReqRules2 { get; set; }
        public virtual ICollection<ChoiceGrpReqRule> ChoiceGrpReqRules3 { get; set; }
        public virtual ICollection<ChoiceGrpReqRule> ChoiceGrpReqRules4 { get; set; }
        public virtual ICollection<CommonAnswer> CommonAnswers { get; set; }
        public virtual ICollection<MemberAnswer> MemberAnswers { get; set; }
        public virtual MemberQuestionTemplate MemberQuestionTemplate { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<RecFormAnswer> RecFormAnswers { get; set; }
        public virtual ICollection<RecProfileAnswer> RecProfileAnswers { get; set; }
        public virtual ICollection<ReqGroupDetail> ReqGroupDetails { get; set; }
        public virtual ICollection<ReqRuleExpression> ReqRuleExpressions { get; set; }
        public virtual ICollection<ReqRuleTrigger> ReqRuleTriggers { get; set; }
        public virtual ICollection<SuppressionGroupDetail> SuppressionGroupDetails { get; set; }
        public virtual ICollection<ValGroupDetail> ValGroupDetails { get; set; }
    }
}