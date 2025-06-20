namespace Builder
{
    internal class Program
    {
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
