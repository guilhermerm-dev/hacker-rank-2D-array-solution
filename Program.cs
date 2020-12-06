using System;

namespace hacker_rank_2d_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 1 1 0 0 0
            // 0 1 0 0 0 0
            // 1 1 1 0 0 0
            // 0 0 2 4 4 0
            // 0 0 0 2 0 0
            // 0 0 1 2 4 0

            int[][] arr = new int[6][];
            arr[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[] { 0, 1, 0, 0, 0, 0 };
            arr[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[] { 0, 0, 2, 4, 4, 0 };
            arr[4] = new int[] { 0, 0, 0, 2, 0, 0 };
            arr[5] = new int[] { 0, 0, 1, 2, 4, 0 };

            int sum = HourglassMaxSum(arr);
            Console.WriteLine($"Max hourglass sum is {sum}");
        }

        private static int HourglassMaxSum(int[][] arr)
        {
            int rows = arr.Length;
            int columns = arr[0].Length;
            //constraint 7 * -9 = -63 (Minimum value possible)
            int max_hourglass_sum = -63;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < columns - 2; j++)
                {
                    int top = (arr[i][j] + arr[i][j + 1] + arr[i][j + 2]);
                    int middle = arr[i + 1][j + 1];
                    int bottom = (arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);
                    int current_max_sum = (top + middle + bottom);
                    max_hourglass_sum = Math.Max(max_hourglass_sum, current_max_sum);
                }
            }
            return max_hourglass_sum;
        }
    }
}
