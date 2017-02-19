/*
 * Author : Deepak Kumar (Deepak.n.sonukumar@gmail.com)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Problem1
    {
        // Problem Statement:
        // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        // Find the sum of all the multiples of 3 or 5 below 1000.

        public double result { get; set; }
        public double initValue { get; set; }
        public double finalValue { get; set;}

        public Problem1()
        {
            this.initValue = 0;
            this.finalValue = 1000;
        }

        public Problem1(double init, double finalVal)
        {
            this.initValue = init;
            this.finalValue = finalVal;
        }

        public double computeSumOf3Or5Multiples()
        {
            result = computeSum();
            return result;
        }

        private double computeSum() {
            double sumVal = 0;
            for(int i=0; i < this.finalValue; i++)
            {
                if ((i%3 == 0) || (i%5 == 0))
                {
                    sumVal += i;
                }
            }
            return sumVal;
        }
    }
}
