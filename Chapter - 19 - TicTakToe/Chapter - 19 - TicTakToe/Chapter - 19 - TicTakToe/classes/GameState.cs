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
        static public bool[] isSlotFree { get; set; } = { false, true, true, true, true, true, true, true, true, true };

        //Check for End of Game
        static public bool GameEndTest()
        {
            // check 789, 456, 123 == X || Y - Winner
            // check 159, 357 == X || Y - Winner
            // Check 123456789 == X || Y == draw
            return rungame;
        }

        static public void SetGameEnd()
        {
            rungame = false;
        }

        static public void ClearBoard()
        {
            for (int i=0; i<isSlotFree.Length; i++)
            { isSlotFree[i] = true; }
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
