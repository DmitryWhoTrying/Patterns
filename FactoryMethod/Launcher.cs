using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Launcher
    {
        public void Play()
        {
            Game game = RunGame();
            game.Play();
        }

        protected abstract Game RunGame();
    }
}
