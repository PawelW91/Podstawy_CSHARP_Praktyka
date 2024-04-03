namespace JHTMLLET___Tagi_HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            while ((x = Console.ReadLine()) != null)
            {
                int l = x.Length;
                for (int i = 1; i < l; i++)
                {
                    if (x[i - 1] == '<')
                    {
                        while (x[i] != '>')
                        {
                            x = x.Substring(0, i) + char.ToUpper(x[i]) + x.Substring(i + 1);
                            i++;
                        }
                    }
                }
                Console.WriteLine(x);
            }
        }
    }
}
