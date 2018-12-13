using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    The challenge is to print out all of the numbers from 1 to 100. Except if a number is a multiple of 3,
    print out the word “Fizz” instead. If the number is a multiple of 5, print out “Buzz”. If a number is a
    multiple of both 3 and 5 (like 15 or 30) then print out “FizzBuzz”. For example, “1 2 Fizz 4 Buzz Fizz 7 8
    Fizz Buzz…”
*/

namespace Chapter___12___FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1");
            for (int i = 2; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { Console.Write(", FizzBuzz"); }
                else if (i % 3 == 0) { Console.Write(", Fizz"); }
                else if (i % 5 == 0) { Console.Write(", Buzz"); }
                else { Console.Write($", {i}"); }
            }
            Console.ReadLine();
        }
    }
}