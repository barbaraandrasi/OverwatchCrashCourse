using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchHistoryManager.Models
{
    public class Match
    {
        public int Id { get; set; }
        public Result Result { get; set; }
        public List<Reward> Rewards { get; set; }
        public Team MyTeam { get; set; }
        public Team EnemyTeam { get; set; }
        public DateTime MatchDateTime { get; set; }
    }
}
