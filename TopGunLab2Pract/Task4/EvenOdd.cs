using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace TopGunLab2Pract.Task4
{
    public class EvenOdd
    {


        public void GetEven(int[] allNum)
        {
            int[] evenArr = allNum
                     .Where(item => item % 2 == 0)
                     .Select(item => item)
                     .ToArray();
            string arrType = "Even numbers: ";
            PrintArr(evenArr, arrType);

        }
        public void GetOdd(int[] allNum)
        {
            int[] oddArr = allNum
                     .Where(item => item % 2 != 0)
                     .Select(item => item)
                     .ToArray();
            string arrType = "Odd numbers: ";
            PrintArr(oddArr, arrType);
        }

        public void PrintArr(int[] arr, string arrType)
        {
            Console.WriteLine(arrType);
            foreach (var t in arr)
            {
                Console.Write(t + ", ");
            }
            Console.WriteLine();
        }
    }
}
