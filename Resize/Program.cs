using System;
using System.Diagnostics;

namespace Resize
{
    internal class Program
    {

        static void Resize(ref int[] arr, uint len)
        {
            int [] newArr = new int[len];
            if (len >= arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
            }
            else
            {
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
            }

            arr = newArr;
        }


        static void Main(string[] args)
        {
            int[] myArray = {1,4,6};

            Console.Write("Enter new length of array: ");
            uint length = uint.Parse(Console.ReadLine());
           

            Resize(ref myArray, length);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

        }
    }
}
