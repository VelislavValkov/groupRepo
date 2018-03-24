using System;

namespace Problem2.RectangleArea
{
    class Program
    {
        static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;           
            Console.WriteLine($"{area:F2}");
        }
    }
}
