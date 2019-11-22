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
        }

        }
    }
    

