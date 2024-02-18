namespace POTSAM___Samolot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[4];
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < 4; i++)
            {
                x[i] = int.Parse(input[i]);
            }

            Console.WriteLine(x[0] * x[1] + x[2] * x[3]);
        }
    }
}
