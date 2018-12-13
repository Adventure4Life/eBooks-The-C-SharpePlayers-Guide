using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter___12___Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                **********
                **********
                **********
                **********
                **********
             */
            for (int row = 0; row < 5; row++) // loops 5 times.. once for each row
            {
                for (int col = 0; col < 10; col++) // loops 10 times, once for each * on each row.
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            /*
                *
                **
                ***
                ****
                *****
                ******
                *******
                ********
                *********
                **********
            */
            Console.WriteLine();
            for (int row = 0; row < 10; row++) // Loop 10 times for 10 rows.
            {
                for (int col = 0; col <= row; col++) // draw a star in each row. Using the row number to deterring the loop count to draw that many stars
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            /*
                *       4
               ***      3
              *****     2
             *******    1
            *********   0
            */
            //Console.WriteLine();
            for (int row = 0; row < 10; row++) // Loop 10 times for 10 rows.
            {
                for (int col = 10; col >= row; col--) // draw a pace in each row. Using the row number to deterring the loop count to draw that many space, but reversed. So row 1 draws 10.
                {
                    Console.Write(" ");
                }
                for (int str = 1; str < row * 2; str++) // now draw stars after the spaces, use the row count as the star count, but doubled to get pyrimd.
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        } // End of Main{}


    }
}