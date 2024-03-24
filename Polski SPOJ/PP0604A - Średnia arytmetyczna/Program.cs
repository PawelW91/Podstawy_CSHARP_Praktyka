namespace PP0604A___Średnia_arytmetyczna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t;
            if (int.TryParse(Console.ReadLine(), out ile_t))
            {
                for (int i = 0; i < ile_t; i++)
                {
                    string[] parts = Console.ReadLine().Split();
                    int ile_l = int.Parse(parts[0]);

                    double suma = 0;
                    double sr, x, y, z, szuk = 0; // Initialize szuk with a default value
                    double[] liczby = new double[ile_l];

                    for (int j = 0; j < ile_l; j++)
                    {
                        double liczba;
                        if (double.TryParse(parts[j + 1], out liczba))
                        {
                            liczby[j] = liczba;
                            suma += liczba;
                        }
                    }

                    x = suma;
                    y = ile_l;
                    sr = x / y;

                    double[] zblizona = new double[ile_l];
                    z = 99;

                    for (int k = 0; k < ile_l; k++)
                    {
                        zblizona[k] = Math.Abs(sr - liczby[k]);
                        if (z > zblizona[k])
                        {
                            z = zblizona[k];
                            szuk = liczby[k];
                        }
                    }
                    Console.WriteLine(szuk);
                }
            }
        }
    }
}
