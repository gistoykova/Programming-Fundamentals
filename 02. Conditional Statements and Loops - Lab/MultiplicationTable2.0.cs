using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int result;

            if (m > 10)
            {
                result = n * m;
                Console.WriteLine("{0} X {1} = {2}", n, m, result);
            }
            else
            {
                for (int i = m; i <= 10; i++)
                {
                    result = n * i;
                    Console.WriteLine("{0} X {1} = {2}", n, i, result);
                }
            }
        }
    }
}
