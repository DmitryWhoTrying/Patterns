namespace Facade
{
    //Фасад
    //Идея: скрыть сложную внутреннюю логику за простым интерфейсом
    //Плюс: Изоляция клиентов от компонентов сложной подсистемы
    //Минус: Фасад рискует стать божественным объектов
    //       привязанным ко всем классам программы
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
