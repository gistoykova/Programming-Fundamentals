using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (true)
            {
                n = Math.Abs(int.Parse(Console.ReadLine()));
                if(n % 2 == 1)
                {
                    break;
                }
                Console.WriteLine("Please write an odd number.");
            }
            Console.WriteLine("The number is: " + n);
        }
    }
}
