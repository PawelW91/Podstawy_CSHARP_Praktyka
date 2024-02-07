using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Details();
            Car audi=new Car("Audi","red");
            Car bmw = new Car("BMW",100);
            audi.Drive();
            bmw.Drive();
            audi.Details();
            string input = Console.ReadLine();
            if (input == "1" ) 
            {
                audi.Stop();
            }
            else
            {
                audi.Drive();
            }            
        }
    }
}
