namespace RNO_DOD___Proste_dodawanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int z = 0;

                string[] numbers = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    int x = int.Parse(numbers[j]);
                    z += x;
                }

                Console.WriteLine(z);
            }
        }
    }
}
