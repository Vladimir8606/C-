using System;


namespace Check_even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value: ");
            string str = Console.ReadLine();
            int value = int.Parse(str);
            if (value%2 == 0)
                Console.WriteLine("Value is even");
            else
                Console.WriteLine("Value is odd");
        }
    }
}
