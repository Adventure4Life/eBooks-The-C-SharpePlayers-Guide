using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class PrintBuffer
    {
        static public void PrintStartFrame()
        {
            Console.Clear();
            PrintFrameBuffer();
            Console.Write("\n   Press Q to QUIT or ANY KEY to Play : ");
        }

        static public void PrintNewFrame()
        {
            Console.Clear();
            PrintFrameBuffer();
        }

        static public void PrintUserInput()
        {
            int col = 70;
            int row = 14;
            Console.SetCursorPosition(col, row);
            Console.Write("Press a Number between 1 and 9 : ");
        }

        static public void PlaceToken()
        {
            Console.SetCursorPosition(0, 0);
            PrintFrameBuffer();
        }

        static public void PrintScore()
        {
            int col = 59;
            int row = 8;
            foreach (var line in ConsoleBuffer.results)
            {
                Console.SetCursorPosition(col, row);
                Console.WriteLine(line);
                row++;
            }
            Console.SetCursorPosition(col, row);
            Console.Write("             Please (Q)uit or start a (N)ew Game : ");
        }

        static private void PrintFrameBuffer()
        {
            foreach (var line in ConsoleBuffer.frame)
            {
                Console.WriteLine(line);
            }
        }
    }
}
