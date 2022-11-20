namespace Lab1;
public class Game
{
    public int rating;
    public int number;
    public string winner;
    public string looser;
    public Game(string winner, string looser, int rating, int number)
    {
        this.rating = rating;
        this.number = number;
        this.winner = winner;
        this.looser = looser;
    }
}