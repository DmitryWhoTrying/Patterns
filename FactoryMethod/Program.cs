namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game MyGame = GameCreator.CreateMethod("Dota");
        }
    }
}
