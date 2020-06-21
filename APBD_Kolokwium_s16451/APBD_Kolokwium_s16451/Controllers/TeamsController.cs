using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APBD_Kolokwium_s16451.Models;
using APBD_Kolokwium_s16451.DTOs.Requests;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace APBD_Kolokwium_s16451.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly KolokwiumDbContext _context;

        public TeamsController(KolokwiumDbContext context)
        {
            _context = context;
        }

        [HttpPost("{id}/players")]
        public IActionResult AssignPlayer(int id, AssignPlayerRequest request)
        {
            var team = _context.Team.SingleOrDefault(t => t.IdTeam == id);
            if (team == null)
            {
                return NotFound("Nie ma takeij drużyny");
            }

            var player = _context.Player
                .SingleOrDefault(p =>
                    p.FirstName == request.FirstName && 
                    p.LastName == request.LastName &&
                    p.DateOfBirth == request.GetBirthDate()
                   );
            if (player == null)
            {
                return NotFound("Nie ma takeiego gracza");
            }

            if(player.DateOfBirth.Year > team.MaxAge)
            {
                return NotFound("Gracz zbyt stary");
            }

            var playerTeam = _context.Player_Team.SingleOrDefault(pt => pt.IdPlayer == player.IdPlayer && pt.IdTeam == team.IdTeam);
            if(playerTeam != null)
            {
                return NotFound("Gracz jest już przypisany");
            }

            playerTeam = new Player_Team();
            playerTeam.IdPlayer = player.IdPlayer;
            playerTeam.IdTeam = team.IdTeam;
            playerTeam.NumOnShirt = request.NumOnShirt;
            playerTeam.Comment = request.comment;

            player.Player_Teams.Add(playerTeam);
            team.Player_Teams.Add(playerTeam);

            _context.Attach(playerTeam);
            _context.Attach(team);
            _context.Attach(player);
            _context.SaveChanges();
            return Ok("Aktualizacja ukończona");
        }
    }
}
