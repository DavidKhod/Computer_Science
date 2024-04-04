public class BTeam
{
    private string name;
    private BPlayer[] players;
    private int players_Amount;
    public const int MAX_PLAYER_AMOUNT = 24;

    public BTeam(string name, BPlayer[] players)
    {
        this.name = name;
        this.players = players;
        this.players_Amount = 0;
        for (int i = 0; i < players.Length && players[i] != null; i++)
            this.players_Amount++;
    }

    public BTeam(string name)
    {
        this.name = name;
        this.players = new BPlayer[MAX_PLAYER_AMOUNT];
        this.players_Amount = 0;
        for (int i = 0; i < players.Length; i++)
            players[i] = null;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public BPlayer[] Players
    {
        get { return this.players; }
        set { this.players = value; }
    }

    public void AddPlayer(BPlayer player)
    {
        this.players[players_Amount] = player;
        this.players_Amount++;
    }

    public double AverageScore()
    {
        int sum = 0;
        for (int i = 0; i < players_Amount; i++)
        {
            sum += this.players[i].Score;
        }
        return sum / players_Amount;
    }

    public void UpdatePlayerScore(string name,int score)
    {
        for (int i = 0; i < players_Amount; i++)
        {
            if (players[i].Name == name)
                players[i].Score = score;
        }
    }
    public BPlayer MaxScorePlayer()
    {
        BPlayer maxPlayer = players[0];
        for (int i = 1; i < players_Amount; i++)
        {
            if (maxPlayer.Score < players[i].Score)
                maxPlayer = players[i];
        }
        return maxPlayer;
    }

    public override string ToString()
    {
        string rtn = $"Name: {this.name}\n";
        for (int i = 0; i < players_Amount; i++)
        {
            rtn += $"Player {i + 1} -> {this.players[i]}\n\n";
        }
        return rtn;
    }
}

