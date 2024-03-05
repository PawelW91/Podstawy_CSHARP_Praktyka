using System.Globalization;

namespace ETI06F1___Pole_pewnego_koła
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string W = Console.ReadLine(); // dane wejściowe
            W = W.Replace(',', '.'); // zamiana przecinków na kropki w inpucie

            string[] inputs = W.Split();
            double r = double.Parse(inputs[0], CultureInfo.InvariantCulture); // promień sfery
            double d = double.Parse(inputs[1], CultureInfo.InvariantCulture); // odległość między środkami sfery

            double x; // promień szukanego koła
            double S; // pole szukanego koła
            double pi = 3.141592654; // double pi = Math.PI;

            S = pi * Math.Pow(Math.Sqrt(r * r - (0.5 * d) * (0.5 * d)), 2);
            Console.WriteLine(S.ToString("F2")); // Formatowanie do dwóch miejsc po przecinku
        }
    }
}
