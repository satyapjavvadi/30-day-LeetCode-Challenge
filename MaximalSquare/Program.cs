using System;

namespace MaximalSquare
{
    class Program
    {
        public static int MaximalSquare(char[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return 0;
            }
            int n = matrix.Length;
            int m = matrix[0].Length;
            int[,] LS = new int[n + 1, m + 1];
            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (matrix[i - 1][j - 1] == '1')
                    {
                        LS[i, j] = Math.Min(LS[i - 1, j], Math.Min(LS[i, j - 1], LS[i - 1, j - 1])) + 1;
                        max = Math.Max(max, LS[i, j]);
                    }
                }
            }
            return max * max;

        }
        static void Main(string[] args)
        {
            var arr = new char[][]{
                            new char[]{'1','0', '1', '0', '0' },
                            new char[]{'1', '0', '1', '1','1', '1'},
                            new char[]{'1', '1', '1', '1','1' },
                            new char[]{'1','0','0','1','0'} };

            int max = MaximalSquare(arr);
            Console.WriteLine(max);
        }
    }
}
