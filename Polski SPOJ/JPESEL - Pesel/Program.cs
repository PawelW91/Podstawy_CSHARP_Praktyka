namespace JPESEL___Pesel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());

            while (ile_t-- > 0)
            {
                string p = Console.ReadLine();
                int s = 1 * (p[0] - '0') + 3 * (p[1] - '0') + 7 * (p[2] - '0') + 9 * (p[3] - '0') + 1 * (p[4] - '0') +
                        3 * (p[5] - '0') + 7 * (p[6] - '0') + 9 * (p[7] - '0') + 1 * (p[8] - '0') + 3 * (p[9] - '0') +
                        1 * (p[10] - '0');

                if (s % 10 == 0)
                    Console.WriteLine("D");
                else
                    Console.WriteLine("N");
            }
        }
    }
}
