namespace Decorator
{
    //Декоратор
    //Идея: Создание класса-обертки, чтобы дать
    //      дополнительный функционал объекту, а не классу в целом

    //Достоинства: 
    //* гибкость и расширяемость
    //* соблюдение принципа открытости-закрытости
    //* улучшение читаемости

    //Недостатки
    //* Усложнение кода
    //* Риск неочевидного поведения
    //* Неэффективность для большого числа оберток

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to brew capuccino!\n");
            Decorator capuccino = new Milk();
            capuccino.SetComponent(new Espresso());

            capuccino.Add();

            Console.WriteLine("Time to brew machiato!\n");
            Decorator machiato = new Chocolate();
            machiato.SetComponent(capuccino);
            
            machiato.Add();
        }
    }
}
