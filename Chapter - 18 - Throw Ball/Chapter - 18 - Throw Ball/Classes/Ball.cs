using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*--== Create a Ball class ==--
    The Ball class should have instance variables for size and color(the Color class you just
created). Let's also add an instance variable that keeps track of the number of times it has
been thrown.
    Create any constructors you feel would be useful.
    Create a Pop method, which changes the ball's size to 0.
    Create a Throw method that adds 1 to the throw count, but only if the ball hasn't been
popped (has a size of 0).
    A method that returns the number of times the ball has been thrown*/
namespace Chapter18DesigningBuildingClasses
{
    class Ball
    {
        private Random ranCol = new Random();
        public int size { set; get; }
        private int thrown = 0;
        //private bool popped = false;
        public Colour colour = new Colour();

        public Ball()
        {
            colour.red = Convert.ToByte(ranCol.Next(255));
            colour.green = Convert.ToByte(ranCol.Next(255));
            colour.blue = Convert.ToByte(ranCol.Next(255));
            this.size = Convert.ToInt32(ranCol.Next(255));
        }

        public Ball(int s)
        {
            colour.red = Convert.ToByte(ranCol.Next(255));
            colour.green = Convert.ToByte(ranCol.Next(255));
            colour.blue = Convert.ToByte(ranCol.Next(255));
            this.size = s;
        }

        public Ball(int s, byte a)
        {
            colour.red = Convert.ToByte(ranCol.Next(255));
            colour.green = Convert.ToByte(ranCol.Next(255));
            colour.blue = Convert.ToByte(ranCol.Next(255));
            colour.alpha = a;
            this.size = s;
        }

        public Ball(byte r, byte g, byte b, int s)
        {
            colour.red = r;
            colour.green = g;
            colour.blue = b;
            this.size = s;
        }

        public Ball(byte r, byte g, byte b, int s, byte a)
        {
            colour.red = r;
            colour.green = g;
            colour.blue = b;
            colour.alpha = a;
            this.size = s;
        }

        public void Pop()
        {
            size = 0;
        }

        public void ThrowBall()
        {
            if (size > 0) { thrown++; }
        }

        public int GetThrown()
        {
            return thrown;
        }
    }
}