using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Try It Out!
Months of the Year. Using the DaysOfWeek enumeration as an example, create an enumeration to
represent the months of the year. Assign them the values 1 through 12. Write a program to ask the
user for a number between 1 and 12. Check to be sure that they gave you a value in the right range
and use an explicit cast to convert the number to your month enumeration. Then, using a switch
statement or if statement to print out the full name of the month they entered.*/
namespace Chapter___14___Enumeration
{
    enum MonthsOfYear { January = 1, Feburay = 2, March = 3, April = 4, May = 5, June = 6, Jully = 7, August = 8, September = 9, October = 10, November = 11, December = 12 };
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPlease Enter a number between 1 and 12 : ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int input))
            {
                if (input >= 1 && input <= 12)
                {
                    MonthsOfYear month = (MonthsOfYear)input;
                    Console.Write($"You have entered the value : {input}");
                    Console.Write($". This is the month : {month}\n");
                }
                else { Console.WriteLine("Please, only enter a value of 1-12"); }
            }
            else { Console.WriteLine("Please, only enter a number"); }

            Console.ReadKey();
        }
    }
}