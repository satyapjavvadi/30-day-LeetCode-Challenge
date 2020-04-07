using System;
using System.Collections.Generic;

namespace GroupAnagrams
{
    class Program
    {
        public static IList<IList<string>> PrintAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var ch = str.ToCharArray();
                Array.Sort(ch);
                var key = new string(ch);

                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }
                dict[key].Add(str);
            }
            var list = new List<IList<string>>();
            foreach (var kv in dict)
            {
                list.Add(kv.Value);
            }
            return list;

        }
        static void Main(string[] args)
        {
            string[] input =  { "eat", "tea", "tan", "ate", "nat", "bat" };
            var output = PrintAnagrams(input);            
        }
    }
}
