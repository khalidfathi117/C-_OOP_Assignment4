using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9.Question_1
{
    internal class Circle : ICircle
    {
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"I am Circle with Area = {Area}");
        }
    }
}
