using System;


namespace Add_to_array
{
    internal class Program
    {

        static void Add_to_start(ref int[] arr, int newValue)
        {
            int [] newArr = new int[arr.Length + 1];

            newArr[0] = newValue;
            for (int i = 0;i < arr.Length; i++)
            {
                newArr[i+1] = arr[i];
            }
            arr = newArr;

        }

        static void Add_to_end(ref int[] arr, int newValue)
        {
            int [] newArr = new int[arr.Length + 1];

            newArr[arr.Length] = newValue;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;

        }

        static void Add_to_index(ref int[] arr, int newValue, int index)
        {
            int[] newArr = new int[arr.Length + 1];
            
            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[index] = newValue;

            for (int i = index; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }
            arr = newArr;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 13,7,6};

            Console.Write("Enter where to add value(start, end, index): ");
            string place = Console.ReadLine();
            if (place == "start")
            {
                Console.Write("Enter what to add: ");
                int value = int.Parse(Console.ReadLine());

                Add_to_start(ref myArray, value);
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }

            }

            else if (place == "end")
            {
                Console.Write("Enter what to add: ");
                int value = int.Parse(Console.ReadLine());

                Add_to_end(ref myArray, value);
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }

            }

            else if (place == "index")
            {
                Console.Write("Enter what to add: ");
                int value = int.Parse(Console.ReadLine());

                Console.Write("Enter index: ");
                int index = int.Parse(Console.ReadLine());

                Add_to_index(ref myArray, value, index);
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }

            }
            else
            {
                Console.WriteLine("You entered incorrect data");
            }
                

        }
    }
}
