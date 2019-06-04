using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchHistoryManager.Models
{
    public class Reward
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public Medal Medal { get; set; }
    }
}
