using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOut1_CylindersCompleteProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player's Guide to C#\nTry Out 01 - Chapter 7 'User Input' \n\nThis code will not check for errors and only accept numbers.");
            Console.WriteLine("Please input the Base Radius of a Cylinder");
            string userInput = Console.ReadLine();
            float numBaseRad = Convert.ToSingle(userInput);
            Console.WriteLine("Radius of the Base : " + numBaseRad);
            Console.WriteLine("\nPlease input the Height of a Cylinder");
            userInput = Console.ReadLine();
            float numHeight = Convert.ToSingle(userInput);
            Console.WriteLine("Height : " + numHeight);

            float pi = 3.1415926f;
            float outRadius = pi * numBaseRad * numBaseRad * numHeight;
            Console.WriteLine($"\nThe Volume of the Cylinder is : {outRadius}");
            float outSurfaceA = 2 * pi * numBaseRad * (numBaseRad + numHeight);
            Console.WriteLine($"The Surface area of the Cylinder is : {outSurfaceA}");



            Console.ReadKey();
        }
    }
}