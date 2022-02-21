using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Data.Data.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Player> Players = new List<Player>();
    }
}
