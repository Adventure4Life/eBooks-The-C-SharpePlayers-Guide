using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class ConsoleBuffer
    {
        //private static List<string> help = Initilise("StartGame");
        private static List<string> X = Initilise("X");
        private static List<string> Y = Initilise("O");
        public static List<string> frame { get; set; } = Initilise("StartGame"); // defaults as the help frame

        private static List<string> Initilise(string key)
        {
            List<string> v = new List<string>();
            if (key == "StartGame")
            {
                v.Add(" 	    _   _      _             _             ");
                v.Add("	   | | (_)    | |           | |                ");
                v.Add("	   | |_ _  ___| |_ __ _  ___| |_ ___   ___ ");
                v.Add("	   | __| |/ __| __/ _` |/ __| __/ _ \\ / _ \\");
                v.Add("	   | |_| | (__| || (_| | (__| || (_) |  __/");
                v.Add("	    \\__|_|\\___|\\__\\__,_|\\___|\\__\\___/ \\___| by A4L");
                v.Add("	 ═══════════════════════════════════════════════════");
                v.Add("");
                v.Add("   G'Day. Welcome to my Tic Tac Toe mid book assignment, Chapter 20 p130");
                v.Add("   of \"The C# Players Guide\". The assignment is to create a 2 player game");
                v.Add("   for Tic Tac Toe.");
                v.Add("");
                v.Add("   To place a piece on the board, press a number between 1 and 9. These");
                v.Add("   are written on the board to remind you. try using the NUM PAD as it");
                v.Add("   represents the board's grid clearly.");
                v.Add("");
                v.Add("   Have Fun!");
                frame = v;
            }
            else if (key == "X")
            {
                v.Add("╔═════════════╗");
                v.Add("║  ██     ██  ║");
                v.Add("║   ██   ██   ║");
                v.Add("║     ███     ║");
                v.Add("║   ██   ██   ║");
                v.Add("║  ██     ██  ║");
                v.Add("╚═════════════╝");
            }
            else if (key == "O")
            {
                v.Add("╔═════════════╗");
                v.Add("║   ███████   ║");
                v.Add("║  ██     ██  ║");
                v.Add("║  ██     ██  ║");
                v.Add("║  ██     ██  ║");
                v.Add("║   ███████   ║");
                v.Add("╚═════════════╝");
            }
            else if (key == "GameOver")
            {
                v.Add("");
                v.Add("");
                v.Add("");
                v.Add("");
                v.Add("          ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗");
                v.Add("         ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗");
                v.Add("         ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝");
                v.Add("         ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗");
                v.Add("         ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║");
                v.Add("");
                v.Add("                         Thanks for playing \"my Mid-Book\" Project!");
                v.Add("                             (The C# Players Guide - Chapter 20)");
                v.Add("");
            }else if (key == "NewBoard")
            {
                v.Add(" 	    _   _      _             _             ");
                v.Add("	   | | (_)    | |           | |                ");
                v.Add("	   | |_ _  ___| |_ __ _  ___| |_ ___   ___ ");
                v.Add("	   | __| |/ __| __/ _` |/ __| __/ _ \\ / _ \\");
                v.Add("	   | |_| | (__| || (_| | (__| || (_) |  __/");
                v.Add("	    \\__|_|\\___|\\__\\__,_|\\___|\\__\\___/ \\___| by A4L");
                v.Add("	 ═══════════════════════════════════════════════════");
                v.Add("           ╔═════════════╗ ╔═════════════╗ ╔═════════════╗");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ╚═════════════╝7╚═════════════╝8╚═════════════╝9");
                v.Add("           ╔═════════════╗ ╔═════════════╗ ╔═════════════╗");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ╚═════════════╝4╚═════════════╝5╚═════════════╝6");
                v.Add("           ╔═════════════╗ ╔═════════════╗ ╔═════════════╗");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ║             ║ ║             ║ ║             ║");
                v.Add("           ╚═════════════╝1╚═════════════╝2╚═════════════╝3");
            }
            return v;
        }

        public static void GameOver()
        {
            frame = Initilise("GameOver");
        }

        public static void NewGameBoard()
        {
            frame = Initilise("NewBoard");
        }
    }
}
