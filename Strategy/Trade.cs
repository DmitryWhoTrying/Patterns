using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Trade : Strategy
    {
        public void Decision()
        {
            Console.WriteLine("Try to trade");
        }
    }
}
