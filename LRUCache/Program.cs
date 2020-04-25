using System;
using System.Collections.Generic;

namespace LRUCache
{
    class Program
    {
        public class LRUCache
        {
            int capacity;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> list = new List<int>();

            public LRUCache(int capacity)
            {
                this.capacity = capacity;
            }

            public int Get(int key)
            {
                if (!dict.ContainsKey(key))
                {
                    return -1;
                }

                int ret = dict[key];
                list.Remove(key);
                list.Add(key);
                return ret;
            }


            public void Put(int key, int value)
            {

                if (dict.ContainsKey(key))
                {
                    dict[key] = value;
                    list.Remove(key);
                    list.Add(key);
                    return;
                }
                if (dict.Count == capacity)
                {
                    int evict = list[0];
                    list.Remove(evict);
                    dict.Remove(evict);
                }

                dict.Add(key, value);
                list.Add(key);


            }
        }

        static void Main(string[] args)
        {
            LRUCache lrucache = new LRUCache(2);

            lrucache.Put(1, 2);
            lrucache.Put(2, 3);
            lrucache.Get(1);
            lrucache.Get(2);
        }
    }
}
