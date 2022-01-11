using System;
using System.Collections.Generic;
using System.Text;

namespace TestEcercise
{
    class DayTime
    {
        public TimeSpan Start { get; }
        public TimeSpan End { get; }

        public DayTime(string start, string end)
        {
            var startDate = DateTime.Parse(start);
            var endDate = DateTime.Parse(end);

            Start = new TimeSpan(startDate.Hour, 0, 0);
            End = new TimeSpan(endDate.Hour, 0, 0);
        }
    }
}
