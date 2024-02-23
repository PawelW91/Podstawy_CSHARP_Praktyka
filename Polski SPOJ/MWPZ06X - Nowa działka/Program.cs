namespace MWPZ06X___Nowa_działka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());
            while (ile_t-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(x * x);
            }
        }
    }
}
