using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        private double GetMin(this)
        {
            double min = this[0];
            foreach(double n in this)
            {
                if (n < min)
                {
                    min = n;
                }
            }
            return min;
        }
        private double GetMax(this)
        {
            double max = this[0];
            foreach(double n in this)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            return max;
        }
        private (out double, out double) GetMinMax1()
        {

        }
        private (double, double) GetMinMax2()
        {

        }
        private (ref double, ref double) GetMinMax3()
        {

        }
        private (double min, double max) GetMinMax4()
        {

        }
    }
}