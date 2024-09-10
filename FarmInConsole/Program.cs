using FarmInConsole;

public class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("John", 100);
        Game game = new Game(player);
        game.Start();
    }
}
