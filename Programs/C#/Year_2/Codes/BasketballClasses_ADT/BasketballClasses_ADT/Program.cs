using System;

namespace BasketballClasses_ADT
{
    class Program
    {
        static void Main(string[] args)
        {
            BUnion union = new BUnion();
            BTeam team1 = new BTeam("Manchester United");
            BTeam team2 = new BTeam("Real Madrid");

            // Adding players to Manchester United
            BPlayer ronaldo = new BPlayer("Cristiano Ronaldo", 6.2);
            BPlayer pogba = new BPlayer("Paul Pogba", 6.4);
            BPlayer fernandes = new BPlayer("Bruno Fernandes", 5.11);
            BPlayer rashford = new BPlayer("Marcus Rashford", 6.1);

            team1.AddPlayer(ronaldo);
            team1.AddPlayer(pogba);
            team1.AddPlayer(fernandes);
            team1.AddPlayer(rashford);

            // Adding players to Real Madrid
            BPlayer benzema = new BPlayer("Karim Benzema", 6.2);
            BPlayer modric = new BPlayer("Luka Modric", 5.8);
            BPlayer ramos = new BPlayer("Sergio Ramos", 6.0);
            BPlayer hazard = new BPlayer("Eden Hazard", 5.9);

            team2.AddPlayer(benzema);
            team2.AddPlayer(modric);
            team2.AddPlayer(ramos);
            team2.AddPlayer(hazard);

            // Setting scores for players
            team1.UpdatePlayerScore(ronaldo.Name, 30); // Cristiano Ronaldo's score
            team1.UpdatePlayerScore(pogba.Name, 20);
            team1.UpdatePlayerScore(fernandes.Name, 25);
            team1.UpdatePlayerScore(rashford.Name, 18);

            team2.UpdatePlayerScore(benzema.Name, 28); // Karim Benzema's score
            team2.UpdatePlayerScore(modric.Name, 22);
            team2.UpdatePlayerScore(ramos.Name, 18);
            team2.UpdatePlayerScore(hazard.Name, 15);

            // Adding teams to the union
            union.AddTeam(team1);
            union.AddTeam(team2);

            // Testing methods
            Console.WriteLine("Average Score:");
            union.PrintAverages();

            Console.WriteLine($"\nTop Scorer: {union.MaxPlayerScore().ToString()}");

            Console.WriteLine("\nUnion Teams:");
            Console.WriteLine(union.ToString());
        }
    }
}
