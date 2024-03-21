namespace STOS___Stos
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stos = new Stack<int>();
            string polecenie;
            int liczba;

            while ((polecenie = Console.ReadLine()) != null)
            {
                if (polecenie == "-")
                {
                    if (stos.Count > 0)
                    {
                        Console.WriteLine(stos.Pop());
                    }
                    else
                    {
                        Console.WriteLine(":(");
                    }
                }
                else if (polecenie == "+")
                {
                    if (stos.Count < 10 && int.TryParse(Console.ReadLine(), out liczba))
                    {
                        stos.Push(liczba);
                        Console.WriteLine(":)");
                    }
                    else
                    {
                        Console.WriteLine(":(");
                    }
                }
            }
        }
    }
}
