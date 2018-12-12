using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class PrintBuffer
    {
        public static void Print(List<string> buffer, string action)
        {
            if (action == "NewFrame" || action == "StartFrame") { Console.SetCursorPosition(0, 0); }
            if (action == "FirstFrame" || action == "EndGame") { Console.Clear(); }
            foreach (var line in buffer)
            {
                Console.WriteLine(line);
            }
            if (action == "StartFrame")
            {
                Console.Write("\n   Press N to QUIT or ANY KEY to Play : ");
            }
        }
    }
}
