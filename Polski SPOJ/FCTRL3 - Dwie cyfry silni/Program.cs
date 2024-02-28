namespace FCTRL3___Dwie_cyfry_silni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());

            for (int i = 0; i < ile_t; i++)
            {
                int l, d, j, x = 1;
                l = int.Parse(Console.ReadLine());

                if (l > 9)
                {
                    Console.WriteLine("0 0");
                }
                else
                {
                    for (int k = 1; k <= l; k++)
                    {
                        x *= k;
                    }

                    d = (x / 10) % 10;
                    j = x % 10;
                    Console.WriteLine($"{d} {j}");
                }
            }
        }
    }
}
