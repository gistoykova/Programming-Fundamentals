using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Of_Numbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleSize; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
