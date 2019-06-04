using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchHistoryManager.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public int Difficulty { get; set; }
        public bool Me { get; set; }
    }
}
