using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class DotaLauncher : Launcher
    {
        protected override Game RunGame()
        {
           return new Dota();
        }
    }
}
