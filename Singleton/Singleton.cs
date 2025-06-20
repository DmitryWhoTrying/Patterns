using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {
        static Singleton? instanse = null;

        private Singleton()
        {
            Console.WriteLine("I am new object!\n");
        }

        static public Singleton GetInstanse()
        {
            if (instanse == null)
            {
                instanse = new Singleton();
            }
            else
            {
                Console.WriteLine("Instance already exists\n");
            }
            return instanse;
        }
    }
}
