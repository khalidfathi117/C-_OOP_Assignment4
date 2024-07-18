using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9.Demo.Vehicles_Example
{
    internal class Car : Vehicle, IMovable
    {
        public void Backward()
        {
            Console.WriteLine("I am Car Backward");
        }

        public void Forward()
        {
            Console.WriteLine("I am Car Forward");
        }

        public void Left()
        {
            Console.WriteLine("I am Car Left");
        }

        public void Right()
        {
            Console.WriteLine("I am Car Right");
        }
    }
}
