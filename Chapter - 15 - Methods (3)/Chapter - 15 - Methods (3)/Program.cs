using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Reversing an Array. Let’s make a program that uses methods to accomplish a task. Let’s take an
array and reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.*/
namespace Chapter___15___Method_TryItOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter - 15 - Methods (3)");
            int userInput = GetNumberFromUser();
            int[] numbers = GenNumbers(userInput);
            PrintNumbers(numbers);
            int[] reversed = ReverseNumbers(numbers);
            PrintNumbers(reversed);
            Console.ReadKey();
        }
        /// <summary>
        /// Takes a input from the user of a number between 1 and 30
        /// </summary>
        /// <returns>The user entered number.</returns>
        static int GetNumberFromUser()
        {
            int usersNumber = 0;
            while (usersNumber < 1 || usersNumber > 30)
            {
                Console.Write("Enter a number between 1 and 30: ");
                string usersResponse = Console.ReadLine();
                usersNumber = Convert.ToInt32(usersResponse);
            }
            return usersNumber;
        }
        /// <summary>
        /// Takes a input from the user of a number between 1 and 30
        /// </summary>
        /// <param name="numbers">The first number to multiply</param>
        /// <param name="b">The second number to multiply</param>
        /// <returns>The user entered number.</returns>
        static int[] ReverseNumbers(int[] numbers)
        {
            int[] reversedNums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                reversedNums[numbers.Length - 1 - i] = numbers[i];
            }
            return reversedNums;
        }
        static void PrintNumbers(int[] numbers)
        {
            Console.Write($"{numbers[0]}");
            for (int i = 1; i < numbers.Length; i++)
            {
                Console.Write($", {numbers[i]}");
            }
            Console.Write("\n");
        }

        static int[] GenNumbers(int n)
        {
            int[] genN = new int[n];
            for (int i = 0; i < n; i++)
            {
                genN[i] = i + 1;
            }
            return genN;
        }
    }
}