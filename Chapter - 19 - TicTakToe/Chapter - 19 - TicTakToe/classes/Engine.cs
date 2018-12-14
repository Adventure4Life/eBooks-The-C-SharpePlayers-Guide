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
        }

        public static void Initilise()
        {
            Random randomPlayer = new Random();
            player = "X";
            if (randomPlayer.Next(2) == 0) { player = "Y"; }
            GameState.Initilise();
        }

        //******************************************
        //************* Game Functions *************
        //******************************************

        public static void PlayGame()
        {
            PrintBuffer.PrintUserInput();
            UserInput.Input();
        }

        public static void GameOver()
        {
            ConsoleBuffer.GameOver();
            PrintBuffer.PrintNewFrame();
        }

        //**************************************************
        //************* Start of Game Switches *************
        //**************************************************

        // This loads the very 1st screen.. the "Start Screen"
        public static void DrawStartScreen()
        {
            // Set Switches
            GameState.drawStartScreen = true;
            GameState.drawEmptyBoard = true;

            GameState.loopInput = false;
            GameState.rungame = false;
            GameState.drawScoreBoard = false;
            GameState.drawGameOver = false;
            
            ConsoleBuffer.NewGame();
            PrintBuffer.PrintStartFrame();
            UserInput.StartOrQuitGame();
        }

        public static void NewGameBoard()
        {
            // Set Switches
            Engine.Initilise();
            GameState.rungame = true;
            GameState.loopInput = true;

            GameState.drawEmptyBoard = false;
            GameState.drawStartScreen = false;
            GameState.drawScoreBoard = false;

            ConsoleBuffer.NewGameBoard();
            PrintBuffer.PrintNewFrame();
        }

        public static void ScoreBoardScreen()
        {
            ConsoleBuffer.Results(GameState.winner);
            PrintBuffer.PrintScore();
            UserInput.ScoreBoardScreen();
        }

        // This is the main drawing function to pace the player tokens on the board. 
        // The majority of the game happens here.
        public static void PlaceToken(int num)
        {
            ConsoleBuffer.PlaceToken(num, player);
            PrintBuffer.PlaceToken();
        }

        //*******************************************
        //************* Set Game States *************
        //*******************************************

        static public void SetGameEnd()
        {
            // Set Switches
            GameState.drawGameOver = true;

            GameState.loopInput = false;
            GameState.drawStartScreen = false;
            GameState.rungame = false;
            GameState.drawEmptyBoard = false;
            GameState.drawScoreBoard = false;
        }

        static public void SetShowScore()
        {
            // Set Switches
            GameState.drawScoreBoard = true;
            GameState.rungame = true;

            GameState.loopInput = false;
            GameState.drawGameOver = false;
            GameState.drawStartScreen = false;
            GameState.drawEmptyBoard = false;
        }

    }
}
