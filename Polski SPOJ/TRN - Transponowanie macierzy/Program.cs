namespace TRN___Transponowanie_macierzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            int[,] x = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    x[i, j] = int.Parse(row[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(x[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
