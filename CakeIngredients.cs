using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string ingredient = "";
            int count = 0;
            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                count++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", count);


        }
    }
}
