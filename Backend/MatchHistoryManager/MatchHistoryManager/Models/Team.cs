using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchHistoryManager.Models
{
    public class Team
    {
        public int Id { get; set; }
        public List<Hero> Heroes { get; set; }
    }
}
