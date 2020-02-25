using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();// instances of the class
            Point bottomRight = new Point(1366, 768);// instances// point object
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}");
            Point maxwell = new Point(1, 1);
            Point roxana = new Point(4, 5);
            distance = maxwell.DistanceTo(roxana);
            Console.WriteLine($"Distance is: {distance}");
            Console.WriteLine($"Number of Point objects:{Point.ObjectCount()}." +
                $"This is he value of objectCount");
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
