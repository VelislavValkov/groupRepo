using System;

namespace Problem4.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var wholeEnergyContent = (double )volume * energyContent / 100;
            var wholeSugarContent = (double) volume * sugarContent / 100;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{wholeEnergyContent}kcal, {wholeSugarContent}g sugars");
        }
    }
}
