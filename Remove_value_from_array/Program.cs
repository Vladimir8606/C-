using System;


namespace Remove_value_from_array
{
    internal class Program
    {

        static void Remove_first(ref int[] arr)
        {
            int []newArray = new int[arr.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = arr[i + 1];
            }
            arr = newArray;
                
        }

        static void Remove_last(ref int[] arr)
        {
            int[] newArray = new int[arr.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
                
        }

        static void Remove_index(ref int[] arr, int index)
        {
            int[] newArray = new int[arr.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = arr[i];
            }

            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = arr[i + 1];
            }
            arr = newArray;
        }


        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 13, 7, 6 };

            Console.Write("Enter where to remove value(first, last, index): ");
            string place = Console.ReadLine();
            if (place == "first")
            {

                Remove_first(ref myArray);
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }

            }
            else if (place == "last")
            {
                Remove_last(ref myArray);
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
            else if (place == "index")
            {
                Console.Write("Enter indexd to delete: ");
                int index = int.Parse(Console.ReadLine());

                Remove_index(ref myArray, index);
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }

            }
            else
                Console.WriteLine("You entered incorrect data");


        }
    }
}
