﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class DefaultCreator
    {
        public static Game CreateMethod(string type)        
        {
            return new Tetris();
        }
    }
}
