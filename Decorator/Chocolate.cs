﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Chocolate : Decorator
    {
        public override void Add()
        {
            base.Add();
            Console.WriteLine("Add chocolate!\n");
        }
    }
}
