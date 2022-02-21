using Home.Data.Data.Interfaces;
using Home.Data.Data.Models;
using System;

namespace Home.Services
{
    public class TeamService
    {
        public readonly ITeamRepository teamRepository;
        public TeamService(ITeamRepository repository)
        {
            teamRepository = repository;
        }

        public void AddTeam(Team team)
        {
            teamRepository.AddTeam(team);
        }

        public void PrintTeams()
        {
            var teams = teamRepository.GetAllTeams();

            foreach (var team in teams)
            {
                Console.WriteLine($"Team: \"{team.Name}\" players:");
                int count = 1;
                foreach (var item in team.Players)
                {
                    Console.WriteLine($"{count++}: {item.PlayerFIO}");
                }

                Console.WriteLine();
            }
        }
    }
}
