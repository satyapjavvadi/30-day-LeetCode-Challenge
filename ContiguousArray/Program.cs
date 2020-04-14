using System;
using System.Collections.Generic;

namespace ContiguousArray
{
    class Program
    {
        public static int FindMaxLength(int[] nums)
        {
            int count = 0, maxCount = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count--;
                }
                if (nums[i] == 1)
                {
                    count++;
                }

                if (dict.ContainsKey(count))
                {
                    maxCount = Math.Max(maxCount, i - dict[count]);
                }

                else
                {
                    dict[count] = i;
                }

                if (count == 0)
                {
                    maxCount = i + 1;
                }

            }
            return maxCount;

        }
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0};
            int count = FindMaxLength(nums);
            Console.WriteLine(count);
        }
    }
}
