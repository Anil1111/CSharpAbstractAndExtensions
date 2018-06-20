using System;
using Trady.Core.Infrastructure;

namespace Trady.Core
{
    public class Candle: IOhlcvBase
    {
        public decimal Volume { get; set; }

        public Candle(DateTimeOffset dateTime, decimal open, decimal high, decimal low, decimal close, decimal volume)
        {
            DateTime = dateTime;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
        }

        public override DateTimeOffset DateTime { get; }

        public override decimal Open { get; }

        public override decimal High { get; }
               
        public override decimal Low { get; }
               
        public override decimal Close { get; }
        
    }
}