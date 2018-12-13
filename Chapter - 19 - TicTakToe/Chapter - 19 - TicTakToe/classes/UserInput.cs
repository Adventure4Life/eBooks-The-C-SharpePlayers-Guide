using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class UserInput
    {
        public static void StartGame()
        {
            ConsoleKeyInfo command;
            command = Console.ReadKey();
            if (command.Key == ConsoleKey.Escape || command.Key == ConsoleKey.Q || command.Key == ConsoleKey.N)
            {
                GameState.SetGameEnd();
            }
        }

        public static void Input()
        {
            int col = ConsoleBuffer.frame[12].Length + 10;
            int row = 14;
            ConsoleKeyInfo command;

            Console.SetCursorPosition(col, row);
            Console.Write("Press a Number between 1 and 9 : "); row++;
            command = Console.ReadKey();
        }
    }
}
