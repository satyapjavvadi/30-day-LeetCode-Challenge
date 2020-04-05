using System;

namespace MoveZeroes
{
    class Program
    {
        public static void MoveZeroesToEnd(int[] nums)
        {
            int firstZero = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0 && firstZero != -1)
                {
                    nums[firstZero] = nums[i];
                    nums[i] = 0;
                    firstZero++;
                }
                else if (nums[i] == 0 && firstZero == -1)
                {
                    firstZero = i;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroesToEnd(nums);
            Console.WriteLine("Array after pushing zeroes to end");
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i]+" ");
        }
    }
}
