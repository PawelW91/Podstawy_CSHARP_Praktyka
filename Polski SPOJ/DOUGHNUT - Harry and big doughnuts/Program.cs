namespace DOUGHNUT___Harry_and_big_doughnuts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t;
            ile_t = int.Parse(Console.ReadLine());

            while (ile_t-- > 0)
            {
                string[] input = Console.ReadLine().Split();
                int c = int.Parse(input[0]);
                int k = int.Parse(input[1]);
                int w = int.Parse(input[2]);

                if (c * w <= k)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
