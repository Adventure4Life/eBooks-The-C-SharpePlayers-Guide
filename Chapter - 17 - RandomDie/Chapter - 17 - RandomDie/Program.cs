using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Die Rolling. Tons of games use dice. The Random class gives us the ability to simulate die rolling.
Many games give the player the task of rolling multiple six-sided dice and adding up the results.
We’re going to write a program that makes life easier for the player of a game like this. Start the
program off by asking the player to type in a number of dice to roll. Create a new Random object and
use the Random.Next method to simulate that many die rolls. Add the total up and print the result
to the user. (You should only need one Random object for this.)
For bonus points, keep looping and handle new numbers until they enter “quit” or “exit.”*/
namespace Chapter___17___RandomDie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopAll = false;
            while (loopAll == false)
            {
                Console.Write("Please enter amount of D6 Die to roll (between 1 and 22) : ");
                string input = UserInput();
                if (int.TryParse(input, out int n))
                {
                    int timesToRoll = Convert.ToInt32(input);
                    int[] rolls = new int[timesToRoll];
                    Random ranSeed = new Random();
                    for (int i = 0; i < timesToRoll; i++)
                    {
                        rolls[i] = DieD6(ranSeed);
                    }
                    Console.Write($"You have rolled {timesToRoll} D6 die : ");
                    PrintIntArray(rolls);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.ReadKey();
                    loopAll = true;
                }
            }
        }
        static void PrintIntArray(int[] a)
        {
            Console.Write(a[0]);
            int total = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                total += a[i];
                Console.Write($" , {a[i]}");
            }
            Console.Write($"\nFor a toal roll of : {total}");
        }
        static int DieD6(Random ranSeed)
        {
            int n = 0;
            //Random randomD6 = new Random();
            n = ranSeed.Next(1, 7);
            return n;
        }

        static string UserInput()
        {
            bool valid = false;
            string userInput = "";
            while (valid == false)
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit" || userInput.ToLower() == "exit")
                {
                    Console.WriteLine("\nBye, bye!");
                    valid = true;
                    return userInput;
                }
                else
                {
                    if (int.TryParse(userInput, out int input))
                    {
                        if (input >= 1 && input <= 22)
                        {
                            valid = true;
                            return userInput;
                        }
                        else { Console.Write("Please, only enter a number between 1-22 : "); }
                    }
                    else { Console.Write("Please, only enter a number between 1-22: "); }
                }
            }
            return userInput;
        }
    }
}