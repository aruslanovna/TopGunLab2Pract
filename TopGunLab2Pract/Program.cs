using System;
using System.Collections.Generic;
using System.Linq;

namespace TopGunLab2Pract
{
    class Program
    {
        static void Main(string[] args)
        {

            Fibonacci(6);
            Factorial(4);
            Console.ReadKey();
        }
        public static void Factorial(int n)
        {
             int result = Enumerable
                     .Range(1, n)
                     .Aggregate((y, x) => y * x);
            Console.WriteLine(Environment.NewLine+$"Factorial from {n} = {result}");           
        }


        public static void Fibonacci(int n)
        {
            List<int> fibonacci = new List<int>();
            Enumerable.Range(0, n)
                .ToList()
                .ForEach(f => fibonacci.Add((f <= 1 ? 1 : fibonacci[f - 2] + fibonacci[f - 1])));
            Console.WriteLine("Fibonacci sequence:");
            foreach (int num in fibonacci)
            {
                Console.Write( num + ", ");
            }           
        }
    }
}
