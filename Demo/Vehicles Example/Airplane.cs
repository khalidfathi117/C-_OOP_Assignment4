using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9.Demo.Vehicles_Example
{
    internal class Airplane : Vehicle, IFlyable, IMovable
    {
        void IMovable.Backward()
        {
            Console.WriteLine("I am Airplane Moving Backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("I am Airplane Flying Backward");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("I am Airplane Moving Forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("I am Airplane Flying Forward");
        }

        void IMovable.Left()
        {
            Console.WriteLine("I am Airplane Moving Left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("I am Airplane Flying Left");
        }

        void IMovable.Right()
        {
            Console.WriteLine("I am Airplane Moving Right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("I am Airplane Flying Right");
        }
    }
}
