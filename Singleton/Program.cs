namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton connection1 = Singleton.GetInstanse();

            Singleton connection2 = Singleton.GetInstanse();

            if (connection1 == connection2)
                Console.WriteLine("Got pointers on the same object");
        }
    }
}
