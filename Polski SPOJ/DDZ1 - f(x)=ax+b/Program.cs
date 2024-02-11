using System.Threading.Channels;

namespace DDZ1___f_x__ax_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            Console.Write("f(x)=");

            if(a!=0&&Math.Abs(a)!=1)        Console.Write(a+"x"); 
            if(a==1)                        Console.Write("x");
            if(a==-1)                       Console.Write("-x");      
            if(b>0&&a!=0)                   Console.WriteLine("+"+b);
            else if (b!=0)                  Console.WriteLine(b);
            if (a == 0 && b == 0)           Console.WriteLine("0");
        }
    }
}
