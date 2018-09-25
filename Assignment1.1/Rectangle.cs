using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 5;
            width = 5;
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

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int Getperimeter()
        {
            return 2*(length + width);
        }

        public int Getarea()
        {
            return length * width;
        }
    }
}

