using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void PrintLine(string symbol, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        static int Array_count(int [] myArray, int value)
        { 
            int count = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == value)
                {
                    count = i+1;
                    break;
                }
                    
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbol: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("How many times to repeat: ");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine();
            PrintLine(symbol, times);
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Enter item to look for: ");
            int item = int.Parse(Console.ReadLine());

            int[] myArray2 = { 1, 3, 5, 4, 7, 10 };
            Console.WriteLine($"The value {item} has a number: " + Array_count(myArray2, item)); 


        }
    }
}
