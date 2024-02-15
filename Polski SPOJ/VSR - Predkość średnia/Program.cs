namespace VSR___Predkość_średnia
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            int.TryParse(Console.ReadLine(), out ile);

            for (int i = 0; i < ile; i++)
            {
                string line = Console.ReadLine();
                string[] values = line.Split(' ');

                int v1, v2;
                int.TryParse(values[0], out v1);
                int.TryParse(values[1], out v2);

                Console.WriteLine((2 * (v1 * v2)) / (v1 + v2));
            }
        }
    }
}
