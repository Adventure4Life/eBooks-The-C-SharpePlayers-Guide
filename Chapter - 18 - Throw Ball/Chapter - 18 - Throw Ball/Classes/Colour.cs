using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*--== Create a Color class ==--
    On a computer, colors are typically represented with a red, green, blue, and alpha
(transparency) value, usually in the range of 0 to 255. Add these as instance variables.
    A constructor that takes a red, green, blue, and alpha value.
    A constructor that takes just red, green, and blue, while alpha defaults to 255 (opaque).
    Methods to get and set the red, green, blue, and alpha values from a Color instance.
    A method to get the grayscale value for the color, which is the average of the red, green and
blue values.*/
namespace Chapter18DesigningBuildingClasses
{
    class Colour
    {
        public byte red { get; set; } = 0;
        public byte green { get; set; } = 0;
        public byte blue { get; set; } = 0;
        public byte alpha { get; set; } = 255;

        public Colour() { }

        public Colour(byte r, byte g, byte b)
        {
            this.red = r;
            this.green = g;
            this.blue = b;
        }
        public Colour(byte r, byte g, byte b, byte a)
        {
            this.red = r;
            this.green = g;
            this.blue = b;
            this.alpha = a;
        }

        public byte GetGrayScale()
        {
            float caculation = (red + green + blue) / 3;
            return Convert.ToByte(caculation);
        }
    }
}