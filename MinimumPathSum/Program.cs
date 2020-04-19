using System;

namespace MinimumPathSum
{
    class Program
    {
        public static int MinPathSum(int[][] grid)
        {

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if ((i - 1 >= 0) && (j - 1 >= 0))
                    {
                        grid[i][j] += Math.Min(grid[i][j - 1], grid[i - 1][j]);
                    }
                    else if (i - 1 >= 0)
                    {
                        grid[i][j] += grid[i - 1][j];
                    }
                    else if (j - 1 >= 0)
                    {
                        grid[i][j] += grid[i][j - 1];
                    }
                }
            }

            return grid[grid.Length - 1][grid[0].Length - 1];
        }

        static void Main(string[] args)
        {
            var arr = new int[][]{
                            new int[]{1, 3, 1 },
                            new int[]{1, 5, 1},
                            new int[]{4, 2, 1 }};

            int count = MinPathSum(arr);
            Console.WriteLine(count);
        }
    }
}
