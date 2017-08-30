using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            string curHealth = new string('|', currentHealth);
            string maxHealth = new string('.', maximumHealth - currentHealth);
            string curEnergy = new string('|', currentEnergy);
            string maxEnergy = new string('.', maximumEnergy - currentEnergy);


            if(currentHealth <= maximumHealth && currentEnergy <= maximumEnergy)
            {
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Health: |{0}{1}|", curHealth, maxHealth);
                Console.WriteLine("Energy: |{0}{1}|", curEnergy, maxEnergy);
            }

        }
    }
}
