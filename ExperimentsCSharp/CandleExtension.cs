using System;
using System.Collections.Generic;
using System.Linq;
using Trady.Core.Infrastructure;

namespace Trady.Core
{
    public static class CandleExtension
    {
        public static decimal GetUpperShadow(this IOhlcv candle) => candle.Open < candle.Close ? candle.High - candle.Close : candle.High - candle.Open;

        public static decimal GetLowerShadow(this IOhlcv candle) => candle.Open < candle.Close ? candle.Open - candle.Low : candle.Close - candle.Low;

        public static decimal GetBody(this IOhlcv candle) => Math.Abs(candle.Open - candle.Close);

        public static bool IsBull(this IOhlcv candle) => candle.Open - candle.Close > 0;

        public static bool IsBear(this IOhlcv candle) => candle.Open - candle.Close < 0;
        
    }
}