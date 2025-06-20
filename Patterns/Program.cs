namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CarSimpleFactory factory = new CarSimpleFactory();
            factory.create("Passat");
            factory.create("Golf");
        }
    }
}
