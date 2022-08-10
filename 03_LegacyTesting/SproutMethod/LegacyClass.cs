using System.Collections.Generic;

namespace SproutMethod
{
    public class LegacyClass
    {
        public void AppendDictionary<TKey, TValue>(Dictionary<TKey, TValue> fromDict, Dictionary<TKey, TValue> toDict)
        {
            Dictionary<TKey, TValue> validItems = GetValidItems(fromDict, toDict);

            foreach (var item in validItems)
            {
                //We can solve the repeated key problem with an if statement
                //if (!toDict.ContainsKey(item.Key)) { toDict.Add(item.Key, item.Value); }
                //But it will be going to be imposible to test. Thats why we use GetValidItems,
                //in order to respect the open/close principle

                toDict.Add(item.Key, item.Value);
            }
        }

        //This is the sprout method,which is going to help us to solve the problem when AppendDictionary contains repeated keys
        public Dictionary<TKey, TValue> GetValidItems<TKey, TValue>(Dictionary<TKey, TValue> fromDict, Dictionary<TKey,
            TValue> toDict)
        {
            var result = new Dictionary<TKey, TValue>();

            foreach (var item in fromDict)
            {
                if (!toDict.ContainsKey(item.Key)) //here we implement the solution not in the legacy code
                    result.Add(item.Key, item.Value);
            }
            return result;
        }
    }
}
