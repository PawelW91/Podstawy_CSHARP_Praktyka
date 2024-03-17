namespace JSZYCER___Szyfr_Cezara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            while ((x = Console.ReadLine()) != null)
            {
                foreach (char c in x)
                {
                    if (c >= 'X' && c <= 'Z')
                    {
                        Console.Write((char)(c - 23));
                    }
                    else if (c >= 'A' && c <= 'Z')
                    {
                        Console.Write((char)(c + 3));
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
