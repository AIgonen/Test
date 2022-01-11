using System;
using System.Collections.Generic;
using System.Text;

namespace TestEcercise
{
    class Result
    {
        public double DayTimeTotal { get; }
        public double NightTimeTotal { get; }

        public Result(double dayTimeTotal, double nightTimeTotal)
        {
            DayTimeTotal = dayTimeTotal;
            NightTimeTotal = nightTimeTotal;
        }
    }
}
