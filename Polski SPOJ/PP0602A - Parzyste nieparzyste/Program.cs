namespace PP0602A___Parzyste_nieparzyste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int test = 0; test < t; test++)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = int.Parse(input[i + 1]);
                }
                for (int i = 1; i < n; i += 2)
                {
                    Console.Write(numbers[i] + " ");
                }
                for (int i = 0; i < n; i += 2)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
