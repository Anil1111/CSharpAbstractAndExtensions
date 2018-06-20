using System;

namespace Trady.Core.Infrastructure
{
    public interface IOhlcv
    {
        DateTimeOffset DateTime { get; }
        decimal Open { get; }

        decimal High { get; }

        decimal Low { get; }

        decimal Close { get; }

    }
}
