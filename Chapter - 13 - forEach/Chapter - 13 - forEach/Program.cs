using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Minimum and Averaging Revisited. Earlier in this chapter, I presented code to go through an array
and find the minimum value contained in it. I also presented code to average the values in an array.
Using that code as a starting point, rewrite them to use foreach loops instead.*/
namespace Chapter___13___forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int smallestVal = Int32.MaxValue;
            int avrage = 0;
            foreach (int val in array)
            {
                if (smallestVal > val) { smallestVal = val; }
                avrage = avrage + val;
            }
            Console.WriteLine($"The Smallest number in the array is : {smallestVal}");
            Console.WriteLine($"The avrage value in the array is : {avrage / array.Length}");
            Console.ReadKey();
        }
    }
}