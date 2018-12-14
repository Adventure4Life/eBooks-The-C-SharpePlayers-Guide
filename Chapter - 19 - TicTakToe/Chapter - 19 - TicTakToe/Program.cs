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
            Engine.Initilise();

            while (GameState.GameHasNotEnded())
            { 
                // ** Display the Start Screen **
                if (GameState.drawStartScreen)
                {
                    Engine.DrawStartScreen();
                }

                if (GameState.drawScoreBoard)
                {
                    Engine.ScoreBoardScreen();
                }
                
                // ** Main Game Loop **
                if (GameState.loopInput)
                {
                    Engine.PlayGame();
                }

                // ** Game Over... Quit or New Game (Draw New Board).
                if (GameState.drawGameOver)
                {
                    Engine.GameOver();
                }
                else if (GameState.drawEmptyBoard)
                {
                    Engine.NewGameBoard();
                }
            }


            //TMP DEBUGGING
            Debuging();
        }

        static void Debuging()
        {
            //Tmp Debug
            Console.WriteLine("                                  *** END OF PROGRAM ***\n");
            Console.ReadKey();
        }
    }
}

/*

                    // Welcome Screen / new Game Screen
                if (!GameState.PlayingTheGame() && GameState.RestartingGame() && !GameState.ReadyForScore())
                {
                    Engine.NewGame();
                    UserInput.StartGame();
                }

                // If the we are PLAYING THE GAME and we are STARTING A NEW GAME - newGame!
                if (GameState.PlayingTheGame() && GameState.RestartingGame() && !GameState.ReadyForScore())
                {
                    Engine.NewGameBoard();
                }

                //The Actual Game Input Loop
                if (GameState.PlayingTheGame() && !GameState.RestartingGame() && !GameState.ReadyForScore())
                {
                    PrintBuffer.PrintUserInput();
                    UserInput.Input();
                }

                // if we have STOPPED PLAYING THE GAME but we have NOT STARTED A NEW GAME - Score
                if (!GameState.PlayingTheGame() && !GameState.RestartingGame() && GameState.ReadyForScore())
                {
                    Console.Clear();
                    Console.WriteLine("*************************************");
                }

                // If the we are NOT PLAYING THE GAME and we are NOT STARTING A NEW GAME - quit!
                if (!GameState.PlayingTheGame() && !GameState.RestartingGame() && !GameState.ReadyForScore())
                {
                    Engine.GameOver();
                }
    
    
    
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
