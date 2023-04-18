namespace Klikkerspill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clickerGame = new ClickerGame();
            var commandSet = new CommandSet(clickerGame);

            while (true)
            {
                clickerGame.Show();
                var cmdFromUser = Console.ReadKey(true).KeyChar;
                commandSet.RunCommand(cmdFromUser);
            }
        }
    }
}