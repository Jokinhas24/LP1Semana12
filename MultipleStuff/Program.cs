using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] list = {74, 2.5, 3, 25, 2, 50, 73.3};

            SuperList.GetMinMax1(list);
            SuperList.GetMinMax2(list);
            SuperList.GetMinMax3(list);
            SuperList.GetMinMax4(list);
        }
    }
}
