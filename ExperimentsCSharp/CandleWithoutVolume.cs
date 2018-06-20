using System;
using Trady.Core.Infrastructure;

namespace Trady.Core
{
    public class CandleWithoutVolume : IOhlcv
    {
        public CandleWithoutVolume(DateTimeOffset dateTime, decimal open, decimal high, decimal low, decimal close, decimal volume)
        {
            DateTime = dateTime;
            Open = open;
            High = high;
            Low = low;
            Close = close;
        }

        public DateTimeOffset DateTime { get; }

        public decimal Open { get; }

        public decimal High { get; }
              
        public decimal Low { get; }
              
        public decimal Close { get; }
        
    }
}