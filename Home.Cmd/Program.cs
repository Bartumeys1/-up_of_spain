using Home.Data.Data.Classes;
using Home.Data.Data.Models;
using Home.Services;
using System;

namespace Home.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamService teamService = new TeamService(new TeamRepository());
            MatchService matchService = new MatchService(new MatchRepository());

            Player player1 = new Player() { PlayerFIO = "Dinis" };
            Player player2 = new Player() { PlayerFIO = "Anton" };
            Player player3 = new Player() { PlayerFIO = "Oleg" };
            Player player4 = new Player() { PlayerFIO = "August" };
            Player player5 = new Player() { PlayerFIO = "Miror" };

            Team team1 = new Team() { Name = "Team-1" };
            team1.Players.Add(player1);
            team1.Players.Add(player2);
            team1.Players.Add(player3);

            Team team2 = new Team() { Name = "Team-2" };
            team2.Players.Add(player4);
            team2.Players.Add(player5);

            //teamService.AddTeam(team1);
            //teamService.AddTeam(team2);

            //teamService.PrintTeams();

            Match match = new Match()
            {
                Team1 = team1,
                Team2 = team2,
                Team1Goals = 5,
                Team2Goals = 3,
                InformationGoal = "Test information fotbolist",
                Date = DateTime.Today
            };

           // matchService.Add(match);

            matchService.PrintMatchses();
        }
    }
}
