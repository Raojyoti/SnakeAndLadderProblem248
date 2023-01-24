namespace SnakeAndLadderSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the snake and ladder game");
            Console.WriteLine("---------------------------------------");
            while (true)
            {
                Console.WriteLine("Please select given options");
                Console.WriteLine("1.Player1StartPosition\n2.Player1RollsDice\n3.PlayerThenCheckOptions\n4.PlayerReachestheWinningPosition\n5.EnsurePlayerGetExcatWinningPosition\n6.ReportNumberOfTimesDicePlayedToWinGame\n8.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                Game game = new Game();
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        game.GameStart();
                        break;
                    case 2:
                        Console.Clear();
                        game.PlayerRollsDice();
                        break;
                    case 3:
                        Console.Clear();
                        game.CheckOptions();
                        break;
                    case 4:
                        Console.Clear();
                        game.WinningPosition();
                        break;
                    case 5:
                        Console.Clear();
                        game.EnsurePlayerGetExcatWinningPosition();
                        break;
                    case 6:
                        game.ReportNumberOfTimesDicePlayedToWinGame();
                        break;
                    case 8:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select only given options");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}