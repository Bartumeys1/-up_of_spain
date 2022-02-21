using Home.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Data.Data.Interfaces
{
    public interface ITeamRepository
    {
        public void AddTeam(Team team);
        public List<Team> GetAllTeams();
    }
}
