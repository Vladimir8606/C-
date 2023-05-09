using System;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            string str, str2;
            double rate = 18.30;
            Console.WriteLine("Enter carrency you want to change USD or ZAR: ");
            str = Console.ReadLine();
            Console.WriteLine("Enter amount: ");
            str2 = Console.ReadLine();
            b=Convert.ToInt32(str2);
            if (str == "USD") 
            {
                double result = b * rate;
                Console.WriteLine("You'll recive " + result + "ZAR");
            }
            else if (str == "ZAR")
            {
                double result = b/rate;
                Console.WriteLine("You'll recive " + result + "USD");

            }
            else
            {
                Console.WriteLine("Incorrect carrency");
            }

        }
    }
}
