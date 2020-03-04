using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeLogger
{
    public class Trade
    {
        public DateTime TradeDateTime { get; set; }
        public DateTime TradeEntryDateTime { get; set; }
        public DateTime TradeUpdatedDateTime { get; set; }
        public Decimal ToCurrencyPrice { get; set; } // amount for 1 of from currency
        public Decimal ToCurrencyAmount { get; set; }
        public Decimal FromCurrencyPrice { get; set; } // amount for 1 of to currency
        public Decimal FromCurrencyAmount { get; set; }
        public Currency ToCurrency { get; set; }
        public Currency FromCurrency { get; set; }
    }
}
