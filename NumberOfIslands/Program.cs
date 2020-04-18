using System;

namespace NumberOfIslands
{
    class Program
    {
        public static int NumIslands(char[][] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        IsLandCount(grid, i, j);
                        count++;
                    }
                }
            }

            return count;

        }

        static int IsLandCount(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
            {
                return 0;
            }

            grid[i][j] = '0';

            IsLandCount(grid, i - 1, j);
            IsLandCount(grid, i, j - 1);
            IsLandCount(grid, i + 1, j);
            IsLandCount(grid, i, j + 1);
            return 1;
        }
        static void Main(string[] args)
        {
            var arr = new char[][]{
                            new char[]{'1', '1', '1', '1', '0' },
                            new char[]{'1', '1', '0', '0', '0' },
                            new char[]{'0', '0', '1', '0', '0' },
                            new char[]{'0', '0', '0', '1', '1' }};

            int count = NumIslands(arr);
            Console.WriteLine(count);
        }
    }
}
