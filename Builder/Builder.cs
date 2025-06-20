using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface Builder
    {
        public void Reset();
        public void SetEngine(Engine engine);
    }
}
