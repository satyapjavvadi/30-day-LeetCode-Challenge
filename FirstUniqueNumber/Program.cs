using System;
using System.Collections.Generic;

namespace FirstUniqueNumber
{
    class Program
    {
        public class FirstUnique
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Queue<int> qu = new Queue<int>();

            public FirstUnique(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(nums[i]))
                    {
                        dict[nums[i]] = dict[nums[i]] + 1;
                    }
                    else
                    {
                        dict.Add(nums[i], 1);
                    }

                    qu.Enqueue(nums[i]);
                }
            }

            public int ShowFirstUnique()
            {

                while (qu.Count != 0 && dict[qu.Peek()] > 1)
                {
                    qu.Dequeue();
                }

                if (qu.Count == 0)
                {
                    return -1;
                }

                return qu.Peek();
            }

            public void Add(int value)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value] = dict[value] + 1;
                }
                else
                {
                    dict.Add(value, 1);
                }

                if (dict[value] == 1)
                {
                    qu.Enqueue(value);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 5, 2 };
        }
    }
}
