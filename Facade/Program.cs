namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 143324;
            string from = "Eifel's gold", to = "Ragnar's silver";

            Converter converter = new Converter();

            double res = converter.convert(money, from, to);
        }
    }
}
