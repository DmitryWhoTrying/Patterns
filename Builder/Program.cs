namespace Builder
{
    internal class Program
    {

        //Строитель 
        //Идея: разделить создание сложного объекта
        //состоящего из множества вложенных объектов на шаги
        //Строитель позволяет создавать сложные объекты поэтапно
        //Директор позволяет выделить вызовы методов строителя в отдельный класс
        //Директор задает шаги, строитель - выполняет их

        //Плюсы
        //* Позволяет создавать продукты пошагово
        //* Позволяет использовать один и тот же код для создания
        //  различных продуктов
        //* Изоляция сложного кода сборки продукта от его бизнес логики

        //Минусы
        //* Усложняет код из-за дополнительных классов
        //* Клиент привязан к конкретным типам строителей, т.к.
        //  в интерфейсе директора не может быть метода получения результата

        static void Main(string[] args)
        {
            Director director = new Director();

            CarBuilder carBuilder = new CarBuilder();

            director.MakeElectricCar(carBuilder);
            Car car = carBuilder.getResult();


            BlueprintBuilder blueprintBuilder = new BlueprintBuilder();

            director.MakeDieselCar(blueprintBuilder);
            Blueprint blueprint = blueprintBuilder.getResult();
        }
    }
}
