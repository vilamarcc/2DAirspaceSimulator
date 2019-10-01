using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlightPlanClass;

namespace pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightPlan fp1 = new FlightPlan("i1", "c1", 30, 0, 0, 50, 50, 30);
            FlightPlan fp2 = new FlightPlan("i2", "c2", 30, 0, 50, 50, 0, 30);
            int conflict=fp1.Willbeinconflict(fp2);
            if (conflict == 0)
                Console.WriteLine("no va a haber conflicto");
            else
                Console.WriteLine("va a haber  conflicto");
            Console.ReadLine();
        }
    }
}
