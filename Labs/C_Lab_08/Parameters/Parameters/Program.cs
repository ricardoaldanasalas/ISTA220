﻿#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(i);
            Console.WriteLine(i);
            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
            Console.WriteLine("----------------");
            int j = 1776;
            Console.WriteLine(j);
            Pass.Value2(ref j);
            Console.WriteLine(j);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
