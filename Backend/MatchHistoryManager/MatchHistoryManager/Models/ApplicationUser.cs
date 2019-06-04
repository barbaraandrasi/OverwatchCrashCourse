﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchHistoryManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Match> MatchHistory { get; set; }
    }
}
