using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int countOfIngredients = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 0; i < countOfIngredients; i++)
            {
                string Ingredients = Console.ReadLine().ToLower();
                
                if(Ingredients == "cheese")
                {
                    totalCalories += 500;
                }
                else if(Ingredients == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if(Ingredients == "salami")
                {
                    totalCalories += 600;
                }
                else if(Ingredients == "pepper")
                {
                    totalCalories += 50;
                }
            }
            Console.WriteLine("Total calories: " + totalCalories);
        }
    }
}
