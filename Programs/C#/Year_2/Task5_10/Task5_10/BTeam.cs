public class BTeam
{
    private string name;
    private Node<BPlayer> players;
    private int players_Amount;

    public BTeam(string name, Node<BPlayer> players)
    {
        this.name = name;
        this.players = players;
        this.players_Amount = 0;
    }

    public BTeam(string name)
    {
        this.name = name;
        this.players = null;
        this.players_Amount = 0;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public void AddPlayer(BPlayer player)
    {
        this.players = new Node<BPlayer>(player, this.players);
    }

    public double AverageScore()
    {
        int sum = 0;
        for (Node<BPlayer> i = players; i != null; i = i.Next)
            sum += i.GetValue().Score;
        return sum / players_Amount;
    }

    public void UpdatePlayerScore(string name,int score)
    {
        for (Node<BPlayer> i = players; i != null; i = i.Next)
            if (i.Value.Name == name)
                i.Value.Score = score;
    }

    public BPlayer MaxScorePlayer()
    {
        BPlayer maxPlayer = players.Value;
        for (var i = players; i != null; i = i.Next)
            if (maxPlayer.Score < i.Value.Score)
                maxPlayer = i.Value;
        return maxPlayer;
    }

    public override string ToString()
    {
        string rtn = $"Name: {this.name}\n";
        int cnt = 1;
        for (var i = players; i != null; i = i.Next)
        {
            rtn += $"Player {cnt} -> {i.Value}\n\n";
            cnt++;
        }
        return rtn;
    }
}

