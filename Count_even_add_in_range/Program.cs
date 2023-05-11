using System;


namespace Count_even_add_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int even_count, odd_count;
            even_count = 0;
            odd_count = 0;

            Console.WriteLine("Enter firts value");
            int firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int secondValue = int.Parse(Console.ReadLine());

            while (firstValue <= secondValue)
            {
                if (firstValue % 2 == 0)
                    even_count++;
                else
                    odd_count++;
                firstValue++;
            }
            Console.WriteLine("Even numbers: " + even_count);
            Console.WriteLine("Odd numbers: " + odd_count);
        }
    }
}
