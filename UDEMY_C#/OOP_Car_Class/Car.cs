using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Car
    {
        private string _name;
        public int _hp;
        string _color;
        public Car(string name = "Car", int hp = 0, string color="black") {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine($"{_name} was created");
        }
        public Car(string name = "Car", string color = "black")
        {
            _name = name;
            _color = color;
            Console.WriteLine($"{_name} was created");
        }
        public Car()
        {
            _name = "Car";
            _hp = 100;
            _color = "black";
            Console.WriteLine($"{_name} was created");
        }

        public void Drive()
        { Console.WriteLine($"{_name} is driving"); }
        public void Stop()
        {
            Console.WriteLine($"{_name} is stoping");
        }
        public void Details()
        {
            Console.WriteLine($"{_name} has {_hp}HP & it is {_color} color");
        }
    }
}
