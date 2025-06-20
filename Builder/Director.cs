using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        public Director() { Console.WriteLine("I am director\n"); }

        public void MakeElectricCar(Builder builder)
        {
            builder.Reset();
            builder.SetEngine(new ElectricEngine());
        }

        public void MakeDieselCar(Builder builder)
        {
            builder.Reset();
            builder.SetEngine(new DieselEngine());
        }
    }
}
