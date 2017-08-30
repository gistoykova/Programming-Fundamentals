using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int temp = 0;

            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
        }
    }
}
