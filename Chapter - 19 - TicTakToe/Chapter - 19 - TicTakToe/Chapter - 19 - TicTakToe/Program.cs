using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initilise the game and display the welcome screen
            Engine.StartGame();
            // Get User Input to Start Game Loop or Quit.
            UserInput.InputStart();
            // Print The First Frame if not Quit.
            if (GameState.GameEndTest()) Engine.NewGame();

            //Loop User Input until and End Game Condition is Met.
            while (GameState.GameEndTest())
            {
                UserInput.Input();
            }

            Engine.GameOver();
            // Temp Pause in Console for deBugging
            UserInput.TempPause();
        }
    }
}
