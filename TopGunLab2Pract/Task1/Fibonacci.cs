using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TopGunLab2Pract
{
   public class Fibonacci
    {
        public void Count(int n)
        {
           List<int> fibonacci = new List<int>();
            Enumerable.Range(0, n)
                .ToList()
                .ForEach(f => fibonacci.Add((f <= 1 ? 1 : fibonacci[f - 2] + fibonacci[f - 1])));
            Console.WriteLine("Fibonacci sequence:");
            foreach (int num in fibonacci)
            {
                Console.Write(num + ", ");
            }
        }
    }
}
