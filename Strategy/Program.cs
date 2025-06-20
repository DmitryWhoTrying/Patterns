namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(100, 100);

            game.makeDecision();
        }
    }
}
