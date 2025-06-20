using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class GameCreator
    {
        public static Game CreateMethod(string type) 
        {
            if (type == "CounterStrice")
                return new CounterStrike();
            else if (type == "Dota")
                return new Dota();
            else
                throw new ArgumentException("Invalid argument type");
        }
    }
}
