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
            Console.WriteLine("My perimeter is {0}", sideLength * 4);
        }
    }

    class UseShapes
    {
        static void Main()
        {
            Square mySqr = new Square(5);
        }
    }
}