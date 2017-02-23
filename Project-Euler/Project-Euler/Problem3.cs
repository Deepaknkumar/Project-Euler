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
    class Problem3
    {
        // Problem 3: Largest Prime Factor
        // The prime factors of 13195 are 5, 7, 13 and 29.
        // What is the largest prime factor of the number 600851475143 ?

        public double result { get; set; }
        public double num { get; set; }
        
        public Problem3(double num)
        {
            this.num = num;
        }

        public List<Double> FindFactors() {
            List<Double> factors = new List<double>();
            for(int i = 1; i < Math.Sqrt(this.num)+1; i+=2)
            {
                if((num/i) == 0)
                {
                    factors.Add(i);
                }
            }
            return factors;
        }

        public double FindLargestPrimeFactor(List<Double> factors) {
            double largestPrimeFactor = 1;
            
            foreach(double fac in factors)
            {
                if(fac)
            }
        }

    }
}
