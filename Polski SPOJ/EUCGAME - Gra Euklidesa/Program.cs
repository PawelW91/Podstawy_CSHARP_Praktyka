namespace EUCGAME___Gra_Euklidesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());

            int[,] x = new int[ile_t, 2];
            for (int i = 0; i < ile_t; i++)
            {
                string[] input = Console.ReadLine().Split();
                x[i, 0] = int.Parse(input[0]);
                x[i, 1] = int.Parse(input[1]);
            }

            for (int i = 0; i < ile_t; i++)
            {
                int wynik = Fwynik(x[i, 0], x[i, 1]);
                Console.WriteLine(wynik);
            }
        }
        static int Fwynik(int x, int y)
        {
            while (y != 0)
            {
                int p = y;
                y = x % y;
                x = p;
            }
            return 2 * x;
        }
    }
}
