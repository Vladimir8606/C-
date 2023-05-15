using System;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = { 10, 2, 3, 5, 10, 66, 34, 23, 3, 2 };
            //  int[] result = myArray.Distinct().ToArray();
            // for(int i = 0; i < result.Length; i++)
            //    Console.WriteLine(result[i]);

            int[,] myArray2 = new int[10, 10];

            Random random = new Random();

            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    myArray2[i, j] = random.Next(100);
                }
            }



            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    Console.Write(myArray2[i, j] + "\t");

                }
                Console.WriteLine();
            }
                
        }
    }
}
