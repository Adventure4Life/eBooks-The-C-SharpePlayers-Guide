using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class GameState
    {
        static public bool rungame; // = true;
        static public bool newgame; // = true;
        static public bool score; // = true;
        static public string winner; // = "inProgress";
        static public bool[] isSlotTaken = new bool[10];  //{ get; set; } // = { true, false, true, false, false, false, false, false, false, false };
        static public string[] playerTokens = new string[10]; //{ get; set; } // = { '_', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static public void Initilise()
        {
            // Initialise rungame and winner
            rungame = false;
            newgame = true;
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

        static public void SetScore()
        {
            newgame = false;
            rungame = false;
            score = true;
        }

        static public void SetGameEnd()
        {
            newgame = false;
            rungame = false;
            score = false;
        }

        static public bool PlayingTheGame()
        {
            return rungame;
        }

        static public bool RestartingGame()
        {
            return newgame;
        }

        static public bool ReadyForScore()
        {
            return score;
        }
    }
}
