using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_s16451.Models
{
    public class Player
    {
        public int IdPlayer { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ICollection<Player_Team> Player_Teams { get; set; }
    }
}
