using System;

namespace SearchInRotatedSortedArray
{
    class Program
    {
        public static int SearchArray(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            int low = 0;
            int high = nums.Length - 1;
            int mid = 0;

            while (low < high)
            {
                mid = (low + high) / 2;

                if (nums[mid] > nums[high])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            int start = low;
            low = 0;
            high = nums.Length - 1;

            if (target >= nums[start] && target <= nums[high])
            {
                low = start;
            }
            else
            {
                high = start;
            }

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
            int b = SearchArray(arr, 0);
            Console.WriteLine(b);
        }
    }
}
