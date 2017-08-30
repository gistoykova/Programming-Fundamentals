using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_A_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quatity = int.Parse(Console.ReadLine());

            double waterPrice = 0.7;;
            double coffeePrice = 1.00;
            double beerPrice = 1.7;
            double teaPrice = 1.2;

            if (profession == "Athlete")
            {
                Console.WriteLine("The Athlete has to pay {0:F2}.", (quatity * waterPrice));
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                if (profession == "Businessman")
                {
                    Console.WriteLine("The Businessman has to pay {0:F2}.", (quatity * coffeePrice));
                }
                else
                {
                    Console.WriteLine("The Businesswoman has to pay {0:F2}.", (quatity * coffeePrice));
                }              
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("The SoftUni Student has to pay {0:F2}.", (quatity * beerPrice));
            }
            else
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, (quatity * teaPrice));
            }
        }
    }
}
