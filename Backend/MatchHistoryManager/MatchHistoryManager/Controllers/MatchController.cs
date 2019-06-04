/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MatchHistoryManager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace MatchHistoryManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly AuthenticationContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public MatchController(AuthenticationContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            //init();
               
        }

        //private void init()
        //{
        //    string userId = "487a4426-2035-4ba8-957c-83e21cfcaf68";
        //    var user = _userManager.FindByIdAsync(userId).Result;
        //    user.MatchHistory = new List<Match>() {
        //        new Match()
        //    {
        //        MyTeam = new Team()
        //        {
        //            Heroes = new List<Hero>(6)
        //                 {
        //                     new Hero()
        //                     {
        //                          Name = "Aaa1",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = true
        //                     },
        //                      new Hero()
        //                     {
        //                          Name = "Aaa2",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = true
        //                     },
        //                       new Hero()
        //                     {
        //                          Name = "Aaa3",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = true
        //                     },
        //                        new Hero()
        //                     {
        //                          Name = "Aaa4",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = true
        //                     },
        //                     new Hero()
        //                     {
        //                          Name = "Aaa5",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = true
        //                     },
        //                      new Hero()
        //                     {
        //                          Name = "Aaa6",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = true
        //                     }
        //                 }
        //        },
        //        EnemyTeam = new Team()
        //        {
        //            Heroes = new List<Hero>(6)
        //                 {
        //                     new Hero()
        //                     {
        //                          Name = "Aaa1",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = false
        //                     },
        //                      new Hero()
        //                     {
        //                          Name = "Aaa2",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = false
        //                     },
        //                       new Hero()
        //                     {
        //                          Name = "Aaa3",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = false
        //                     },
        //                        new Hero()
        //                     {
        //                          Name = "Aaa4",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = false
        //                     },
        //                     new Hero()
        //                     {
        //                          Name = "Aaa5",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = false
        //                     },
        //                      new Hero()
        //                     {
        //                          Name = "Aaa6",
        //                          Role = Role.Damage,
        //                          Difficulty = 3,
        //                          Me = false
        //                     }
        //                 }
        //        },
        //        Rewards = new List<Reward>()
        //         {
        //            new Reward()
        //            {
        //                Category = Category.Eliminations,
        //                Medal = Medal.Gold
        //            }
        //         },
        //        Result = Result.Win,
        //        MatchDateTime = new DateTime(2019, 01, 11),
        //    }};
        //    _context.SaveChanges();
        //}

        // GET: api/Match
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Match>>> GetMatches()
        {
            return await _context.Matches.ToListAsync();
        }

        // GET: api/Match/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Match>> GetMatch(int id)
        {
            var match = await _context.Matches.FindAsync(id);

            if (match == null)
            {
                return NotFound();
            }

            return match;
        }

        [HttpGet("userMatches/{userid}")]
        public async Task<ActionResult<IEnumerable<Match>>> GetUserMatches(string userid)
        {
            var user = await _userManager.FindByIdAsync(userid);
            List<Match> matches = user.MatchHistory;

            if (matches == null || matches.Count == 0)
            {
                return NotFound();
            }

            return matches;
        }

        // PUT: api/Match/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatch(int id, Match match)
        {
            if (id != match.Id)
            {
                return BadRequest();
            }

            _context.Entry(match).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatchExists(id))
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

        // POST: api/Match
        [HttpPost]
        [Route("Match")]
        public async Task<ActionResult<Match>> PostMatch(Match match)
        {
            _context.Matches.Add(match);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMatch", new { id = match.Id }, match);
        }

        // DELETE: api/Match/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Match>> DeleteMatch(int id)
        {
            var match = await _context.Matches.FindAsync(id);
            if (match == null)
            {
                return NotFound();
            }

            _context.Matches.Remove(match);
            await _context.SaveChangesAsync();

            return match;
        }

        private bool MatchExists(int id)
        {
            return _context.Matches.Any(e => e.Id == id);
        }
    }
}
*/
