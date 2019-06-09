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

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }    
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameMode> GameModes { get; set; }
        public DbSet<Role> Rolez { get; set; }
    }
}
