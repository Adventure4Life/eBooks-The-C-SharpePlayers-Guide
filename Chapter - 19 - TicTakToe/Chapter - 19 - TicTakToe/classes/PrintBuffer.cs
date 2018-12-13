using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_TicTakToe
{
    class PrintBuffer
    {
        static private void PrintFrameBuffer()
        {
            foreach (var line in ConsoleBuffer.frame)
            {
                Console.WriteLine(line);
            }
        }

        static public void PrintStartFrame()
        {
            PrintFrameBuffer();
            Console.Write("\n   Press N to QUIT or ANY KEY to Play : ");
        }

        static public void PrintNewFrame()
        {
            Console.Clear();
            PrintFrameBuffer();
        }
    }
}
