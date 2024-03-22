namespace SKARBFI___SkarbFinder
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
                    int ile;
                    if (int.TryParse(Console.ReadLine(), out ile))
                    {
                        int k = 0, z = 0, x = 0, y = 0;
                        for (int i = 0; i < ile; i++)
                        {
                            string[] input = Console.ReadLine().Split();
                            if (input.Length == 2 && int.TryParse(input[0], out k) && int.TryParse(input[1], out z))
                            {
                                if (k == 0) { y += z; }
                                if (k == 1) { y -= z; }
                                if (k == 2) { x -= z; }
                                if (k == 3) { x += z; }
                            }
                        }

                        if (x == 0 && y == 0) Console.WriteLine("studnia");
                        else if (x == 0 && y > 0) Console.WriteLine($"0 {y}");
                        else if (x == 0 && y < 0) Console.WriteLine($"1 {Math.Abs(y)}");
                        else if (x > 0 && y == 0) Console.WriteLine($"3 {x}");
                        else if (x < 0 && y == 0) Console.WriteLine($"2 {Math.Abs(x)}");
                        else if (x > 0 && y > 0)
                        {
                            Console.WriteLine($"0 {y}");
                            Console.WriteLine($"3 {x}");
                        }
                        else if (x > 0 && y < 0)
                        {
                            Console.WriteLine($"1 {Math.Abs(y)}");
                            Console.WriteLine($"3 {x}");
                        }
                        else if (x < 0 && y < 0)
                        {
                            Console.WriteLine($"1 {Math.Abs(y)}");
                            Console.WriteLine($"2 {Math.Abs(x)}");
                        }
                        else if (x < 0 && y > 0)
                        {
                            Console.WriteLine($"0 {y}");
                            Console.WriteLine($"2 {Math.Abs(x)}");
                        }

                        k = 0;
                        z = 0;
                        x = 0;
                        y = 0;
                    }
                }
            }
        }
    }
}
