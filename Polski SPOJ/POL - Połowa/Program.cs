namespace POL___Połowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());

            while (ile_t-- > 0)
            {
                string x = Console.ReadLine();
                int l = x.Length / 2;
                x = x.Remove(l);
                Console.WriteLine(x);
            }
        }
    }
}
