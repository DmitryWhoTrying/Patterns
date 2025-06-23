using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal abstract class Builder
    {
        Engine? engine;
        public void Reset() { engine = null; }
        public void SetEngine(Engine engine) { this.engine = engine; }
    }
}
