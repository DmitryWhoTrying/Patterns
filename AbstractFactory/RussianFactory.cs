using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class RussianFactory : CarFactory
    {
        public RussianFactory() { Console.WriteLine("I am Russian Factory\n"); }
        public Car create(string type)
        {
            if (type == "Passat")
                return new RussianPassat();
            else if (type == "Golf")
                return new RussianGolf();
            else
                throw new ArgumentException("Invalid type");
        }
    }
}
