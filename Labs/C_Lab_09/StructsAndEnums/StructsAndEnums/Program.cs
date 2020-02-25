﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Month first = Month.January;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            Month last = Month.December;
            Console.WriteLine(last);
            last++;
            Console.WriteLine(last);
            Console.WriteLine("______________");
            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2017, Month.July, 4);
            Console.WriteLine(weddingAnniversary);
            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");

            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New Value of weddinAniiversary is {weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");
        }

        static void Main()
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
