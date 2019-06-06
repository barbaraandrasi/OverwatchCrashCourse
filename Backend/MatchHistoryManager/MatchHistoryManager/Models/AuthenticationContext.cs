using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchHistoryManager.Models
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options) : base(options)
        {
            #region adatok beszúrása
            //GameMode gameMode1 = new GameMode()
            //{
            //    Name = "PRACTICE RANGE",
            //    Description = "Visit a training area and experiment with your abilities against practice bots. Use this mode to hone your skills or learn a new hero.",
            //    Image = "practice.png"
            //};

            //GameMode gameMode2 = new GameMode()
            //{
            //    Name = "PRACTICE VS A.I.",
            //    Description = "Play against AI-controlled opponents on any map you choose. Use these modes to try out different maps and learn how multiple heroes work.",
            //    Image = "practiceai.png"
            //};

            //GameMode gameMode3 = new GameMode()
            //{
            //    Name = "QUICK PLAY",
            //    Description = "Square off against other players at your skill level.",
            //    Image = "quick.png"
            //};

            //GameMode gameMode4 = new GameMode()
            //{
            //    Name = "ARCADE",
            //    Description = "Experimental matches with unique and seasonal rules, plus weekly rewards!",
            //    Image = "arcade.png"
            //};

            //GameMode gameMode5 = new GameMode()
            //{
            //    Name = "COMPETITIVE PLAY",
            //    Description = "Compete against other players and work your way up the ranks.",
            //    Image = "competitive.png"
            //};

            //GameMode gameMode6 = new GameMode()
            //{
            //    Name = "CUSTOM GAME",
            //    Description = "Change the rules of the game with custom modifiers (like disallowing heroes, increasing Ultimate ability charge rate, etc.).",
            //    Image = "custom.png"
            //};
            //Game game = new Game()
            //{
            //    Name = "Overwatch",
            //    Description = "Overwatch is a colorful team-based shooter game starring a diverse cast of powerful heroes. Travel the world, build a team, and contest objectives in exhilarating 6v6 combat.",
            //    Image = "owgroup.jpg",
            //    GameModes = new List<GameMode>(new GameMode[] { gameMode1, gameMode2, gameMode3, gameMode4, gameMode5, gameMode6 })
            //};
            //this.GameModes.Add(gameMode1);
            //this.GameModes.Add(gameMode2);
            //this.GameModes.Add(gameMode3);
            //this.GameModes.Add(gameMode4);
            //this.GameModes.Add(gameMode5);
            //this.GameModes.Add(gameMode6);

            //this.Games.Add(game);
            //this.SaveChanges();
            #endregion
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }    
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameMode> GameModes { get; set; }
        public DbSet<Role> Rolez { get; set; }
    }
}
