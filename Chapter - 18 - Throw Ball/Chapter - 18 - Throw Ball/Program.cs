using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*******************
**** Try It Out! ***
********************
Designing and Building Classes. Try creating the two classes below, and make a simple program to
work with them, as described below.

Write some code in your Main method to create a few balls, throw them around a few times, pop a
few, and try to throw them again, and print out the number of times that the balls have been thrown.
(Popped balls shouldn't have changed.)

--== Create a Color class ==--
    On a computer, colors are typically represented with a red, green, blue, and alpha
(transparency) value, usually in the range of 0 to 255. Add these as instance variables.
    A constructor that takes a red, green, blue, and alpha value.
    A constructor that takes just red, green, and blue, while alpha defaults to 255 (opaque).
    Methods to get and set the red, green, blue, and alpha values from a Color instance.
    A method to get the grayscale value for the color, which is the average of the red, green and
blue values.

--== Create a Ball class ==--
    The Ball class should have instance variables for size and color (the Color class you just
created). Let's also add an instance variable that keeps track of the number of times it has
been thrown.
    Create any constructors you feel would be useful.
    Create a Pop method, which changes the ball's size to 0.
    Create a Throw method that adds 1 to the throw count, but only if the ball hasn't been
popped (has a size of 0).
    A method that returns the number of times the ball has been thrown*/

namespace Chapter18DesigningBuildingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Ran Ran = new Ran();
            Console.WriteLine("Lets create some balls!");

            List<Ball> balls = new List<Ball>();
            for (int i = 0; i < Ran.Int(5, 50); i++)
            {
                balls.Add(new Ball(Ran.Int(1, 25)));
            }
            Console.WriteLine($"We have just created : {balls.Count} : balls!");

            Console.WriteLine($"Lets throw those balls around, up to a dozen times each.");
            for (int iList = 0; iList < balls.Count; iList++)
            {
                for (int iTrow = 0; iTrow < Ran.Int(1, 12); iTrow++)
                {
                    balls[iList].ThrowBall();
                }
                Console.WriteLine($"   Ball {iList + 1} has been thrown {balls[iList].GetThrown()} times.");
            }

            Console.WriteLine($"Now lets Pop at least 5 balls but no more then 10!");
            bool loopPop = true;
            for (int i = 0; i < Ran.Int(5, 10); i++)
            {
                while (loopPop)
                {
                    int iList = Ran.Int(balls.Count);
                    if (balls[iList].size > 0)
                    {
                        balls[iList].Pop();
                        loopPop = false;
                    }
                }
                loopPop = true;
            }
            for (int iList = 0; iList < balls.Count; iList++)
            {
                if (balls[iList].size == 0)
                {
                    Console.WriteLine($"   Ball {iList + 1} has been POPPED!!");
                }
            }

            Console.WriteLine($"Now Lets throw the remaining balls around at most a three dozen more times");
            for (int iList = 0; iList < balls.Count; iList++)
            {
                for (int iTrow = 0; iTrow < Ran.Int(1, 36); iTrow++)
                {
                    balls[iList].ThrowBall();
                }
                if (balls[iList].size > 0)
                {
                    Console.WriteLine($"   Now Ball {iList + 1} has been thrown {balls[iList].GetThrown()} times.");
                }
            }

            int finalPopCount = 0;
            int finalThrownCountPopped = 0;
            int finalThrownCountWhole = 0;
            for (int iList = 0; iList < balls.Count; iList++)
            {
                if (balls[iList].size == 0)
                {
                    finalPopCount++;
                    finalThrownCountPopped = finalThrownCountPopped + balls[iList].GetThrown();
                }
                else { finalThrownCountWhole = finalThrownCountWhole + balls[iList].GetThrown(); }
            }

            Console.WriteLine($"\n*******************\n   Final Results\n*******************\n");
            Console.WriteLine($"We had {balls.Count} balls to play with.");
            Console.WriteLine($"The {finalPopCount} Popped balls were Thrown a total of : {finalThrownCountPopped} times");
            Console.WriteLine($"The {balls.Count - finalPopCount} unPopped balls were Thrown a total of : {finalThrownCountWhole} times");
            Console.WriteLine($"In total all the balls were Thrown a total of : {finalThrownCountPopped + finalThrownCountWhole} times");

            Console.WriteLine("\n: Thrown Values for each POPPED ball : ");
            for (int iList = 0; iList < balls.Count; iList++)
            {
                if (balls[iList].size == 0)
                {
                    Console.WriteLine($"   Ball {iList + 1} has been thrown {balls[iList].GetThrown()} times.");
                }
            }

            Console.WriteLine("\n: Thrown Values for each UNPOPPED ball : ");
            for (int iList = 0; iList < balls.Count; iList++)
            {
                if (balls[iList].size > 0)
                {
                    Console.WriteLine($"   Ball {iList + 1} has been thrown {balls[iList].GetThrown()} times.");
                }
            }

            ExitConsole.AK();
        }
    }

}