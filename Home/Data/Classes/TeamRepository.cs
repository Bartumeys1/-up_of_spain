using Home.Data.Data.Interfaces;
using Home.Data.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Data.Data.Classes
{
    public class TeamRepository : ITeamRepository
    {
        public void AddTeam(Team team)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Teams.Add(team);
                context.SaveChanges();
            }
        }

        public List<Team> GetAllTeams()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var res = context.Teams.Include(t => t.Players).ToList();

                return res;
            }
        }
    }
}
