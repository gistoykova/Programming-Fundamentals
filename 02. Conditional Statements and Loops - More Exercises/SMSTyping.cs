using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Typing
{
    class SMSTyping
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            for (int count = 0; count < inputCount; count++)
            {
                string currentInput = Console.ReadLine();
                int currentDigit = 0;

                if (currentInput.Length > 0)
                {
                    currentDigit = currentInput[0] - '0';
                }

                if (currentInput == "55")
                {
                    char characterToPoint = (char)(((currentDigit - 2) * 4) + (currentInput.Length - 1));
                    characterToPoint += 'a';
                    Console.Write(characterToPoint);
                }
                else if (currentInput == "57")
                {
                    char characterToPoint = (char)(((currentDigit - 2) * 4) + (currentInput.Length - 1));
                    characterToPoint += 'a';
                    Console.Write(characterToPoint);
                }
                else
                {
                    char characterToPoint = (char)(((currentDigit - 2) * 3) + (currentInput.Length - 1));
                    characterToPoint += 'a';
                    Console.Write(characterToPoint);
                }

                
            }
            Console.WriteLine();
        }
    }
}
