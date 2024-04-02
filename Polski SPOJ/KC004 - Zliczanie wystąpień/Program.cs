namespace KC004___Zliczanie_wystąpień
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] inputs = line.Split(' ');

                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);
                int ile = 0;
                for (int i = 0; i < y; i++)
                {
                    if (int.Parse(inputs[2 + i]) == x)
                    {
                        ile++;
                    }
                }
                Console.WriteLine(ile);
            }
        }
    }
}
