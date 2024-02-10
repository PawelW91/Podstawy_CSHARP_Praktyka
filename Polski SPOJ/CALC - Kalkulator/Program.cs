namespace CALC___Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input="";
            bool koniec = false;
            while (!koniec)
            {
                input = Console.ReadLine();
                if (input !=null && input!="")
                {
                    string[] parts = input.Split(' ');
                    char dzialanie = char.Parse(parts[0]);
                    int a = int.Parse(parts[1]);
                    int b = int.Parse(parts[2]);
                    switch (dzialanie)
                    {
                        case '+': Console.WriteLine(a + b); break;
                        case '-': Console.WriteLine(a - b); break;
                        case '*': Console.WriteLine(a * b); break;
                        case '/': Console.WriteLine(a / b); break;
                        case '%': Console.WriteLine(a % b); break;
                    }
                }
                else { koniec=true; }  
            }
        }
    }
}﻿
