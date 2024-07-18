using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9.Demo.ISeries_Example
{
    internal class SeriesByFour : ISeries
    {
        public int Current { get; set; }
        public void getNext()
        {
            Current += 4;
        }
    }
}
