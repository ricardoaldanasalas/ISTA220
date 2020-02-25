using System;
using System.Linq;

namespace ManipulatingArrays
{

    class Program
    {



        public static void Part1(int[] A, char Array)
        {
            int Adding = A.Sum();
            int result = A.GetLength(0);
            double average = Adding / result;
            Console.WriteLine("Part 1, Count, Sum, and Average arrays");
            Console.WriteLine($"Array Count = {result}, sum = {Adding}, Array {Array} Average = {average}");

        }
        public static void Reversing(int[] A, char ArrayName)
        {
            Console.WriteLine($"Reverse Array {ArrayName}.");
            Console.Write("Reverse array is ");
            Array.Reverse(A);
            foreach (int value in A)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        public static void Sorting(int[] A, char ArrayName)
        {
            Console.WriteLine($"Sorting of the Array {ArrayName} is");
            Array.Sort(A);
            foreach (int value in A)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        public static void Rotating(int[]A, int n)
        {
           
            for (int i =(n-2); i< A.Length - 1; i++)
            {              
                A[i] = A[i + 1];
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10};
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            char Array1='A', Array2='B', Array3='C';

            Part1(A,Array1);
            Part1(B, Array2);
            Part1(C, Array3);
            Console.WriteLine("------------------------------");
            Reversing(A, Array1);
            Reversing(B, Array2);
            Reversing(C, Array3);
            Console.WriteLine("------------------------------");
            Sorting(A,Array1);
            Sorting(B,Array2);
            Sorting(C,Array3);
            Console.WriteLine("------------------------------");
            Rotating(A, 2);
            Rotating(B, 2);
            Rotating(C, 2);



        }
      
    }
    
}
