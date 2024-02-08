namespace PP0501A___NWD
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());
            for (int i = 0; i < ile_t; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                int a = int.Parse(parts[0]);
                int b = int.Parse(parts[1]);

                int nwd = NWD(a, b);
                Console.WriteLine(nwd);
            }
        }
        static int NWD(int a, int b)
        {
            while (b != 0)
            {
                int x = b;
                b = a % b;
                a = x;
            }
            return a;
        }
    }

}
