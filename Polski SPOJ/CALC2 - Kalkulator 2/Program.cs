namespace CALC2___Kalkulator_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Z = new int[100]; // Array to store values
            char dzialanie;
            int X, Y;

            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) // Exit loop if input is empty
                    break;

                string[] tokens = line.Split();
                dzialanie = char.Parse(tokens[0]);
                X = int.Parse(tokens[1]);
                Y = int.Parse(tokens[2]);

                switch (dzialanie)
                {
                    case 'z':
                        Z[X] = Y;
                        break;
                    case '+':
                        Console.WriteLine(Z[X] + Z[Y]);
                        break;
                    case '-':
                        Console.WriteLine(Z[X] - Z[Y]);
                        break;
                    case '*':
                        Console.WriteLine(Z[X] * Z[Y]);
                        break;
                    case '/':
                        if (Z[Y] != 0)
                            Console.WriteLine(Z[X] / Z[Y]);
                        else
                            Console.WriteLine(0); // Handle division by zero
                        break;
                    case '%':
                        if (Z[Y] != 0)
                            Console.WriteLine(Z[X] % Z[Y]);
                        else
                            Console.WriteLine(0); // Handle division by zero
                        break;
                    default:
                        break; // Ignore invalid operations
                }
            }
        }
    }
}
