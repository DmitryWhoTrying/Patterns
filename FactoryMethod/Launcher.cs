using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Launcher
    {
        Game? game;
        public void Play()
        {
            game = RunGame();
            game.Play();
        }

        protected abstract Game RunGame();
    }
}
