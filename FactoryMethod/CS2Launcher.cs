using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class CS2Launcher : Launcher
    {
        protected override Game RunGame()
        {
            return new CS2();
        }
    }
}
