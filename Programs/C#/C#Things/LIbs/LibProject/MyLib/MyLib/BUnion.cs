
public class BUnion
{
    Node<BTeam> teams;

    public BUnion()
    {
        this.teams = null;
    }

    public BUnion(Node<BTeam> teams)
    {
        this.teams.Value = teams.Value;
        Node<BTeam> temp = this.teams.Next;
        teams = teams.Next;
        while (teams != null)
        {
            temp.Value = teams.Value;
            temp = temp.Next;
            teams = teams.Next;
        }
    }

    public void AddTeam(BTeam team)
    {
        this.teams = new Node<BTeam>(team, this.teams);
    }

    public void PrintAverages()
    {
        Node<BTeam> temp = this.teams;
        for (var i = temp; i != null; i = i.Next)
            System.Console.WriteLine($"Name: {i.Value.Name},Average score: {i.Value.AverageScore()}\n");
    }

    public BPlayer MaxPlayerScore()
    {
        if (this.teams == null)
            return null;
        BPlayer Maxplayer = teams.Value.MaxScorePlayer();
        Node<BTeam> temp = this.teams.Next;
        while (temp != null)
        {
            BPlayer tempPlayer = temp.Value.MaxScorePlayer();
            if (Maxplayer.Score < tempPlayer.Score)
                Maxplayer = tempPlayer;
            temp = temp.Next;
        }
        return Maxplayer;
    }

    public override string ToString()
    {
        string rtn = "Union Teams:\n";
        Node<BTeam> temp = this.teams;
        while (temp != null)
        {
            rtn += $"{temp.Value.ToString()}\n\n";
            temp = temp.Next;
        }
        return rtn;
    }
}

