using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Data.Data.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string PlayerFIO { get; set; }
        //public string Country { get; set; }
        //public int PlayerNumber { get; set; }
        //public string Position { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
