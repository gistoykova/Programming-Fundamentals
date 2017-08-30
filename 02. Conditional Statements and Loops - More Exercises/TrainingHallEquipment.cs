using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());

            var subTotalSum = 0d;

            for (int i = 0; i < numberOfItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPricer = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                subTotalSum += (itemPricer * itemCount);
                if (itemCount == 1)
                {
                    Console.WriteLine("Adding {0} {1} to cart.", itemCount, itemName);
                }
                else
                {
                    Console.WriteLine("Adding {0} {1}s to cart.", itemCount, itemName);
                }

            }
            var moneyLeft = budget - subTotalSum;

            Console.WriteLine("Subtotal: ${0:F2}", subTotalSum);
            if (moneyLeft >= 0)
            {
                Console.WriteLine("Money left: ${0:F2}", moneyLeft);
            }
            else
            {
                Console.WriteLine("Not enough. We need ${0:F2} more.", Math.Abs(moneyLeft));
            }
        }
    }
}
