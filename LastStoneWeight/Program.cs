using System;

namespace LastStoneWeight
{
    class Program
    {
        public static int LastStoneWeight(int[] stones)
        {
            int endIndex = stones.Length - 1;

            while(endIndex >= 1)
            {
                Array.Sort(stones);

                if(stones[endIndex] == stones[endIndex - 1])
                {
                    endIndex = endIndex - 2;
                }
                else
                {
                    stones[endIndex - 1] = stones[endIndex] - stones[endIndex - 1];
                    endIndex--;
                }
            }
            return endIndex == 0 ? stones[0] : 0;

        }
        static void Main(string[] args)
        {
            int[] stones = { 2, 7, 4, 1, 8, 1 };
            int stoneWeight = LastStoneWeight(stones);
            Console.WriteLine(stoneWeight);
        }
    }
}
