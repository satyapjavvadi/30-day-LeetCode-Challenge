using System;

namespace ProductOfArrayExceptSelf
{
    class Program
    {
        public static int[] FindProductItself(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            int[] suffix = new int[nums.Length];
            int[] output = new int[nums.Length];
            prefix[0] = 1;
            suffix[nums.Length-1] = 1;

            for (int i = 1; i < nums.Length; i++)
            {               
                prefix[i] = prefix[i - 1] * nums[i - 1];
            }

            for (int i = nums.Length - 2; i >= 0; i--)
            {                
                suffix[i] = suffix[i+1] * nums[i+1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = prefix[i] * suffix[i];
            }

            return output;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] product = FindProductItself(nums);
            for (int i = 0; i < product.Length; i++)
            {
                Console.Write(product[i]+" ");
            }

        }
    }
}

