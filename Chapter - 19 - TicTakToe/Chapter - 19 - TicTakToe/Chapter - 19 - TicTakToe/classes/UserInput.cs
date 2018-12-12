using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class UserInput
    {
        public static void TempPause()
        {
            Console.ReadKey();
        }

        public static void InputStart()
        {
            ConsoleKeyInfo command;
            command = Console.ReadKey();
            if (command.Key == ConsoleKey.Escape || command.Key == ConsoleKey.Q)
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

            if (command.Key == ConsoleKey.D9 || command.Key == ConsoleKey.NumPad9)
            {
                if (GameState.isSlotFree[9])
                { Engine.PlaceToken(9); GameState.isSlotFree[9] = false; }
            }
            if (command.Key == ConsoleKey.D8 || command.Key == ConsoleKey.NumPad8)
            {
                if (GameState.isSlotFree[8])
                { Engine.PlaceToken(8); GameState.isSlotFree[8] = false; }
            }
            if (command.Key == ConsoleKey.D7 || command.Key == ConsoleKey.NumPad7)
            {
                if (GameState.isSlotFree[7])
                { Engine.PlaceToken(7); GameState.isSlotFree[7] = false; }
            }
            if (command.Key == ConsoleKey.D6 || command.Key == ConsoleKey.NumPad6)
            {
                if (GameState.isSlotFree[6])
                { Engine.PlaceToken(6); GameState.isSlotFree[6] = false; }
            }
            if (command.Key == ConsoleKey.D5 || command.Key == ConsoleKey.NumPad5)
            {
                if (GameState.isSlotFree[5])
                { Engine.PlaceToken(5); GameState.isSlotFree[5] = false; }
            }
            if (command.Key == ConsoleKey.D4 || command.Key == ConsoleKey.NumPad4)
            {
                if (GameState.isSlotFree[4])
                { Engine.PlaceToken(4); GameState.isSlotFree[4] = false; }
            }
            if (command.Key == ConsoleKey.D3 || command.Key == ConsoleKey.NumPad3)
            {
                if (GameState.isSlotFree[3])
                { Engine.PlaceToken(3); GameState.isSlotFree[3] = false; }
            }
            if (command.Key == ConsoleKey.D2 || command.Key == ConsoleKey.NumPad2)
            {
                if (GameState.isSlotFree[2])
                { Engine.PlaceToken(2); GameState.isSlotFree[2] = false; }
            }
            if (command.Key == ConsoleKey.D1 || command.Key == ConsoleKey.NumPad1)
            {
                if (GameState.isSlotFree[1])
                { Engine.PlaceToken(1); GameState.isSlotFree[1] = false; }
            }
            if (command.Key == ConsoleKey.N)
            {
                Engine.NewGame();
            }
            if (command.Key == ConsoleKey.Q || command.Key == ConsoleKey.Escape)
            {
                GameState.SetGameEnd();
            }

        }
    }
}
