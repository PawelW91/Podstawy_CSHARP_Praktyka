namespace PP0502B___Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ilosc_prob = int.Parse(Console.ReadLine());

            for (int i = 0; i < ilosc_prob; i++)
            {
                string[] line = Console.ReadLine().Split();
                int ilosc_liczb = int.Parse(line[0]);
                int[] tablica = new int[ilosc_liczb];

                for (int j = 0; j < ilosc_liczb; j++)
                {
                    tablica[j] = int.Parse(line[j + 1]);
                }

                for (int k = ilosc_liczb - 1; k >= 0; k--)
                {
                    Console.Write(tablica[k]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
