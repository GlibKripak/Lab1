namespace Lab1;
public class Program
{
    public static void playGame(GameAccount user1, GameAccount user2, int rating)
    {
        if (rating >= 0)
        {
            Random rnd = new Random();
            int value1 = rnd.Next(0, 2);
            if (value1 < 1)
            {
                user1.WinGame(user2.UserName, rating);
                user2.LoseGame(user1.UserName, rating);
            }
            else
            {
                user2.WinGame(user1.UserName, rating);
                user1.LoseGame(user2.UserName, rating);
            }
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
    public static void Main(string[] args)
    {
        GameAccount user1 = new GameAccount("Assassin");
        GameAccount user2 = new GameAccount("Tamplier");
        playGame(user1, user2, -5);
        playGame(user1, user2, 4);
        playGame(user1, user2, 6);
        playGame(user1, user2, 3);
        playGame(user1, user2, -1);
        playGame(user1, user2, 8);
        user1.GetStats();
        user2.GetStats();
        Console.WriteLine("\nCurrent rating: user1 - " + user1.Rating + "; user2 - " + user2.Rating);
    }
}