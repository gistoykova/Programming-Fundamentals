using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string typeOfPackage = Console.ReadLine();

            int smallHall = 2500;
            int terrace = 5000;
            int greatHall = 7500;

            int normalPackage = 500;
            int goldPackage = 750;
            int platinumPackage = 1000;

            double totalPrice = 0;
            double pricePerPerson = 0;

            if (typeOfPackage == "Normal")
            {
                if (groupSize <= 50)
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    totalPrice = smallHall + normalPackage;
                    totalPrice = totalPrice - ((totalPrice / 10) / 2);
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (groupSize > 50 && groupSize <= 100)
                {
                    Console.WriteLine("We can offer you the Terrace");
                    totalPrice = terrace + normalPackage;
                    totalPrice = totalPrice - ((totalPrice / 10) / 2);
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (groupSize > 100 && groupSize <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    totalPrice = greatHall + normalPackage;
                    totalPrice = totalPrice - ((totalPrice / 10) / 2);
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
            }
            else if(typeOfPackage == "Gold")
            {
                if (groupSize <= 50)
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    totalPrice = smallHall + goldPackage;
                    totalPrice = totalPrice - (totalPrice / 10);
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (groupSize > 50 && groupSize <= 100)
                {
                    Console.WriteLine("We can offer you the Terrace");
                    totalPrice = terrace + goldPackage;
                    totalPrice = totalPrice - (totalPrice / 10);
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (groupSize > 100 && groupSize <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    totalPrice = greatHall + goldPackage;
                    totalPrice = totalPrice - (totalPrice / 10);
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
            }
            else if (typeOfPackage == "Platinum")
            {
                if (groupSize <= 50)
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    totalPrice = smallHall + platinumPackage;
                    totalPrice = totalPrice - ((totalPrice / 100) * 15);
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (groupSize > 50 && groupSize <= 100)
                {
                    Console.WriteLine("We can offer you the Terrace");
                    totalPrice = terrace + platinumPackage;
                    totalPrice = totalPrice - ((totalPrice / 100) * 15);
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (groupSize > 100 && groupSize <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    totalPrice = greatHall + platinumPackage;
                    totalPrice = totalPrice - ((totalPrice / 100) * 15);
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
            }
        }
    }
}
