using System;

namespace RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Numbers from 0 to 10");
            int start = 0;
            printNumber(start);
            Console.WriteLine("Finished Print number, hit any key");
            Console.ReadKey();

            Console.WriteLine("Add Numbers from 0 to 10");
            int i = 0;
            int sum = 0;
            sum = addNumber(sum, i);
            Console.WriteLine($"sum is {sum}, hit any key");
            Console.ReadKey();

            Console.WriteLine("Add Numbers from 0 to 10");
            int f = 1;
            int product = 1;
            product = MultiplyNumbers(product, f);
            Console.WriteLine($"sum is {product}, hit any key");
            Console.ReadKey();

            Console.WriteLine("Add Numbers from 0 to 10");
            int k = 1;
            int sumSquares = 1;
            product = MultiplySquares(sumSquares, k);
            Console.WriteLine($"sum is {sumSquares}, hit any key");
            Console.ReadKey();



        }

        private static int MultiplySquares(int sumSquares, int k)
        {
            
            if (k > 10)
                return sumSquares;
            else
                return MultiplySquares(sumSquares + (k * k), k +1);
        }

        private static int MultiplyNumbers(int product, int f)
        {
            if (f > 6)
                return product;
            else
                return MultiplyNumbers(product * f, f + 1);
        }

        private static int addNumber(int sum, int i)
        {
            if (i > 10)
                return sum;
            else
                return addNumber(sum + 1, i + 1);
        }

        private static void printNumber(int start)
        {
            Console.WriteLine(start);
            if (start > 10)
                return;
            else
                printNumber(start + 1);
        }
    }
}
