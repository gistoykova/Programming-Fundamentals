using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_A_Drink
{
    class ChooseADrink
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string water = "Water";
            string coffee = "Coffee";
            string beer = "Beer";
            string tea = "Tea";

            if (profession == "athlete")
            {
                Console.WriteLine(water);
            }else if(profession == "Businessman" || profession  == "Businesswoman")
            {
                Console.WriteLine(coffee);
            }else if(profession == "SoftUni Student")
            {
                Console.WriteLine(beer);
            }
            else
            {
                Console.WriteLine(tea);
            }

        }
    }
}
