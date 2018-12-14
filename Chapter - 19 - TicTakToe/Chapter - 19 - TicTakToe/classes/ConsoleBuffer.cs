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
        public static List<string> results { get; set; }

        private static List<string> Initilise(string key)
        {
            List<string> v = new List<string>();
            if (key == "NewGame")
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

        public static List<string> Results(string key)
        {
            List<string> r = new List<string>();
            if (key == "Draw")
            {
                r.Add(@"                   ___");
                r.Add(@"                  /   \_ __ __ ___      __");
                r.Add(@"                 / /\ / '__/ _` \ \ /\ / /");
                r.Add(@"                / /_//| | | (_| |\ V  V /_");
                r.Add(@"               /___,' |_|  \__,_| \_/\_/(_)");
                r.Add(@"     __                           __    __ _             ");
                r.Add(@"  /\ \ \___     ___  _ __   ___  / / /\ \ (_)_ __  ___");
                r.Add(@" /  \/ / _ \   / _ \| '_ \ / _ \ \ \/  \/ / | '_ \/ __|");
                r.Add(@"/ /\  / (_) | | (_) | | | |  __/  \  /\  /| | | | \__ \_");
                r.Add(@"\_\ \/ \___/   \___/|_| |_|\___|   \/  \/ |_|_| |_|___(_)");
                r.Add("");
            }
            else if (key == "winer_X")
                {
                r.Add(@"              ___ _                        __  __");
                r.Add(@"             / _ \ | __ _ _   _  ___ _ __  \ \/ /");
                r.Add(@"            / /_)/ |/ _` | | | |/ _ \ '__|  \  / ");
                r.Add(@"           / ___/| | (_| | |_| |  __/ |     /  \ ");
                r.Add(@"           \/    |_|\__,_|\__, |\___|_|    /_/\_\");
                r.Add(@"                          |___/                  ");
                r.Add(@"                     __    __ _                    ");
                r.Add(@"                    / / /\ \ (_)_ __  ___");
                r.Add(@"                    \ \/  \/ / | '_ \/ __|");
                r.Add(@"                     \  /\  /| | | | \__ \_");
                r.Add(@"                      \/  \/ |_|_| |_|___(_)");
                r.Add("");
                }
            else if (key == "winer_Y")
            {
                r.Add(@"              ___ _                        __  __");
                r.Add(@"             / _ \ | __ _ _   _  ___ _ __  \ \/ /");
                r.Add(@"            / /_)/ |/ _` | | | |/ _ \ '__|  \  / ");
                r.Add(@"           / ___/| | (_| | |_| |  __/ |     /  \ ");
                r.Add(@"           \/    |_|\__,_|\__, |\___|_|    /_/\_\");
                r.Add(@"                          |___/                  ");
                r.Add(@"                     __    __ _                    ");
                r.Add(@"                    / / /\ \ (_)_ __  ___");
                r.Add(@"                    \ \/  \/ / | '_ \/ __|");
                r.Add(@"                     \  /\  /| | | | \__ \_");
                r.Add(@"                      \/  \/ |_|_| |_|___(_)");
                r.Add("");
            }
            results = r;
            return r;
        }

        public static void NewGame()
        {
            frame = Initilise("NewGame");
        }

        public static void GameOver()
        {
            frame = Initilise("GameOver");
        }

        public static void NewGameBoard()
        {
            frame = Initilise("NewBoard");
        }

        public static void PlaceToken(int num, string player)
        {
            int row = 0;
            int col = 0;
            //Set cursor locations to draw the player tokens.
            switch (num)
            {
                case 1:
                    row = 21;
                    col = 11;
                    break;
                case 2:
                    row = 21;
                    col = 27;
                    break;
                case 3:
                    row = 21;
                    col = 43;
                    break;
                case 4:
                    row = 14;
                    col = 11;
                    break;
                case 5:
                    row = 14;
                    col = 27;
                    break;
                case 6:
                    row = 14;
                    col = 43;
                    break;
                case 7:
                    row = 7;
                    col = 11;
                    break;
                case 8:
                    row = 7;
                    col = 27;
                    break;
                case 9:
                    row = 7;
                    col = 43;
                    break;
            }

            int posInstert = 0;
            if (player == "X")
            {
                for (int i = row; i < row + X.Count; i++)
                {
                    string source = frame[i];
                    string insert = X[posInstert];
                    var sb = new StringBuilder(source);
                    sb.Remove(col, X[posInstert].Length);
                    sb.Insert(col, insert);
                    frame[i] = sb.ToString();
                    posInstert++;
                    //GameState.playerTokens[num] = Engine.player;
                }
                Engine.player = "Y";
            }
            else if (player == "Y")
            {
                for (int i = row; i < row + X.Count; i++)
                {
                    string source = frame[i];
                    string insert = Y[posInstert];
                    var sb = new StringBuilder(source);
                    sb.Remove(col, Y[posInstert].Length);
                    sb.Insert(col, insert);
                    frame[i] = sb.ToString();
                    posInstert++;
                    //GameState.playerTokens[num] = Engine.player;
                }
                Engine.player = "X";
            }
        }
    }
}
