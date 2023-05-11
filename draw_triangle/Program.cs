using System;


namespace draw_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());
            
            /*
             1-st triangle
             * 
             **
             ***
             ****
             
             */
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("#");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            /*
             2-d triangle
             ****
             ***
             **
             *
             
             */

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                    Console.Write("#");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();


            /*
             3-d triangle
                *
               **
              ***
             ****

             */


            for (int i = 0; i < height; i++)
            {
                for (int j = height-1; j > i; j--)
                    Console.Write(" ");
                for (int k = 0; k <= i; k++)
                    Console.Write("#");
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();



            /*
             4-th triangle
              ****
               ***
                **
                 *

             */

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(" ");
                for (int k = height-1; k >= i; k--)
                    Console.Write("#");
                Console.WriteLine();
            }

        }
    }
}

