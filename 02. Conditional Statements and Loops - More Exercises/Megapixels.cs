using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            double widthOfTheImage = double.Parse(Console.ReadLine());
            double heightOfTheImage = double.Parse(Console.ReadLine());

            double megapixels = (widthOfTheImage * heightOfTheImage) / 1000000;

            Console.WriteLine("{0}x{1} => {2}MP", widthOfTheImage, heightOfTheImage, Math.Round(megapixels, 1));

        }
    }
}
