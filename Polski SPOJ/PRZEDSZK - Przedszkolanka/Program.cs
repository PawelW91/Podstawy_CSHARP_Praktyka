namespace PRZEDSZK___Przedszkolanka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());

            for (int i = 0; i < ile_t; i++)
            {
                int a, b, NWW = 1, NWD=0, MIN=0;
                string[] input = Console.ReadLine().Split();

                if (input.Length != 2 || !int.TryParse(input[0], out a) || !int.TryParse(input[1], out b))
                {
                    return;
                }

                // NWW - najmniejsza wspolna wielokrotnosc
                // NWD - najwiekszy wspolny dzielnik

                MIN = Math.Min(a, b);
                for (int j = 1; j <= MIN; j++)
                {
                    if (a % j == 0 && b % j == 0)
                    {
                        NWD = j;
                    }
                }

                if (a == b)
                {
                    NWW = a;
                }
                else
                {
                    NWW = (a * b) / NWD;
                }

                Console.WriteLine(NWW);
            }
        }
    }
}
