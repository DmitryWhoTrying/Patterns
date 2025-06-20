using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class GameCreator : DefaultCreator
    {
        public static new Game CreateMethod(string type)
        {
            if (type == "CounterStrice")
                return new CounterStrike();
            else if (type == "Dota")
                return new Dota();
            else
                return DefaultCreator.CreateMethod(type);
        }
    }
}
