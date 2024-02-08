using System.Globalization;

namespace FR_18_11___Skrzyżowanie_I
{
    class Program
    {
        static void Main()
        {
            int ileTestow;
            double l,d,a,V,t,x;

            ileTestow=int.Parse(Console.ReadLine());

            while (ileTestow-- > 0)
            {
                string[] input = Console.ReadLine().Split();
                l = double.Parse(input[0],CultureInfo.InvariantCulture);
                d = double.Parse(input[1],CultureInfo.InvariantCulture);
                a = double.Parse(input[2],CultureInfo.InvariantCulture);
                V = double.Parse(input[3],CultureInfo.InvariantCulture);
                t = double.Parse(input[4],CultureInfo.InvariantCulture);
                V = V/3.6;
                x = Math.Floor((a*Math.Pow(Math.Min(V/a,t),2.0)/2.0+V*Math.Max(t-V/a,0.0))/(l+d));
                Console.WriteLine(x.ToString("F0"));
            }
        }
    }
}
