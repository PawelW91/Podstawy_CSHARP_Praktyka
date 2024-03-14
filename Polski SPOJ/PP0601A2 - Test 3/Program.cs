namespace PP0601A2___Test_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, ile = 0, yes = 0;
            while (true)
            {
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(x);

                if (x == 42)
                {
                    if (yes == 1)
                    {
                        ile++;
                        yes = 0;
                    }
                }
                else
                {
                    yes = 1;
                }

                if (ile > 2)
                    break;
            }
        }
    }
}
