using System;


namespace Calc_switch
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

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Result = " + (first_number + second_number));
                    break;
                case "-":
                    Console.WriteLine("Result = " + (first_number - second_number));
                    break;
                case "*":
                    Console.WriteLine("Result = " + (first_number * second_number));
                    break;
                case "/":
                    if (second_number ==0)
                        Console.WriteLine("No devide by zero");
                    else
                        Console.WriteLine("Result = " + (first_number / second_number));
                        break;
                default:
                    Console.WriteLine("Error, unknown action");
                    break;
            }
            
            Console.ReadLine();
            }
    }
}
