using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter___9___More_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 7;
            int v2 = 3;
            /*float v1 = 7f;
            float v2 = 3f;*/
            float result = (float)v1 / (float)v2;
            Console.WriteLine($"{v1}/{v2} == " + result);
            Console.ReadKey();
        }
    }
}