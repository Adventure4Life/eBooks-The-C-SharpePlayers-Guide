using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class Engine
    {
        // Engine Variables
        static public string player { get; set; } = "X";

        // Initialise the Class: ENGINE. 
        // Set the Player Variable to randomly choose X or Y for the 1st player.
        static Engine()
        {
            Random randomPlayer = new Random();
            if (randomPlayer.Next(2) == 0) { player = "Y"; }
        }

        // This loads the very 1st screen.. the "Start Screen"
        public static void Initilise()
        {
            GameState.Initilise();
        }

        // This loads the very 1st screen.. the "Start Screen"
        public static void NewGame()
        {
            ConsoleBuffer.NewGame();
            PrintBuffer.PrintStartFrame();
            GameState.rungame = true;
        }

        public static void NewGameBoard()
        {
            ConsoleBuffer.NewGameBoard();
            PrintBuffer.PrintNewFrame();
            GameState.newgame = false;
        }

        public static void GameOver()
        {
            ConsoleBuffer.GameOver();
            PrintBuffer.PrintNewFrame();
        }

        // This is the main drawing function to pace the player tokens on the board. 
        // The majority of the game happens here.
        public static void PlaceToken(int num)
        {
            ConsoleBuffer.PlaceToken(num, player);
            PrintBuffer.PlaceToken();
        }
    }
}
