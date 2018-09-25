using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int AddWidth()
        {
            return width;
        }

        public int ChangeWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int Perimeter()
        {
            return (width * 2) + (length * 2);
        }

        public int Area()
        {
            return length * width;
        }
    }
}

