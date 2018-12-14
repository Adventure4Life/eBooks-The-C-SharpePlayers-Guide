using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class GameState
    {
        static public bool rungame { get; set; } = true;
        static public bool drawStartScreen { get; set; } = true;
        static public bool loopInput { get; set; } = true;

        static public bool drawEmptyBoard { get; set; } = false;
        static public bool drawScoreBoard { get; set; } = false;
        static public bool drawGameOver { get; set; } = false;


        static public bool score; // = true;
        static public string winner; // = "inProgress";
        static public bool[] isSlotTaken = new bool[10];  //{ get; set; } // = { true, false, true, false, false, false, false, false, false, false };
        static public string[] playerTokens = new string[10]; //{ get; set; } // = { '_', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static public void Initilise()
        {
            // Initilise State Switches
            rungame = true;
            drawStartScreen = true;
            loopInput = true;

            drawEmptyBoard = false;
            drawScoreBoard = false;
            drawGameOver = false;

            // Initialise Print variables
            score = false;
            winner = "inProgress";

            // Initialise isSlotTaken all False, but 1st is true.
            for (int i = 0; i < isSlotTaken.Length; i++ )
            {
                isSlotTaken[i] = false;
            }
            isSlotTaken[0] = true;

            // Initialise playerTokens all False, but 1st is true.
            for (int i = 0; i < playerTokens.Length; i++)
            {
                playerTokens[i] = i.ToString();
            }
            playerTokens[0] = "_";

        }

        static public bool ReadyForScore()
        {
            return score;
        }

        static public bool GameHasNotEnded()
        {
            CheckForWinAt(1,2,3);
            CheckForDraw();
            return rungame;
        }

        static private void CheckForWinAt(int a, int b, int c)
        {
            // Check for 123
            bool[] wonX = new bool[c+1]; for (int i = 0; i < wonX.Length; i++) { wonX[i] = false; }
            bool[] wonY = new bool[c+1]; for (int i = 0; i < wonY.Length; i++) { wonY[i] = false; }

            //if (won.Count == 3)
            if (isSlotTaken[a] && isSlotTaken[b] && isSlotTaken[c])
            {
                for (int i = 1; i < wonX.Length; i++)
                {
                    if (playerTokens[i] == "Y") { wonX[i] = true; } // These are reversed due to how the play token increments. : (
                    if (playerTokens[i] == "X") { wonY[i] = true; } // These are reversed due to how the play token increments. : (
                }
            }

            bool xRow = wonX[a] && wonX[b] && wonX[c];
            bool yRow = wonY[a] && wonY[b] && wonY[c];

            if (xRow)
            {
                for (int i = 0; i < playerTokens.Length; i++) { playerTokens[i] = "_"; }
                for (int i = 0; i < wonX.Length; i++) { wonX[i] = false; }
                winner = "winer_X";
                Engine.SetShowScore();
            }
            else if (yRow)
            {
                for (int i = 0; i < playerTokens.Length; i++) { playerTokens[i] = "_"; }
                for (int i = 0; i < wonX.Length; i++) { wonX[i] = false; }
                winner = "winer_Y";
                Engine.SetShowScore();
            }
        }

        static private void CheckForDraw()
        {
            // Check for Draw
            bool draw = isSlotTaken.All(x => x);
            if (draw)
            {
                winner = "Draw";
                Engine.SetShowScore();
            }
        }
    }
}
