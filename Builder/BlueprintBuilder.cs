using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class BlueprintBuilder : Builder
    {
        Blueprint result;

        public BlueprintBuilder()
        {
            Console.WriteLine("I am blueprint builder\n");
        }
        public new void Reset()
        {
            result = new Blueprint();
        }

        public new void SetEngine(Engine engine)
        {
            result.engine = engine;
        }
        public Blueprint getResult()
        { 
            return result;
        }
    }
}
