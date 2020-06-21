using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_s16451.Models
{
    public class Player_Team
    {
        public int IdPlayer { get; set; }
        public Player Player { get; set; }
        public int IdTeam { get; set; }
        public Team Team { get; set; }
        public int NumOnShirt { get; set; }
        public string Comment { get; set; }
    }
}
