﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Attack : Strategy
    {
        public void Decision()
        {
            Console.WriteLine("Try to attack");
        }
    }
}
