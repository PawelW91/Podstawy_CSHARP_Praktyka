namespace PP0504B___StringMerge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());

            while (ile_t-- > 0)
            {
                string[] input = Console.ReadLine().Split();
                string x1 = input[0];
                string x2 = input[1];
                string S = StringMerge(x1, x2);
                Console.WriteLine(S);
            }
        }
        static string StringMerge(string x1, string x2)
        {
            string merged = "";
            int minLength = Math.Min(x1.Length, x2.Length);
            for (int i = 0; i < minLength; i++)
            {
                merged += x1[i];
                merged += x2[i];
            }
            return merged;
        }
    }
}
