﻿/*
 * Author : Deepak Kumar (Deepak.n.sonukumar@gmail.com)
 */


using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Problem2
    {
        // Problem 2: Even Fibonacci Numbers
        // Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:
        // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

        public double result { get; set; }
        public double initValue { get; set; }
        public double finalValue { get; set; }

        public Problem2() {
            this.initValue = 0;
            this.finalValue = 4000000;
        }

        public Problem2(double init, double finalVal) {
            this.initValue = init;
            this.finalValue = finalVal;
        }

        public List<Double> createFibonacci()
        {
            List<Double> fibonacciSeries = new List<Double>();
            double newElement;
            double prevElement;
            double currElement;

            fibonacciSeries.Add(0);
            fibonacciSeries.Add(1);
            currElement = (Double) fibonacciSeries[1];
            prevElement = (Double) fibonacciSeries[0];
            newElement = prevElement + currElement;

            while(newElement <= finalValue)
            {
                fibonacciSeries.Add(newElement);
                currElement = newElement;
                prevElement = (Double)fibonacciSeries[fibonacciSeries.Count - 2];
                newElement = currElement + prevElement;
                Console.WriteLine("New Element to be Added is {0}", newElement);

            }
            return fibonacciSeries;
        }


        public double computeSum() {
            List<Double> fibonacciSeries = createFibonacci();
            double sumVal = 0;

            foreach(Double fibElement in fibonacciSeries)
            {
                if (fibElement % 2 == 0)
                {
                    sumVal += fibElement;
                }
            }

            result = sumVal;
            return result;
        }
    }
}
