using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Espresso : Component
    {
        public override void Add()
        {
            Console.WriteLine("Add espresso!\n");
        }
    }
}
