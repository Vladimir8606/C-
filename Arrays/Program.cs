using System;


namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Fill array

            Console.Write("Enter the length of array: ");
            int number = int.Parse(Console.ReadLine());


            int[] myArray = new int[number];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter number {i}:\t");
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

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] <lowestValue)
                    lowestValue = myArray[i];
            }
            Console.WriteLine("Lowest value: " + lowestValue);

        }
    }
}
