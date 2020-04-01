using System;

namespace FindSingleNumber
{
    class Program
    {
        public static int FindSinNumber(int[] nums)
        {
            int res = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                res = res ^ nums[i];
            }
            return res;
        }
        public static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 };
            int singNumber = FindSinNumber(nums);
            Console.WriteLine(singNumber);
        }
    }
}
