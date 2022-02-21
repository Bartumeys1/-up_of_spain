using Home.Data.Data.Interfaces;
using Home.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Services
{
    public class MatchService
    {
        public readonly IMatchRepository _matchRepository;
        public MatchService(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public void Add(Match match)
        {
            var oldMatch = _matchRepository.GetMatch(match.Team1.Name,match.Team2.Name,match.Date);
            if(oldMatch == null)
            _matchRepository.AddMatch(match);
        }

        public void PrintMatchses()
        {
            var res = _matchRepository.GetAllMatchs();

            if(res != null)
            foreach (var item in res)
            {
                Console.WriteLine($"{item.Id}: {item.Date.ToShortDateString()}\nTeam1: {item?.Team1?.Name}\nTeam2: {item?.Team2?.Name}\nGoal team 1: {item.Team1Goals}\nGoal team 2: {item.Team2Goals}");
                Console.WriteLine();
            }
        }
    }
}
