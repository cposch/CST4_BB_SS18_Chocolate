using System.Collections.Generic;
using AppSharedClasses;

namespace CC_Synchronizer.AppService.SyncDataModels
{
    public class Rule
    {
        public List<ShRule> TableList { get; set; }

        public Rule()
        {
            TableList = new List<ShRule>();
        }

        public void Add(ShRule rule)
        {
            TableList.Add(rule);
        }

        public static Rule Deserialize(string s)
        {
            SyncXMLSerializer<Rule> serializerRule = new SyncXMLSerializer<Rule>();
            return serializerRule.Deserialize(s);
        }
    }
}
