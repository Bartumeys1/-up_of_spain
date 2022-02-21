using Home.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Home.Data.Data.Interfaces
{
   public interface IMatchRepository
    {
        public void  AddMatch(Match match);
        public void UpdateMatch(Match match);
        public void DeleteMatch(Match match);
        public void DeleteMatch(int id);
        public List<Match> GetAllMatchs();
        public List<Match> GetMatch(int id);
        public List<Match> GetMatch(string teamName);
        public List<Match> GetMatch(DateTime date);
        public Match GetMatch(string teamName1, string teamName2, DateTime date);

    }
}
