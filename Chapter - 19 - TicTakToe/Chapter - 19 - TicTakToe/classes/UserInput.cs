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
                if (GameState.isSlotTaken[9] == false)
                { Engine.PlaceToken(9); GameState.isSlotTaken[9] = true; GameState.playerTokens[9] = Engine.player; }
            }
            if (command.Key == ConsoleKey.D8 || command.Key == ConsoleKey.NumPad8)
            {
                if (GameState.isSlotTaken[8] == false)
                { Engine.PlaceToken(8); GameState.isSlotTaken[8] = true; GameState.playerTokens[8] = Engine.player; }
            }
            if (command.Key == ConsoleKey.D7 || command.Key == ConsoleKey.NumPad7)
            {
                if (GameState.isSlotTaken[7] == false)
                { Engine.PlaceToken(7); GameState.isSlotTaken[7] = true; GameState.playerTokens[7] = Engine.player; }
            }
            if (command.Key == ConsoleKey.D6 || command.Key == ConsoleKey.NumPad6)
            {
                if (GameState.isSlotTaken[6] == false)
                { Engine.PlaceToken(6); GameState.isSlotTaken[6] = true; GameState.playerTokens[6] = Engine.player; }
            }
            if (command.Key == ConsoleKey.D5 || command.Key == ConsoleKey.NumPad5)
            {
                if (GameState.isSlotTaken[5] == false)
                { Engine.PlaceToken(5); GameState.isSlotTaken[5] = true; GameState.playerTokens[5] = Engine.player; }
            }
            if (command.Key == ConsoleKey.D4 || command.Key == ConsoleKey.NumPad4)
            {
                if (GameState.isSlotTaken[4] == false)
                { Engine.PlaceToken(4); GameState.isSlotTaken[4] = true; GameState.playerTokens[4] = Engine.player; }
            }
            if (command.Key == ConsoleKey.D3 || command.Key == ConsoleKey.NumPad3)
            {
                if (GameState.isSlotTaken[3] == false)
                { Engine.PlaceToken(3); GameState.isSlotTaken[3] = true; GameState.playerTokens[3] = Engine.player; }
            }
            if (command.Key == ConsoleKey.D2 || command.Key == ConsoleKey.NumPad2)
            {
                if (GameState.isSlotTaken[2] == false)
                { Engine.PlaceToken(2); GameState.isSlotTaken[2] = true; GameState.playerTokens[2] = Engine.player; }
            }
            if (command.Key == ConsoleKey.D1 || command.Key == ConsoleKey.NumPad1)
            {
                if (GameState.isSlotTaken[1] == false)
                { Engine.PlaceToken(1); GameState.isSlotTaken[1] = true; GameState.playerTokens[1] = Engine.player; }
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
