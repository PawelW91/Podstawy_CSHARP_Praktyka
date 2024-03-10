using System.Globalization;

namespace JROWLIN___Równanie_liniowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x;
            string[] inputs = Console.ReadLine().Split(' ');
            a = double.Parse(inputs[0], CultureInfo.InvariantCulture);
            b = double.Parse(inputs[1], CultureInfo.InvariantCulture);
            c = double.Parse(inputs[2], CultureInfo.InvariantCulture);

            if (a == 0 && (c - b) != 0)
            {
                Console.WriteLine("BR");
            }
            else if (a == 0 && (c - b) == 0)
            {
                Console.WriteLine("NWR");
            }
            else
            {
                x = (c - b) / a;
                Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
