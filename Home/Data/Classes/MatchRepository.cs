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
    public class MatchRepository : IMatchRepository
    {
        public void AddMatch(Match match)
        {
            using(AppDbContext context = new AppDbContext())
            {
                context.Matches.Add(match);
                context.SaveChanges();
            }
        }

        public void DeleteMatch(Match match)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Matches.Remove(match);
                context.SaveChanges();
            }
        }

        public void DeleteMatch(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var res = context.Matches.Where(m=>m.Id==id).FirstOrDefault();
                if (res != null)
                    DeleteMatch(res);
            }
        }

        public List<Match> GetAllMatchs()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var res = context.Matches.ToList();
                return res;
            }
        }

        public List<Match> GetMatch(int id)
        {
            throw new NotImplementedException();
        }

        public List<Match> GetMatch(string teamName)
        {
            throw new NotImplementedException();
        }

        public List<Match> GetMatch(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Match GetMatch(string teamName1, string teamName2, DateTime date)
        {
            using(AppDbContext context = new AppDbContext())
            {
                var res = context.Matches.Where(m => m.Team1.Name == teamName1 && m.Team2.Name == teamName2 && m.Date.CompareTo(date) == 0).FirstOrDefault();
                return res;
            }
        }

        public void UpdateMatch(Match match)
        {
            throw new NotImplementedException();
        }
    }
}
