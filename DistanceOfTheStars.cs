using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Of_The_Stars
{
    class DistanceOfTheStars
    {
        static void Main(string[] args)
        {
            decimal lightYearToKilometers= 9450000000000m;
            decimal proximaCentauri = 4.22m * lightYearToKilometers;
            decimal milkyWay = 26000m * lightYearToKilometers;
            decimal milkyWayDiameter = 100000 * lightYearToKilometers;
            decimal edgeOfTheUniverse = 46500000000 * lightYearToKilometers;

            Console.WriteLine("{0:e2}", proximaCentauri);
            Console.WriteLine("{0:e2}",milkyWay);
            Console.WriteLine("{0:e2}",milkyWayDiameter);
            Console.WriteLine("{0:e2}",edgeOfTheUniverse);
        }
    }
}
