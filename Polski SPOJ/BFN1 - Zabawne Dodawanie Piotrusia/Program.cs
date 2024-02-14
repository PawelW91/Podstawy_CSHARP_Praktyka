namespace BFN1___Zabawne_Dodawanie_Piotrusia
{
    class Program
    {
        static int ReverseNumber(int X)
        {
            int X1 = 0;
            while (X != 0)
            {
                X1 = X1 * 10 + X % 10;
                X /= 10;
            }
            return X1;
        }

        static void Main()
        {
            int ile_t = Convert.ToInt32(Console.ReadLine());
            while (ile_t > 0)
            {
                int X, X1, ile = 0;
                X = Convert.ToInt32(Console.ReadLine());
                X1 = ReverseNumber(X);

                if (X == X1)
                {
                    Console.WriteLine(X + " " + ile);
                }
                else
                {
                    while (!(X == X1))
                    {
                        ile++;
                        X += X1;
                        X1 = ReverseNumber(X);
                    }
                    Console.WriteLine(X + " " + ile);
                    ile = 0;
                }
                ile_t--;
            }
        }
    }
}
