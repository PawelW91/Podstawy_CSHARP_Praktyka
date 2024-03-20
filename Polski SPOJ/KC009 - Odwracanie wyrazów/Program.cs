namespace KC009___Odwracanie_wyrazów
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            while ((x = Console.ReadLine()) != null)
            {
                for (int i = x.Length - 1; i >= 0; i--)
                {
                    Console.Write(x[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
