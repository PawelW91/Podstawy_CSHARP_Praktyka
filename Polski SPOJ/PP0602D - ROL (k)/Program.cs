namespace PP0602D___ROL__k_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            int[] t = new int[x];
            int[] mem = new int[y];

            string[] arrayInput = Console.ReadLine().Split();
            for (int i = 0; i < x; i++)
            {
                t[i] = int.Parse(arrayInput[i]);
            }

            for (int j = 0; j < y; j++)
            {
                mem[j] = t[j];
            }

            for (int i = y; i < x; i++)
            {
                t[i - y] = t[i];
            }

            int p = y;
            for (int z = 0; z < y; z++)
            {
                t[x - z - 1] = mem[p - 1];
                p--;
            }

            foreach (int num in t)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
