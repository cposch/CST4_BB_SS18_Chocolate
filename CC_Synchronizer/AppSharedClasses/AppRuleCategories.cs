namespace AppSharedClasses
{
    public class AppRuleCategories
    {
        private int Id { get; set; }
        public int RuleId { get; set; }
        public int CategoryId { get; set; }

        public AppRuleCategories() { }

        public AppRuleCategories(int id, int ruleId, int categoryId)
        {
            Id = id;
            RuleId = ruleId;
            CategoryId = categoryId;
        }
    }
}
