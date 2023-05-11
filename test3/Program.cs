using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  [] myArray  = {10, 2, 3, 5};
            
            for (int i = myArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
              
        }
    }
}
