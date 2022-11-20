namespace Lab1;
public class GameAccount
{
    public string UserName;
    public int Rating;
    public int GamesCount;
    public List<Game> stats = new List<Game>();
    public GameAccount(string UserName)
    {
        this.UserName = UserName;
        this.Rating = 10;
        this.GamesCount = 0;
    }
    public void WinGame(string opponentName, int rating)
    {
        this.Rating+=rating;
        this.GamesCount++;
        Game gm = new Game(this.UserName, opponentName, rating, this.GamesCount - 1);
        stats.Add(gm);
    }
    public void LoseGame(string opponentName, int rating)
    {
        if (this.Rating>rating)
        {
            this.Rating-=rating;
        }
        else
        {
            this.Rating=1;
        }
        this.GamesCount++;
        Game gm = new Game(opponentName, this.UserName,  rating, this.GamesCount - 1);
        stats.Add(gm);
    }
    public void GetStats()
    {
        for (int i = 0; i < this.stats.Count; i++)
        {
            Console.WriteLine("\nUsername - " + this.UserName);
            Console.WriteLine("Game" + stats[i].number + "(rating " + stats[i].rating + "):");
            Console.WriteLine("Win - " + stats[i].winner + "; Lose - " + stats[i].looser + ";");
        }
    }
}