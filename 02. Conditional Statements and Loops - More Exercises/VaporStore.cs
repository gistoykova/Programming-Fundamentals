using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vapor_Store
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            double outFall = 39.99;
            double cs = 15.99;
            double zplinterZell = 19.99;
            double honored2 = 59.99;
            double roverWatch = 29.99;
            double roverWatchOriginsEdition = 39.99;

            double currentBalance = double.Parse(Console.ReadLine());
            double startingPrice = currentBalance;
            string input = Console.ReadLine();

            while(input != "Game Time")
            {
                double price = 0;
                string currentGame = "";
                if(input == "OutFall 4")
                {
                    currentGame = "OutFall 4";
                    price = outFall;
                }
                else if (input == "CS: OG")
                {
                    currentGame = "CS: OG";
                    price = cs;
                }
                else if (input == "Zplinter Zell")
                {
                    currentGame = "Zplinter Zell";
                    price = zplinterZell;
                }
                else if (input == "Honored 2")
                {
                    currentGame = "Honored 2";
                    price = honored2;
                }
                else if (input == "RoverWatch")
                {
                    currentGame = "RoverWatch";
                    price = roverWatch;
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    currentGame = "RoverWatch Origins Edition";
                    price = roverWatchOriginsEdition;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                    continue;
                }

                if(price <= currentBalance)
                {
                    Console.WriteLine("Bought " + currentGame);
                    currentBalance -= price;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                if(currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", startingPrice - currentBalance, currentBalance);
        }
    }
}
