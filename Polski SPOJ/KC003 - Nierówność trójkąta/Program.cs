namespace KC003___Nierówność_trójkąta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] tokens = input.Split(' ');

                if (tokens.Length != 3)
                {
                    Console.WriteLine("Invalid input");
                    continue; // Move to the next iteration of the loop
                }

                if (!float.TryParse(tokens[0], System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float a) ||
                    !float.TryParse(tokens[1], System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float b) ||
                    !float.TryParse(tokens[2], System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float c))
                {
                    Console.WriteLine("Invalid input");
                    continue; // Move to the next iteration of the loop
                }

                if (a + b > c && a + c > b && b + c > a)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
