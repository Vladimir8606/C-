using System;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 2, 3, 5, 10, 66, 34, 23, 3, 2 };
            int[] result = myArray.Distinct().ToArray();
            for(int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);

        }
    }
}
