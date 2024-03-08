using System.Globalization;

namespace ROWNANIE___Równanie_kwadratowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] values = line.Split(' ');
                double a = double.Parse(values[0], CultureInfo.InvariantCulture);
                double b = double.Parse(values[1], CultureInfo.InvariantCulture);
                double c = double.Parse(values[2], CultureInfo.InvariantCulture);

                double x = X(a, b, c);
                Console.WriteLine(x);
            }
        }
        static double X(double a, double b, double c)
        {
            double y = b * b - 4 * a * c;
            if (y > 0)
                return 2;
            else if (y == 0)
                return 1;
            else
                return 0;
        }
    }
}
