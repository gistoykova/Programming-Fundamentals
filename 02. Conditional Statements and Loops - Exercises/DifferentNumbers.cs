using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Numbers
{
    class DifferentNumbers
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            if (max - min >= 4)
            {
                for (int firstDigit = min; firstDigit <= max; firstDigit++)
                {
                    for (int secondDigit = firstDigit + 1; secondDigit <= max - 3; secondDigit++)
                    {
                        for (int thirdDigit = secondDigit + 1; thirdDigit <= max - 2; thirdDigit++)
                        {
                            for (int fourthdigit = thirdDigit + 1; fourthdigit <= max - 1; fourthdigit++)
                            {
                                for (int fifthDigit = fourthdigit + 1; fifthDigit <= max; fifthDigit++)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", firstDigit, secondDigit, thirdDigit, fourthdigit, fifthDigit);
                                }
                            }
                        }
                    }
                }
                
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
