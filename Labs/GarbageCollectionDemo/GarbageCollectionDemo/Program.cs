﻿using System;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            Console.WriteLine("Program finishing");

            using (Calculator calculator1 = new Calculator())
            {
                int dividend = calculator.Divide(120, 0);
                Console.WriteLine($"120/15 = {calculator1.Divide(120, 15)}");
            }

            Console.WriteLine("Program finishing");
        }
    }
}
