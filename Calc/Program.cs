using System;


namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter first number: ");
            string first_str = Console.ReadLine();
            
            Console.Write("Enter operation: ");
            string operation = Console.ReadLine();
            
            Console.Write("Enter second number: ");
            string second_str = Console.ReadLine();
            
            double first_number = double.Parse(first_str);
            double second_number = double.Parse(second_str);

            if (operation == "+")
                Console.WriteLine("Result = " + (first_number + second_number));

            else if (operation == "-")
                Console.WriteLine("Result = " + (first_number - second_number));

            else if (operation == "*")
                Console.WriteLine("Result = " + (first_number * second_number));

            else if (operation == "/")
                if (second_number != 0)
                    Console.WriteLine("Result = " + (first_number / second_number));

                else
                    Console.WriteLine("Error");


        }
    }
}
