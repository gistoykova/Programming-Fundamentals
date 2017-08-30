using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            int BPM = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4.0;
            double seconds = ((numberOfBeats * 60) / BPM);

            var time = TimeSpan.FromSeconds(seconds);

            Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars, 1),
            time.Minutes, time.Seconds);


            /*double beatsPerSecond = BPM / 60.0;

            double lengthInSecond = numberOfBeats / beatsPerSecond;
            int minutes = 0;
             
            if(lengthInSecond >= 60 && lengthInSecond < 120)
            {
                minutes++;
                lengthInSecond -= 60;
                Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars, 1), minutes, Math.Floor(lengthInSecond));
            }
            else if(lengthInSecond >= 120 && lengthInSecond < 180)
            {
                minutes += 2;
                lengthInSecond -= 120;
                Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars, 1), minutes, Math.Floor(lengthInSecond));
            }
            else if(lengthInSecond < 60)
            {
                Console.WriteLine("{0} bars - {1}m {2}s", Math.Round(bars, 1), minutes, Math.Floor(lengthInSecond));
            }
            */
        }
    }
}
