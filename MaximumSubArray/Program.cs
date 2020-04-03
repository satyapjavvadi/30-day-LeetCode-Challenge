using System;

namespace MaximumSubArray
{
    class Program
    {
        public static int MaximumSumArray(int[] nums)
        {
            int max_sum = nums[0];
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if(max_sum < sum)
                {
                    max_sum = sum;
                }
                if(sum < 0)
                {
                    sum = 0;
                }
            }
            return max_sum;
        }
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int max_sum = MaximumSumArray(nums);
            Console.WriteLine(max_sum);
        }
    }
}
