﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    public interface IBowlersRepository
    {
        IQueryable<Bowler> Bowlers { get; }

        public void AddBowler(Bowler b);
        public void SaveBowler(Bowler b);
        public void DeleteBowler(Bowler b);
    }
}
