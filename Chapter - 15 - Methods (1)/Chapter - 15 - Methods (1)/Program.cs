using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter___15___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            CountToTen();
            Console.ReadKey();
        }

        static void CountToTen()
        {
            Console.Write("\n1");
            for (int i = 2; i <= 10; i++)
            {
                Console.Write($", {i}");
            }
            Console.Write("\n");
        }
    }
}