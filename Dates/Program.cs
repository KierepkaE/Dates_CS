using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan2 = TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(4);
            var duration = end - start;
            Console.WriteLine("Duration" + duration);

        }

        }
    }
    

