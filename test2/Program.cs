using System;
using System.Linq;

namespace test2
{
    internal class Program
    {
        static void SUN(int a)
        {
            Console.WriteLine(a);

            a++;
            SUN(a);
        }

        static void Main(string[] args)
        {
            SUN(0);
                
        }
    }
}
