using System;

namespace AppSharedClasses
{
    public class ShRuleCategories
    {
        public int? Id { get; set; }
        public int? RuleId { get; set; }
        public int? CategoryId { get; set; }
        public int? BackendID { get; set; }
        public int? FrontEndID { get; set; }
        public DateTime? Lastmodified { get; set; }

        public ShRuleCategories() { }

        public ShRuleCategories(int? id, int? ruleId, int? categoryId, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            Id = id;
            RuleId = ruleId;
            CategoryId = categoryId;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }

        public ShRuleCategories(int? ruleId, int? categoryId, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            RuleId = ruleId;
            CategoryId = categoryId;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }
    }
}
