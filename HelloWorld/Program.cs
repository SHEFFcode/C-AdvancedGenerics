using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime object are immutable
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //but you can modify them by adding days / minnutes /etc
            var tomorrow = now.AddDays(3);
            var yesterday = now.AddDays(-3);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            //both date and time
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));


            /*==================== Time Span ===========================*/
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0 , 0);

            var clearTimeSpan = TimeSpan.FromHours(1);


            var start = DateTime.Now;
            var end = start.AddMinutes(5);
            var duration = end - start;

            Console.WriteLine(duration);

            //Properties of a timespan
            Console.WriteLine($"Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}");

            //Add / Subtract timespans, returns a new timespan, since the original is immutable.
            Console.WriteLine($"Add example: {timeSpan.Add(TimeSpan.FromMinutes(5))}");
            Console.WriteLine($"Subtract example: {timeSpan.Subtract(TimeSpan.FromMinutes(1))}");

            //Converstion to and from strings
            Console.WriteLine($"Timespan string values is: {timeSpan.ToString()}");
            Console.WriteLine($"String value to a timespan: {TimeSpan.Parse("01:02:03")}");
        }
    }
}