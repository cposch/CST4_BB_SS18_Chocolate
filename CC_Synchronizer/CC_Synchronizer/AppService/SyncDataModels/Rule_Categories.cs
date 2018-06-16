using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Rule_Categories
    {
        public List<ShRuleCategories> TableList { get; set; }

        public Rule_Categories()
        {
            TableList = new List<ShRuleCategories>();
        }

        public void Add(ShRuleCategories ruleCategory)
        {
            TableList.Add(ruleCategory);
        }

        public static Rule_Categories Deserialize(string s)
        {
            SyncXMLSerializer<Rule_Categories> serializerRule_Categories = new SyncXMLSerializer<Rule_Categories>();
            return serializerRule_Categories.Deserialize(s);
        }
    }
}
