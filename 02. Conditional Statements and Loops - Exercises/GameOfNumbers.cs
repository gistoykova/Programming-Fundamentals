using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Numbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
           /* int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int countOfCombinations = 0;
            int sum = 0;
            

            for (int i = numberN; i <= numberM; i++)
            {
                for (int j = numberN; j <= numberM; j++)
                {
                    sum = i + j;
                    countOfCombinations++;
                    if (sum == magicalNumber)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}", i, j, sum);
                    }
                }
            }
            if(sum != magicalNumber)
            {
                Console.WriteLine(countOfCombinations + " combinations - ");
                Console.WriteLine("neither equals " + magicalNumber);
            }*/

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool itsAKindOfMagic = false;
            string lastMagic = "";
            int combinationsCount = 0;
            for (int i = number1; i <= number2; i++)
            {
                for (int j = number1; j <= number2; j++)
                {
                    combinationsCount++;
                    if (i + j == magicNumber)
                    {
                        lastMagic = $"Number found! {i} + {j} = {magicNumber}";
                        itsAKindOfMagic = true;
                    }
                }
            }

            if (itsAKindOfMagic)
            {
                Console.WriteLine(lastMagic);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinationsCount, magicNumber); 
            }
        }
    }
}