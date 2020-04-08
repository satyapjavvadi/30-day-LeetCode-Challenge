using System;
using System.Collections.Generic;

namespace CountingElements
{
    class Program
    {
        public static int CountingElements(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            int count = 0;

                for(int i = 0; i < arr.Length; i++)
                {
                   if(!dict.ContainsKey(arr[i]))
                   {
                     dict.Add(arr[i], 1);
                   }
                   else
                   {
                    dict[arr[i]]++;
                   }

                }

                for(int i = 0; i < arr.Length; i++)
                {
                   if(dict.ContainsKey(arr[i] + 1))
                   {
                    count++;
                   }
                }

                return count;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int b = CountingElements(arr);
            Console.WriteLine($"b: {b}");
        }
    }
}
