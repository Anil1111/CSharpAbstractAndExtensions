using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Trady.Core.Infrastructure;

namespace Trady.Core
{
    public abstract class IOhlcvBase: IOhlcv
    {
        public abstract decimal Open { get; }
        public abstract decimal High { get; }
        public abstract decimal Low { get; }
        public abstract decimal Close { get; }
        public abstract DateTimeOffset DateTime { get; }

        public decimal GetUpperShadow()
        {
            return Open < Close ? High - Close : High - Open;
            
        }
        //OR 
        //public decimal GetUpperShadow() => Open < Close ? High - Close : High - Open;
        

        public decimal GetLowerShadow()
        {
            return Open < Close ? Open - Low : Close - Low;
        }

        public decimal GetBody()
        {
            return Math.Abs(Open - Close);
        }

        public bool IsBull()
        {
            return Open - Close > 0;
        }

        public bool IsBear()
        {
            return Open - Close < 0;
        }

    }
}