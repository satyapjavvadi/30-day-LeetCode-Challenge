using System;

namespace SubArrayAumEqualsK
{
    class Program
    {
        public static int SubarraySum(int[] nums, int k)
        {

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum = sum + nums[j];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }

            return count;

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 1 };
            int k = 2;
            int count = SubarraySum(arr, k);
            Console.WriteLine(count);
        }
    }
}
