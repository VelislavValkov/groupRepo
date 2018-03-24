using System;

namespace Problem5.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            string isHealth = new string('|',currentHealth);
            string notHealth = new string('.', maxHealth-currentHealth);

            string isEnergy = new string('|', currentEnergy);
            string notEnergy = new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{isHealth}{notHealth}|");
            Console.WriteLine($"Energy: |{isEnergy}{notEnergy}|");

        }
    }
}
