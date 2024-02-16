namespace SUMA___Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, x;
            while (int.TryParse(Console.ReadLine(), out x))
            {
                i += x;
                Console.WriteLine(i);
            }
        }
    }
}
