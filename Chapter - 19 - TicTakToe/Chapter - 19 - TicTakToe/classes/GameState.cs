using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class GameState
    {

        static public bool rungame = true;
        static public bool[] isSlotTaken { get; set; } = { true, false, true, false, false, false, false, false, false, false };
        static public char[] playerTokens { get; set; } = { '_', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static public string winner = "inProgress";

        //Check for End of Game
        static public bool GameEndTest()
        {
            // check 789, 456, 123 == X || Y - Winner
            // 147, 258, 369 == X || Y
            // check 159, 357 == X || Y - Winner
            // Check 123456789 == X || Y == draw

            bool draw = false;
            for (int i = 1; i < isSlotTaken.Length;i++)
            {
                if (isSlotTaken[i])
                { draw = true; }
                else { draw = false; }
            }

            if (draw) { rungame = false; winner = "Draw"; }

            /*
            //Test Horizontals
            if (isSlotTaken[1] && isSlotTaken[2] && isSlotTaken[3])
            { rungame = false; }
            if (isSlotTaken[4] && isSlotTaken[5] && isSlotTaken[6])
            { rungame = false; }
            if (isSlotTaken[7] && isSlotTaken[8] && isSlotTaken[9])
            { rungame = false; }

            //Test Verticals
            if (isSlotTaken[1] && isSlotTaken[4] && isSlotTaken[7])
            { rungame = false; }
            if (isSlotTaken[2] && isSlotTaken[5] && isSlotTaken[6])
            { rungame = false; }
            if (isSlotTaken[3] && isSlotTaken[6] && isSlotTaken[6])
            { rungame = false; }

            //test Diagonals
            if (isSlotTaken[1] && isSlotTaken[5] && isSlotTaken[9])
            { rungame = false; }
            if (isSlotTaken[3] && isSlotTaken[5] && isSlotTaken[7])
            { rungame = false; }
            */



            return rungame;
        }

        static public void SetGameEnd()
        {
            rungame = false;
        }

        static public void ClearBoard()
        {
            for (int i=0; i< isSlotTaken.Length; i++)
            { isSlotTaken[i] = false; }
        }

    }
}

//static private char[,] board { get; set; } = new char[3, 3];
/*
// Constructor setting each location to the activation value for easy debugging using the PrintBoard() member.
static GameState()
{
    int setting = 7;
    for (int x = 0; x < board.GetLength(0); x++)
    {
        if (x == 1) { setting = 4; } else if (x == 2) { setting = 1; }
        for (int y = 0; y < board.GetLength(1); y++)
        {
            board[x, y] = Convert.ToChar(setting.ToString());
            setting++;
        }
    }
}
// Just a quick Debug thing to print out the board in a quick way to see what is going on.
public static void PrintBoard()
{
    for (int x = 0; x < board.GetLength(0); x++)
    {
        for (int y = 0; y < board.GetLength(1); y++)
        {
            Console.Write(board[x, y]);
        }
        Console.WriteLine($"     - X = : {x}");
    }
}*/
