namespace FR_15_01___Nowe_buty_do_biegania
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double k, m = 1.609344;
            k = double.Parse(Console.ReadLine());
            Console.WriteLine(k / m < 300 ? "NIE" : ((k / m > 300) && (k / m < 500)) ? "SPRAWDZIMY TWOJE OBECNE BUTY" : "TAK");
        }
    }

}
