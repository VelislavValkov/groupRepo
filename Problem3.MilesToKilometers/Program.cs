﻿using System;

namespace Problem3.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles =double.Parse (Console.ReadLine());
            var kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
