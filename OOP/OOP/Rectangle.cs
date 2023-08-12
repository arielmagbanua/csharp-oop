using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Rectangle
    {
        private int width;
        private int height;
        private int area;

        public Rectangle()
        {
            this.width = 0;
            this.height = 0;
            this.area = 0;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetDimensions(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public void Print()
        {
            Console.WriteLine("Width: " + this.width);
            Console.WriteLine("Height: " + this.height);
        }

        public int ComputeArea()
        {
            this.area = this.width * this.height;

            return this.area;
        }
    }
}
