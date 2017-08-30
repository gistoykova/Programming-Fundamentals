using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double sizeOfPhoto = double.Parse(Console.ReadLine());
            int widthOfPhoto = int.Parse(Console.ReadLine());
            int heightOfPhoto = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:D4}.jpg", photoNumber);
            Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2:D4} {3:D2}:{4:D2}", 
                day, month, year, hours, minutes);

            if(sizeOfPhoto < 1000)
            {
                Console.WriteLine("Size: {0}B", sizeOfPhoto);
            }
            else if(sizeOfPhoto < 1000000)
            {
                sizeOfPhoto = sizeOfPhoto / 1000;
                Console.WriteLine("Size: {0}KB", sizeOfPhoto);
            }
            else
	        {
                sizeOfPhoto = sizeOfPhoto / 1000000.0;
                Console.WriteLine("Size: {0}MB", sizeOfPhoto);
	        }

            if(widthOfPhoto > heightOfPhoto)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)",
                    widthOfPhoto, heightOfPhoto);
            }
            else if (widthOfPhoto < heightOfPhoto)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)",
                    widthOfPhoto, heightOfPhoto);
            }
            else
            {
                Console.WriteLine("Resolution: {0}x{1} (square)",
                    widthOfPhoto, heightOfPhoto);
            }
        }
    }
}
