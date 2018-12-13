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
        public static void StartGame()
        {
            GameState.StartGame();
            PrintBuffer.PrintStartFrame();
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
    }
}
