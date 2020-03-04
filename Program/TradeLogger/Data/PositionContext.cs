using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TradeLogger.Positions;

namespace TradeLogger.Data
{
    public class PositionContext : DbContext
    {
        public PositionContext (DbContextOptions<PositionContext> options)
            : base(options)
        {
        }

        public DbSet<TradeLogger.Positions.Position> Position { get; set; }
    }
}
