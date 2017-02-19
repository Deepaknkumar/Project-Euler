using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem2 p2 = new Problem2();
            p2.computeSum();
            Console.WriteLine("The Result is {0}\n", p2.result);

            //Problem1 p1 = new Problem1();
            //p1.computeSumOf3Or5Multiples();
            //Console.WriteLine("The Result is {0}\n", p1.result);

        }
    }
}
