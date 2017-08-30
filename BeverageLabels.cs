using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100 = int.Parse(Console.ReadLine());
            int sugarContentPer100 = int.Parse(Console.ReadLine());

            double energyContent = volume * energyContentPer100 / 100.0;
            double sugarContent = volume * sugarContentPer100 / 100.0;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energyContent, sugarContent);

        }
    }
}
