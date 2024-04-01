namespace JWSPLIN___Współliniowość_punktów
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t;
            if (int.TryParse(Console.ReadLine(), out t))
            {
                while (t-- > 0)
                {
                    string[] inputs = Console.ReadLine().Split();

                    
                        int[] x = new int[3];
                        int[] y = new int[3];
                        for (int i = 0; i < 3; i++)
                        {
                            x[i] = int.Parse(inputs[2 * i]);
                            y[i] = int.Parse(inputs[2 * i + 1]);
                        }

                        // Obliczanie wyznacznika macierzy z punktami
                        int det = x[0] * (y[1] - y[2]) + x[1] * (y[2] - y[0]) + x[2] * (y[0] - y[1]);

                        // Jeśli wyznacznik wynosi 0, punkty są współliniowe
                        if (det == 0)
                        {
                            Console.WriteLine("TAK");
                        }
                        else
                        {
                            Console.WriteLine("NIE");
                        }
                }
            }
        }
    }
}
