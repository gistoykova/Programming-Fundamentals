using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studio = 0;
            double doubleRoom = 0;
            double apartment = 0;

            if(month == "May" || month == "October")
            {
                if (nightsCount >= 7 && month == "May")
                {
                    studio = 50 * 0.95;
                    doubleRoom = 65;
                    apartment = 75;

                    Console.WriteLine("Studio: {0:F2} lv.", studio * nightsCount);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoom * nightsCount);
                    Console.WriteLine("Suite: {0:F2} lv.", apartment * nightsCount);
                }
                else if (nightsCount >= 7 && month == "October")
                {
                    studio = 50 * 0.95;
                    doubleRoom = 65;
                    apartment = 75;

                    Console.WriteLine("Studio: {0:F2} lv.", studio * (nightsCount - 1));
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoom * nightsCount);
                    Console.WriteLine("Suite: {0:F2} lv.", apartment * nightsCount);
                }
                else
                {
                    studio = 50;
                    doubleRoom = 65;
                    apartment = 75;

                    Console.WriteLine("Studio: {0:F2} lv.", studio * nightsCount);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoom * nightsCount);
                    Console.WriteLine("Suite: {0:F2} lv.", apartment * nightsCount);
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nightsCount >= 7 && nightsCount < 14 && month == "September")
                {
                    studio = 60;
                    doubleRoom = 72;
                    apartment = 82;

                    Console.WriteLine("Studio: {0:F2} lv.", studio * (nightsCount - 1));
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoom * nightsCount);
                    Console.WriteLine("Suite: {0:F2} lv.", apartment * nightsCount);
                }
                else if(nightsCount >= 14 && month == "September")
                {
                    studio = 60;
                    doubleRoom = 72 * 0.9;
                    apartment = 82;

                    Console.WriteLine("Studio: {0:F2} lv.", studio * (nightsCount - 1));
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoom * nightsCount);
                    Console.WriteLine("Suite: {0:F2} lv.", apartment * nightsCount);
                }
                else
                {
                    studio = 60;
                    doubleRoom = 72;
                    apartment = 82;

                    Console.WriteLine("Studio: {0:F2} lv.", studio * nightsCount);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoom * nightsCount);
                    Console.WriteLine("Suite: {0:F2} lv.", apartment * nightsCount);
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                if (nightsCount >= 14)
                {
                    studio = 68;
                    doubleRoom = 77;
                    apartment = 89 * 0.85;

                    Console.WriteLine("Studio: {0:F2} lv.", studio * nightsCount);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoom * nightsCount);
                    Console.WriteLine("Suite: {0:F2} lv.", apartment * nightsCount);
                }
                else
                {
                    studio = 68;
                    doubleRoom = 77;
                    apartment = 89;

                    Console.WriteLine("Studio: {0:F2} lv.", studio * nightsCount);
                    Console.WriteLine("Double: {0:F2} lv.", doubleRoom * nightsCount);
                    Console.WriteLine("Suite: {0:F2} lv.", apartment * nightsCount);
                }
            }
        }
    }
}
