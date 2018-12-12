using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class Engine
    {
        // Initilise the Class. Set the Player Variable to randomly choose X or Y for the 1st player.
        static public char player { get; set; } = 'X';
        static Engine()
        {
            Random randomPlayer = new Random();
            if (randomPlayer.Next(2) == 0) { player = 'Y'; }
        }

        // This loads the very 1st screen.. the "Start Screen"
        public static void StartGame()
        {
            PrintBuffer.Print(ConsoleBuffer.frame, "StartFrame");
        }
        
        // This loads the game board, ready to play.
        public static void NewGame()
        {
            ConsoleBuffer.NewGame();
            GameState.ClearBoard();
            PrintBuffer.Print(ConsoleBuffer.frame, "FirstFrame");
        }

        //This loads a help screen - NOT IMPLIMENTED
        public static void HelpScreen()
        {
            ConsoleBuffer.HelpScreen();
            PrintBuffer.Print(ConsoleBuffer.frame, "NewFrame");
        }

        // When you choose to quit completely, this is the screen that shows.
        public static void GameOver()
        {
            ConsoleBuffer.GameOver();
            PrintBuffer.Print(ConsoleBuffer.frame, "EndGame");
        }

        // This is the main drawing function to pace the player tokens on the board. 
        // The majority of the game happens here.
        public static void PlaceToken(int num)
        {
            ConsoleBuffer.PlaceToken(num, player);
            PrintBuffer.Print(ConsoleBuffer.frame, "NewFrame");
        }
    }
}
