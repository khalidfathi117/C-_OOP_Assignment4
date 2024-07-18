using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9.Question_1
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"I am Rectangle with Area = {Area}");
        }
    }
}
