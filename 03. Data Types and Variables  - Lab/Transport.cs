using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double capacity = 24.0;

            if (numberOfPeople <= capacity)
            {
                Console.WriteLine("1");
            }
            else
            {
                double numberOfCourse = numberOfPeople / capacity;
                Console.WriteLine(Math.Ceiling(numberOfCourse));
            }

        }
    }
}
