namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new RussianFactory();
            factory.create("Passat");
        }
    }
}
