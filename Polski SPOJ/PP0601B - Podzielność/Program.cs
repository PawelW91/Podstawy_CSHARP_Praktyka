namespace PP0601B___Podzielność
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());

            while (ile_t-- > 0)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int x = int.Parse(input[1]);
                int y = int.Parse(input[2]);

                for (int i = 0; i < n; i++)
                {
                    if (i % x == 0 && i % y != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
