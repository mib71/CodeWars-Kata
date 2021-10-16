using System;
using System.Collections.Generic;

namespace IsRoomReserved
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Interval> intervalList1 = new List<Interval>{
                new Interval
                {
                    StartDate = DateTime.Parse("3/2/2019 3:04:32 PM"),
                    EndDate = DateTime.Parse("3/5/2019 5:06:32 PM")
                },
                new Interval
                {
                    StartDate = DateTime.Parse("4/6/2019 1:04:32 PM"),
                    EndDate = DateTime.Parse("4/6/2019 1:06:32 PM")
                },
            };

            List<Interval> intervalList2 = new List<Interval>{
                new Interval
                {
                    StartDate = DateTime.Parse("4/6/2019 1:04:32 PM"),
                    EndDate = DateTime.Parse("4/6/2019 1:06:32 PM")
                },
                new Interval
                {
                    StartDate = DateTime.Parse("4/6/2019 1:04:32 PM"),
                    EndDate = DateTime.Parse("4/6/2019 1:06:32 PM")
                },
                new Interval
                {
                    StartDate = DateTime.Parse("4/6/2019 1:00:32 PM"),
                    EndDate = DateTime.Parse("4/6/2019 1:05:31 PM")
                },
                new Interval
                {
                    StartDate = DateTime.Parse("4/6/2019 1:02:33 PM"),
                    EndDate = DateTime.Parse("4/6/2019 1:03:30 PM")
                }
            };

            Interval testBasic = new Interval
            {
                StartDate = DateTime.Parse("4/6/2019 1:02:32 PM"),
                EndDate = DateTime.Parse("4/6/2019 1:03:32 PM")
            };

            Console.WriteLine(IsRoomReserved(intervalList2, testBasic));
        }

        private static bool IsRoomReserved(List<Interval> intervals, Interval checkInterval)
        {
            foreach (var interval in intervals)
            {                
                if (((checkInterval.StartDate >= interval.StartDate && checkInterval.StartDate <= interval.EndDate)
                    || (checkInterval.EndDate >= interval.StartDate && checkInterval.StartDate <= interval.EndDate)))
                {
                    return true;
                }                
            }

            return false;
        }

        public class Interval
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }        
    }
}
