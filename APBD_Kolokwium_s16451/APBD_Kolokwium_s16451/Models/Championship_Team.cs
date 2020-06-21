using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_s16451.Models
{
    public class Championship_Team
    {
        public int IdTeam { get; set; }
        public Team Team {get; set;}
        public int IdChampionship { get; set; }
        public Championship Championship { get; set; }
        public float Score { get; set; }
    }
}
