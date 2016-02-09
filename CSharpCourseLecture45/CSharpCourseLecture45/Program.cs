using System;

namespace Shapes
{

    //Define Parent Class
    class Quad
    {
        //Define a field
        private const int sides = 4;

        public Quad()
        {
            Console.WriteLine("I'm a Quad. I have four sides");
        }
    }

    //This ":" means that Square derives from Quad
    class Square : Quad
    {
        private int sideLength;

        public Square(int length)
        {
            //Sets the squares side length
            this.sideLength = length;

            Console.WriteLine("This quad is a \"Square\"");
            Console.WriteLine("My perimeter is {0}", sideLength * 4 + "\n\n");
        }
    }

    class Rectangle : Quad
    {
        private int recLength;
        private int recWidth;

        public Rectangle(int length, int width)
        {
            //Sets the length and width of the rectangle
            this.recLength = length;
            this.recWidth = width;

            Console.WriteLine("This quad is a \"Rectangle\"");
            Console.WriteLine("My length is: " + this.recLength + "\nMy Width is: " + this.recWidth);
            Console.WriteLine("My perimeter is: {0}", (this.recLength * 2) + (this.recWidth * 2));
        }
    }

    class UseShapes
    {
        static void Main()
        {
            Square mySqr = new Square(5);

            Rectangle myRectangle = new Rectangle(5, 2);
        }
    }
}