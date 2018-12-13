using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ************************
             * ***** Integer Types ****
             * ************************
             * int = 2million(ish)
             * byte = 0-255
             * short = 32,000(ish)
             * long = 9quintillion(ish)
             * 
             * ushort, uint, ulong - unsigned (can not be negitive, thus doubling the positive range.
             * sbytpe : byte is unsigned by default, so this allows negitive numbers by halving the positive range.
            */
            int theMeaningOfLife = 42;
            Console.WriteLine("The Meaning of Life = " + theMeaningOfLife);

            byte baseTri = 5;
            byte heightTri = 8;
            float areaTri = baseTri * heightTri / 2;

            Console.WriteLine("The Area of a triangle, with a base of 5 and height of 8 is : " + areaTri);

            int testOps = 5;
            testOps++;
            Console.WriteLine("++ == " + testOps);
            testOps += testOps;
            Console.WriteLine("var += var == " + testOps);




            Console.ReadKey();
        }
    }
}