using System;

namespace JumpGame
{
    class Program
    {
        public static bool CanJump(int[] nums)
        {
            int max_jump = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] + i > max_jump)
                {
                    max_jump = nums[i] + i;
                }
                if (max_jump == i)
                {
                    break;
                }
            }
            return max_jump >= nums.Length - 1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 1, 1, 4 }; //{3, 2, 1, 0, 4}
            bool b = CanJump(arr);
            Console.WriteLine(b);
        }
    }
}
