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
        private double GetMin()
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
        private double GetMax()
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
        public struct MinMaxStruct
        {
            public double Min {get; }
            public double Max {get; }

            public MinMaxStruct(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }
        public void GetMinMax1(out double min, out double max)
        {
            min = GetMin();
            max = GetMax();
        }
        public MinMaxStruct GetMinMax2()
        {
            return new MinMaxStruct(GetMin(), GetMax());
        }
        public (double, double) GetMinMax3()
        {
            return (GetMin(), GetMax());
        }
        public (double min, double max) GetMinMax4()
        {
            return (GetMin(), GetMax());
        }
    }
}