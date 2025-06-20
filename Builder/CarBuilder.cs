using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CarBuilder : Builder
    {
        Car result;

        public CarBuilder()
        {
            Console.WriteLine("I am Car Builder\n");
        }
        public void Reset()
        {
            result = new Car();
        }

        public void SetEngine(Engine engine)
        {
            result.engine = engine;
        }
        public Car getResult() { return result; }
    }
}
