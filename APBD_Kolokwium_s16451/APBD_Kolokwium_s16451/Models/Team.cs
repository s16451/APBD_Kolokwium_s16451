using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_s16451.Models
{
    public class Team
    {
        public int IdTeam { get; set; }
        public string TeamName { get; set; }
        public int MaxAge { get; set; }

        public ICollection<Player_Team> Player_Teams { get; set; }
        public ICollection<Championship_Team> Championship_Teams { get; set; }
    }
}
