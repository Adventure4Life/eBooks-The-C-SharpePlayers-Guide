using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class UserInput
    {
        public static void StartOrQuitGame()
        {
            ConsoleKeyInfo command;
            command = Console.ReadKey();
            if (command.Key == ConsoleKey.Escape || command.Key == ConsoleKey.Q)
            {
                Engine.SetGameEnd();
            }
        }

        public static void ScoreBoardScreen()
        {
            ConsoleKeyInfo command;
            command = Console.ReadKey();
            if (command.Key == ConsoleKey.Escape || command.Key == ConsoleKey.Q)
            {
                Engine.Initilise();
                Engine.SetGameEnd();
            }
            else if (command.Key == ConsoleKey.N)
            {
                Engine.NewGameBoard();
            }
        }

        public static void Input()
        {
            ConsoleKeyInfo command;
            command = Console.ReadKey();

            if (char.IsDigit(command.KeyChar))
            {
                int key = int.Parse(command.KeyChar.ToString());
                if (GameState.isSlotTaken[key] == false)
                {
                    Engine.PlaceToken(key);

                    GameState.isSlotTaken[0] = true; // this is always true
                    GameState.isSlotTaken[key] = true;

                    GameState.playerTokens[0] = "_";
                    GameState.playerTokens[key] = Engine.player;
                }
            }
            else if (command.Key == ConsoleKey.Escape || command.Key == ConsoleKey.Q)
            {
                Engine.SetGameEnd();
            }
            else if (command.Key == ConsoleKey.N )
            {
                Engine.NewGameBoard();
            }
        }
    }
}
