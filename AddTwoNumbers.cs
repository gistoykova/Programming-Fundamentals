using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Numbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int sumOfNumbers = firstNum + secondNum;
            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, sumOfNumbers);
        }
    }
}
