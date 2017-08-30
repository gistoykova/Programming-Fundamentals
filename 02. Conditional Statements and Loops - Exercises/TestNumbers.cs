using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());
            int countOfCombinations = 0;
            int sum = 0;
                    
            for (int i = numberN; i >= 1; i--)
            {
                for (int j = 1; j <= numberM; j++)
                {
                    sum = sum + (3 * (i * j));
                    countOfCombinations++;

                    if (sum >= maxSumBoundary)
                    {
                        Console.WriteLine(countOfCombinations + " combinations");
                        Console.WriteLine("Sum: {0} >= {1}", sum, maxSumBoundary);
                        break;
                    }
                }
                if (sum >= maxSumBoundary)
                {
                    break;
                }
            }
            if(sum < maxSumBoundary)
            {
                Console.WriteLine(countOfCombinations + " combinations");
                Console.WriteLine("Sum: " + sum);
            }
        }
    }
}
