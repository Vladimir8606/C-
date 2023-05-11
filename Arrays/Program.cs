using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Fill array

            int[] myArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter number " + i);
                myArray[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine();
            Console.WriteLine();


            //Array revers


            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            // Sum all even numbers

            int evenSum = 0;

            for (int i = 0; i<myArray.Length; i++)
            {
                if (myArray[i]%2 == 0)
                    evenSum += myArray[i];
            }
            Console.WriteLine("Sum all even numbers: " + evenSum);

            Console.WriteLine();
            Console.WriteLine();

            //Lowest Value

            int lowestValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] <lowestValue)
                    lowestValue = myArray[i];
            }
            Console.WriteLine("Lowest value: " + lowestValue);

        }
    }
}
