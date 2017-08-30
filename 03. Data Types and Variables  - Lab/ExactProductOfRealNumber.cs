using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactProductOfRealNumber
{
    class ExactProductOfRealNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal number = 0.000000000000000000m;
            decimal sum = 1m;

            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum *= number;
            }
            Console.WriteLine(sum);
        }
    }
}
