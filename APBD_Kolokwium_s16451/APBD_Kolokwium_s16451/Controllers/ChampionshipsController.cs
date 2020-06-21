using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APBD_Kolokwium_s16451.Models;

namespace APBD_Kolokwium_s16451.Controllers
{
    [Route("api/championships")]
    [ApiController]
    public class ChampionshipsController : ControllerBase
    {
        private readonly KolokwiumDbContext _context;

        public ChampionshipsController(KolokwiumDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}/teams")]
        public IActionResult GetTeams(int id)
        {
            var championship = _context.Championship.SingleOrDefault(c => c.IdChampionship == id);
            if(championship == null)
            {
                return NotFound();
            }

            var teams = _context.Team.Join(_context.Championship_Team, tm => tm.IdTeam, tmch => tmch.IdTeam, (tm, tmch) => new
            {
                tm,
                tmch
            })
            .Select(r => new
            {
                r.tm.IdTeam,
                r.tm.TeamName,
                r.tm.MaxAge,
                r.tmch.Score
            })
            .OrderBy(t => t.Score)
            .ToList();

            return Ok(teams);
        }
    }
}
