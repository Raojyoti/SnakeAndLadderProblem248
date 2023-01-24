namespace SnakeAndLadderSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the snake and ladder game");
            Console.WriteLine("---------------------------------------");
            Game game= new Game();  
            game.GameStart();
            Console.ReadLine();
        }
    }
}