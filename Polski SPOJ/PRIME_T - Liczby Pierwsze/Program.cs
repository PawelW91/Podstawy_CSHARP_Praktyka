namespace PRIME_T___Liczby_Pierwsze
{
    class Program
    {
        static bool IsPrime(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            int ile_t, x;
            ile_t = int.Parse(Console.ReadLine());
            for (int i = 0; i < ile_t; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x < 2)
                    Console.WriteLine("NIE");
                else if (IsPrime(x))
                    Console.WriteLine("TAK");
                else
                    Console.WriteLine("NIE");
            }
        }
    }
}
