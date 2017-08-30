using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Variable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double overflowed = num / 256;
            if(num >= 256)
            {
                Console.WriteLine(num - (Math.Floor(overflowed) * 256));
                Console.WriteLine("Overflowed {0} times", Math.Floor(overflowed));
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
