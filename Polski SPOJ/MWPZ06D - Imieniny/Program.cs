namespace MWPZ06D___Imieniny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t;
            if (int.TryParse(Console.ReadLine(), out ile_t))
            {
                while (ile_t-- > 0)
                {
                    string[] input = Console.ReadLine().Split();
                    int L = int.Parse(input[0]);
                    int C = int.Parse(input[1]);
                    L -= 1;
                    if (L == 0)
                    {
                        Console.WriteLine("TAK");
                    }
                    else if (C % L == 0)
                    {
                        Console.WriteLine("NIE");
                    }
                    else
                    {
                        Console.WriteLine("TAK");
                    }
                }
            }
        }
    }
}
