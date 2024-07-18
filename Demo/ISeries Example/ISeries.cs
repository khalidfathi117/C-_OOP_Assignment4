using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9.Demo.ISeries_Example
{
    internal interface ISeries
    {
        public int Current { get; set; }
        public void getNext();
        public void Reset()
        {
            Current = 0;
        }
    }
}
