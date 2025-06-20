using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Game
    {
        int heroHealth, banditHealth;
        Strategy? strategy;

        public Game(int heroHealth, int banditHealth)
        {
            this.heroHealth = heroHealth;
            this.banditHealth = banditHealth;
        }

        public void makeDecision()
        {
            if (heroHealth > banditHealth)
                strategy = new Attack();
            else if (heroHealth == banditHealth)
                strategy = new Trade();
            else
                strategy = new Run();

            strategy.Decision();
        }
    }
}
