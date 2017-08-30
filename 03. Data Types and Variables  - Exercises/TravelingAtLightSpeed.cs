using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main(string[] args)
        {
            decimal years = decimal.Parse(Console.ReadLine());
            decimal lightYear = years * 9450000000000m;
            double speedOfLight = 300000;

            double time = (double)lightYear / speedOfLight;
            var timeFromSeconds = TimeSpan.FromSeconds(time);

            int weeks = timeFromSeconds.Days / 7;
            int days = timeFromSeconds.Days % 7;
            int hours = timeFromSeconds.Hours;
            int minutes = timeFromSeconds.Minutes;
            int seconds = timeFromSeconds.Seconds;

            Console.WriteLine(weeks + " weeks");
            Console.WriteLine(days + " days");
            Console.WriteLine(hours + " hours");
            Console.WriteLine(minutes + " minutes");
            Console.WriteLine(seconds + " seconds");
        }
    }
}
