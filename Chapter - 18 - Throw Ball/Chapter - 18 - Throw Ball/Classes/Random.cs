using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18DesigningBuildingClasses
{
    class Ran
    {
        Random ranByte = new Random();
        public byte Byte()
        {
            float r = ranByte.Next(255);
            return Convert.ToByte(r);
        }
        public int Int(int min, int max)
        {
            return ranByte.Next(min, max);
        }
        public int Int(int max)
        {
            return ranByte.Next(max);
        }

    }
}