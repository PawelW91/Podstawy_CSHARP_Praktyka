namespace JSPACE___Spacje
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            while ((x = Console.ReadLine()) != null)
            {
                while (x.Contains(' '))
                {
                    int l = 0;
                    l = x.Length;
                    for (int i = 0; i < l - 1; i++)
                    {
                        if (x[i] == ' ')
                        {
                            x = x.Remove(i, 1);
                            x = x.Substring(0, i) + char.ToUpper(x[i]) + x.Substring(i + 1);
                            l--;
                        }
                    }
                }
                Console.WriteLine(x);
            }
        }
    }
}
