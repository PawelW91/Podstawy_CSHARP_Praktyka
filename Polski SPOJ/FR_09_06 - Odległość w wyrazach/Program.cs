namespace FR_09_06___Odległość_w_wyrazach
{
    using System;
    using System.Collections.Generic;
    public class Test
    {
        public static void Main()
        {
            int ileWyrazow = int.Parse(Console.ReadLine());

            while (ileWyrazow-- > 0)
            {
                string x = Console.ReadLine();
                List<char> litery = new List<char>();

                foreach (char c in x)
                {
                    litery.Add(c);
                }
                litery.Sort();
                int wynik = litery[litery.Count - 1] - litery[0];
                litery.Clear();
                Console.WriteLine(wynik);
            }
        }
    }
}
