namespace Decorator
{
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
