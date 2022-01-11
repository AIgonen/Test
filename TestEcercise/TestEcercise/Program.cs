using System;

namespace TestEcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage kellaajad formaadis \"HH:mm\"");
            Console.WriteLine("Sisestage alguskellaaeg");
            var p1 = Console.ReadLine();
            Console.WriteLine("Sisestage lõppkellaaeg");
            var p2 = Console.ReadLine();

            var startTime = DateTime.Parse(p1);
            var endTime = DateTime.Parse(p2);

            if (endTime < startTime)
                endTime = endTime.AddDays(1);

            var total = CalculatePeriods(startTime, endTime);

            PrintResult(total, startTime, endTime);
        }

        private static Result CalculatePeriods(DateTime start, DateTime end)
        {
            DayTime dayTime = new DayTime("06:00", "21:59");
            int step = 15;

            var dT = new TimeSpan();
            var nT = new TimeSpan();

            while (start < end)
            {
                if (start.Hour >= dayTime.Start.Hours && start.Hour <= dayTime.End.Hours)
                    dT = dT.Add(new TimeSpan(0, step, 0));
                else
                    nT = nT.Add(new TimeSpan(0, step, 0));

                start = start.AddMinutes(step);
            }

            return new Result(dT.TotalHours, nT.TotalHours);
        }

        private static void PrintResult(Result total, DateTime start, DateTime end)
        {
            Console.WriteLine("\nSisend:");
            Console.WriteLine($"Algus: { start.ToString("HH:mm")}, lõpp: { end.ToString("HH:mm")}");
            Console.WriteLine("\nVäljund:");
            Console.WriteLine($"öö: \t {total.NightTimeTotal} \npäev:\t {total.DayTimeTotal}");
        }
    }
}
