using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private int lenght;
        private int width;

        public Rectangle()
        {
            lenght = 1;
            width = 1;
        }

        public int Length
        {
            set { lenght = value; } 
            get { return lenght; }
        }


        public int Width
        {
            set { width = value; }
            get { return width; }
        }


        public int GetPerimeter()
        {
            return ((2 * width) + (2 * lenght));
        }

        public int GetArea()
        {
            return (width * lenght);
        }
    }
}
