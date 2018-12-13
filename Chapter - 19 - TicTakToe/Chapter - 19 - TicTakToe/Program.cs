using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialise the game and display the welcome screen
            Engine.StartGame();
            UserInput.StartGame();

            do
            {
                // If the we are PLAYING THE GAME and we are STARTING A NEW GAME - newGame!
                if (GameState.PlayingTheGame() && GameState.RestartingGame())
                {
                    Engine.NewGameBoard();
                }

                //The Actual Game Input Loop
                if (GameState.PlayingTheGame())
                {
                    UserInput.Input();
                }

                // If the we are NOT PLAYING THE GAME and we are NOT STARTING A NEW GAME - quit!
                if (!GameState.PlayingTheGame() && !GameState.RestartingGame())
                {
                    Engine.GameOver();
                }

            } while (GameState.PlayingTheGame());

            /*while(GameState.PlayingTheGame())
            {
                Console.WriteLine("LOOP IS WORKING");
            }*/



            //TMP DEBUGGING
                Debuging();
        }

        static void Debuging()
        {
            //Tmp Debug
            //Console.WriteLine("*** END OF PROGRAM ***\n");
            Console.ReadKey();
        }
    }
}

/*
        // Test Contents of "isSlotTaken" 
        for (int i = 0; i < GameState.isSlotTaken.Length; i++)
        {
            if (GameState.isSlotTaken[i])
                Console.WriteLine("True");
            else if (!GameState.isSlotTaken[i])
                Console.WriteLine("False");
        }

       // Test Contents of "playerTokens"
       for (int i = 0; i < GameState.playerTokens.Length; i++)
            {
                string s = GameState.playerTokens[i];
                Console.WriteLine(s);
            }
*/
