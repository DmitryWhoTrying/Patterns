namespace Singleton
{
    internal class Program
    {
        //Одиночка
        //Идея: организация глобального доступа к экземпляру класса

        //Достоинства
        //*  Гарантирует что одновременно существует единственный экземпляр класса
        //*  Предоставляет глобальную точку доступа
        //* Реализует отложенную инициализацию

        //Недостатки
        //* Нарушает принцип единственной ответственности класса
        //* Маскирует плохой дизайн 
        //* Проблемы многопоточности
        //* Сложность отладки, требует создания Mock-объектов для тестирования

        static void Main(string[] args)
        {
            Singleton connection1 = Singleton.GetInstanse();

            Singleton connection2 = Singleton.GetInstanse();

            if (connection1 == connection2)
                Console.WriteLine("Got pointers on the same object");
        }
    }
}
