namespace AL_06_01___Reszta_z_dzielenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_t = int.Parse(Console.ReadLine());
            while (ile_t-->0)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                int a = int.Parse(parts[0]);
                int b = int.Parse(parts[1]);
                int r;
                r=a%b;
                if (r < 0) { r += Math.Abs(b); Console.WriteLine(r); }
                else { Console.WriteLine(r); }
            }
        }
    }
}﻿
