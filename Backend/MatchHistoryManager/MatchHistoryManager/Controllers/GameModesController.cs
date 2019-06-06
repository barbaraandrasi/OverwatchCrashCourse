using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MatchHistoryManager.Models;

namespace MatchHistoryManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameModesController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public GameModesController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/GameModes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameMode>>> GetGameModes()
        {
            return await _context.GameModes.ToListAsync();
        }

        // GET: api/GameModes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameMode>> GetGameMode(string id)
        {
            var gameMode = await _context.GameModes.FindAsync(id);

            if (gameMode == null)
            {
                return NotFound();
            }

            return gameMode;
        }
    }
}
