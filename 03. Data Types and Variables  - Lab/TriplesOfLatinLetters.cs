using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_Of_Latin_Letters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < n + 'a'; i++)
            {
                for (char j = 'a'; j < n + 'a'; j++)
                {
                    for (char k = 'a'; k < n + 'a'; k++)
                    {
                        Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
        }
    }
}
