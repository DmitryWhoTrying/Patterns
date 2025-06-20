using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Converter
    {
        public Converter() 
        {
            Console.WriteLine("I am Convertor\n");
        }

        public double convert(double value, string from, string to)
        {
            ToEuroConvertor TEC = new ToEuroConvertor();
            TEC.HardBussinessLogic();
            FromEuroConvertor FEC = new FromEuroConvertor();
            FEC.EvenMoreHardBussinesLogic();

            double converted_value = 0.0;//Конечно можно и получше расписать,
            //но суть одна, скрываем какую-то сложную логику и предоставляем
            //упрощенный интерфейс

            return converted_value;
        }

    }
}
