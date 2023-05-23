using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_recursive_array
{
    internal class Program
    {
        static void Print(int[] arr,int value)
        {
            
            if (value >= arr.Length)
            {
                return;
            }
            Console.WriteLine(arr[value]);
            value++;
            Print(arr,value);
        }

        static void SUM(int[] arr, int value, int summ)
        {
            if (value >= arr.Length)
            {
                Console.WriteLine("Summary is : " + summ);
                return;
            }
            summ += arr[value];
            value++;
            SUM(arr, value, summ);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 5, 10, 6, -3, 45 };
            int i = 0;
            int summ = 0;
            Print(myArray, i);

            Console.WriteLine();
            SUM(myArray, i,summ);
        }
    }
}
