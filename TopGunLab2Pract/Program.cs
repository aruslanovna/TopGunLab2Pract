using System;
using System.Collections.Generic;
using System.Linq;
using TopGunLab2Pract.ModelAndLinq;
using TopGunLab2Pract.Task4;

namespace TopGunLab2Pract
{
   
        class Program
        {
            static void Main(string[] args)
            {
            int[] allNumbers = { 3, 6, 2, 5, 24, 63, 26, 32, 62, 7, 0, 6, 2 };

            EvenOdd e = new EvenOdd();
            e.GetEven(allNumbers);
            e.GetOdd(allNumbers);

            ProcessData pr = new ProcessData();
            pr.GetWorkersGroupByCompany();

            Fibonacci fib = new Fibonacci();
                 fib.Count(6);

                Factorial fact = new Factorial();
                  fact.Count(7);

                Console.ReadKey();
            }
           


          
        }
    
}
