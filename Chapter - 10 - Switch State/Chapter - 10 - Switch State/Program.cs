using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Use a switch statement to handle the different operations in different ways. Allow the user to type in
’+’ for addition, ’-’ for subtraction, ’*’ for multiplication, ’/’ for division, and ’%’ for remainder. For bonus
points, allow the user to type in ’^’ for a power. (You can compute this using the Math.Pow method.
For example, the following does x 2 : Math.Pow(x, 2);)
Print out the results for the user to see.*/


namespace Chapter___10___Switch_State
{
    class Program
    {
        static void Main(string[] args)
        {
            bool v1 = false; bool v2 = false;
            int v1s = 0; int v2s = 0;
            Console.WriteLine("Please Enter a integer.");
            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int value1))
            {
                Console.WriteLine($"Acepted Value : {value1}");
                Int32.TryParse(userInput, out v1s);
                v1 = true;

                Console.WriteLine("\nPlease Enter another integer.");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int value2))
                {
                    Console.WriteLine($"Acepted Value : {value2}");
                    Int32.TryParse(userInput, out v2s);
                    v2 = true;
                }
                else { Console.WriteLine("Please, only enter a integer"); }
            }
            else { Console.WriteLine("Please, only enter a integer"); }

            if (v1 && v2)
            {
                Console.WriteLine("\n\nPlease Enter a Operator Type (+, -, *, /, %, ^)");
                userInput = Console.ReadLine();
                if (userInput == "+" || userInput == "-" || userInput == "*" || userInput == "/" || userInput == "%" || userInput == "^")
                {
                    switch (userInput)
                    {
                        case "+":
                            Console.WriteLine($"{v1s}+{v2s} = {v1s + v2s}");
                            break;
                        case "-":
                            Console.WriteLine($"{v1s}-{v2s} = {v1s - v2s}");
                            break;
                        case "*":
                            Console.WriteLine($"{v1s}*{v2s} = {v1s * v2s}");
                            break;
                        case "/":
                            Console.WriteLine($"{v1s}/{v2s} = {v1s / v2s}");
                            break;
                        case "%":
                            Console.WriteLine($"{v1s}%{v2s} = {v1s % v2s}");
                            break;
                        case "^":
                            Console.WriteLine($"{v1s}^{v2s} = {Math.Pow(v1s, v2s)}");
                            break;
                    }
                }
                else { Console.WriteLine("Please Enter a correct Operator!"); }
            }
            else { Console.WriteLine("\n\nYou didn't enter two numbers!"); }

            Console.ReadLine();
        }
    }
}