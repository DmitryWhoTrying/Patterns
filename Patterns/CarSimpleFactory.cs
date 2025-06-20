using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class CarSimpleFactory
    {
        public CarSimpleFactory() 
        {
            Console.WriteLine("I am simple factory\n");
        }

        public Car create(string type)
        {
            if (type == null) 
                throw new ArgumentNullException("type not defined");
            if (type == "Golf")
                return new Golf();
            else if (type == "Passat")
                return new Passat();
            else
                throw new ArgumentException("Wrong type");
        }
    }
}
