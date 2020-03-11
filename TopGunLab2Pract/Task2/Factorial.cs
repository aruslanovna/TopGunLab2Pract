using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TopGunLab2Pract
{
   public class Factorial
    {
        public  void Count(int n)
        {
            int result = Enumerable
                    .Range(1, n)
                    .Aggregate((y, x) => y * x);
            Console.WriteLine(Environment.NewLine + $"Factorial from {n} = {result}");
        }
    }
}
