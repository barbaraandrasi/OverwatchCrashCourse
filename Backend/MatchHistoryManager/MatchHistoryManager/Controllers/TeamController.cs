/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MatchHistoryManager.Models;
using System.Security.Principal;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Web;

namespace MatchHistoryManager.Controllers
{
   // [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public TeamController(AuthenticationContext context)
        {
            _context = context;
            //User = System.Web.HttpContext.Current.User;
            //var a = User;
            //var currentUser = User.Identity.Name;

           
            //var a = _context.ApplicationUsers.Find.
            //("a6407d6d-dbe1-4a6e-beb9-64bacc8bf6e2");

            //(a as ApplicationUser).MatchHistory = new List<Match>()
            //    {
            //        new Match()
            //        {
            //            MyTeam = new Team()
            //            {
            //                Heroes = new List<Hero>()
            //                {
            //                    new Hero()
            //                    {
            //                        Name = "ANYÁD"

            //                    }
            //                }
            //            }
            //        }
            //    };

            //_context.SaveChanges();
            //Team team1 = new Team()
            //{
            //    Heroes = new List<Hero>(6)
            //    {
            //        new Hero()
            //        {
            //             Name = "Aaa1",
            //             Role = Role.Damage,
            //             Difficulty = 3,
            //             Me = true
            //        },
            //         new Hero()
            //        {
            //             Name = "Aaa2",
            //             Role = Role.Damage,
            //             Difficulty = 3,
            //             Me = true
            //        },
            //          new Hero()
            //        {
            //             Name = "Aaa3",
            //             Role = Role.Damage,
            //             Difficulty = 3,
            //             Me = true
            //        },
            //           new Hero()
            //        {
            //             Name = "Aaa4",
            //             Role = Role.Damage,
            //             Difficulty = 3,
            //             Me = true
            //        },
            //        new Hero()
            //        {
            //             Name = "Aaa5",
            //             Role = Role.Damage,
            //             Difficulty = 3,
            //             Me = true
            //        },
            //         new Hero()
            //        {
            //             Name = "Aaa6",
            //             Role = Role.Damage,
            //             Difficulty = 3,
            //             Me = true
            //        }
            //    }
            //};

            //_context.Teams.Add(team1);
            //_context.SaveChanges();
        }

        // GET: api/Team
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
        {
            return await _context.Teams.ToListAsync();
        }

        // GET: api/Team/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);

            if (team == null)
            {
                return NotFound();
            }

            return team;
        }

        // PUT: api/Team/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeam(int id, Team team)
        {
            if (id != team.Id)
            {
                return BadRequest();
            }

            _context.Entry(team).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Team
        [HttpPost]
        public async Task<ActionResult<Team>> PostTeam(Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeam", new { id = team.Id }, team);
        }

        // DELETE: api/Team/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Team>> DeleteTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();

            return team;
        }

        private bool TeamExists(int id)
        {
            return _context.Teams.Any(e => e.Id == id);
        }
    }
}*/
