using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_The_Integers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                int n = 0;
                try
                {
                    n = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
