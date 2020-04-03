using System;
using System.Collections.Generic;

namespace HappyNumber
{
    class Program
    {
        public static bool isHappyNumber(int n)
        {
            HashSet<int> hashset = new HashSet<int>();
            while(n != 1)
            {
                int sum = 0;
                while(n > 0)
                {
                    sum += (n % 10) * (n % 10);
                    n = n / 10;
                }
                if(hashset.Contains(sum))
                {
                    return false;
                }
                hashset.Add(sum);
                n = sum;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = 19;
            if(isHappyNumber(n))
            {
                Console.WriteLine($"{n} is a Happy Number");
            }
            else
            {
                Console.WriteLine($"{n} is not a Happy number");
            }
        }
    }
}
