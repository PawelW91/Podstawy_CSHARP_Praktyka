namespace PTCLTZ___Problem_Collatza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());
            while (ile_t-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(znajdz_n(x));
            }
        }
        static int znajdz_n(int x)
        {
            int n = 0;
            while (x != 1)
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                }
                else
                {
                    x = 3 * x + 1;
                }
                n += 1;
            }
            return n;
        }
    }
}
