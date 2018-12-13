using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Your mission, should you choose to accept it, is to create a method called Fibonacci, which takes in a
number and returns that number of the Fibonacci sequence. So if someone calls Fibonacci(3), it
would return the 3 rd number in the Fibonacci sequence, which is 2. If someone calls Fibonacci(8), it
would return 21. In your Main method, write code to loop through the first 10 numbers of the Fibonacci sequence and
print them out.*/
namespace Chapter___15___Method_Recursion_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 10; index++)
            {
                Console.WriteLine(Fibonacci(index));
            }

            Console.ReadKey();
        }

        /*  0, 1, 1, 2, 3, 5, 8, 13, 21, 34
         * 1
         * 1
         * 1+1=2
         * 1+2=3
         * 2+3=5
         * 3+5=8
         * 5+8=13
         * 8+13=21
         * 21+13=34
         */

        static ulong Fibonacci(int number)
        {
            if (number == 1) { return 1; }
            if (number == 2) { return 1; }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        static int Factorial(int n)
        {
            // We establish our "base case" here. When we get to this point, we're done.
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}