using System;
using Trady.Core;

namespace ExperimentsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Candle c = new Candle(new DateTimeOffset(DateTime.Now), 10, 12, 9, 11, 1000);
            Console.WriteLine( c.GetBody());
            Console.WriteLine(c.GetLowerShadow());
            
        }
    }
}
