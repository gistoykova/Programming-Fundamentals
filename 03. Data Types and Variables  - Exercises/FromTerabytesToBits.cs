using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        {
            double terabytes = double.Parse(Console.ReadLine());
            decimal fromTerabytesToBits = (decimal)1024 * 1024 * 1024 * 1024 * 8;
            decimal bits = fromTerabytesToBits * (decimal)terabytes;

            Console.WriteLine("{0:F0}", bits);
        }
    }
}
