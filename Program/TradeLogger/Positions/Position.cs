using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeLogger.Positions
{
    public class Position
    {
        public int PositionId { get; set; }
        Decimal PositionSize { get; set; }
        Decimal EntryPrice { get; set; }
        Decimal ?ExitPrice { get; set; }
        Decimal ?StopPrice { get; set; }
        DateTime EntryTime { get; set; }
        DateTime CreatedDate = new DateTime();
        DateTime UpdatedDate { get; set; }
        String TradeNotes { get; set; }
        Boolean Closed => ExitPrice != null;
    }
}
