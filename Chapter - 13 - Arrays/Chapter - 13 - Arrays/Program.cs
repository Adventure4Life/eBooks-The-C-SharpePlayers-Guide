using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Copying an Array. Write code to create a copy of an array. First, start by creating an initial array. (You
can use whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values in the
array.
Now create a second array variable. Give it a new array with the same length as the first. Instead of
using a number for this length, use the Length property to get the size of the original array.
Use a loop to read values from the original array and place them in the new array. Also print out the
contents of both arrays, to be sure everything copied correctly.*/

namespace Chapter___13___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arraySource = new int[10]{ 4, 51, -7, 13, -99, 15, -8, 45, 90, 16 };
            int[] arraySource = new[] { 4, 51, -7, 13, -99, 15, -8, 45, 90, 16 };
            int[] arrayCopy = new int[arraySource.Length];
            for (int i = 0; i < arraySource.Length; i++)
            {
                arrayCopy[i] = arraySource[i];
            }
            Console.WriteLine();
            for (int i = 0; i < arraySource.Length; i++)
            {
                if (i >= 1)
                {
                    Console.Write($" , {arraySource[i]}");
                }
                else { Console.Write($"Array Source = {arraySource[i]}"); }
            }
            Console.WriteLine();
            for (int i = 0; i < arrayCopy.Length; i++)
            {
                if (i >= 1)
                {
                    Console.Write($" , {arrayCopy[i]}");
                }
                else { Console.Write($"Array Copy = {arrayCopy[i]}"); }
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}