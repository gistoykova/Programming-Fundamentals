using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_In_30_Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int min = minutes + 30;

            if(hours >= 23)
            {
                if(min > 59)
                {
                    hours = 0;
                    min -= 60;
                    if (min < 10)
                    {
                        Console.WriteLine("{0}:0{1}", hours, min);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", hours, min);
                    }
                }
                else
                {
                    Console.WriteLine("{0}:{1}", hours, min);
                }
            }
            else if (min > 59)
            {
                hours += 1;
                min -= 60;
                if (min < 10)
                {
                    Console.WriteLine("{0}:0{1}", hours, min);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", hours, min);
                }
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, min);
            }
        }
    }
}
