using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList list = new SuperList() {74, 2.5, 3, 25, 2, 50, 73.3};
            double min;
            double max;

            list.GetMinMax1(out min, out max);
            Console.WriteLine($"Minimum value:{min}\nMaximum value:{max}\n");
            list.GetMinMax2();
            Console.WriteLine($"Minimum value:{min}\nMaximum value:{max}\n");
            list.GetMinMax3();
            Console.WriteLine($"Minimum value:{min}\nMaximum value:{max}\n");
            list.GetMinMax4();
            Console.WriteLine($"Minimum value:{min}\nMaximum value:{max}\n");
        }
    }
}
