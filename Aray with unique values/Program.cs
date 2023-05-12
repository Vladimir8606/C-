using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aray_with_unique_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 2, 3, 5, 10, 66, 34, 23, 3, 2 };

            int unique_count = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < i; j++)
                {
                    if (i == j)
                        continue;
                    else
                        if (myArray[i] == myArray[j])
                        flag = false;

                }
                if (flag == true)
                    unique_count++;



            }
            int[] uniqueArray = new int[unique_count];
            int k = 0;




            for (int i = 0; i < myArray.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < i; j++)
                {
                    if (i == j)
                        continue;
                    else
                        if (myArray[i] == myArray[j])
                        flag = false;

                }
                if (flag == true)
                {
                    uniqueArray[k] = myArray[i];
                    k++;
                }
            }
            for (int z = 0; z < uniqueArray.Length; z++)
                Console.WriteLine(uniqueArray[z]);

        }
    }
}
