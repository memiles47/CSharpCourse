//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get width of window
            int w = Console.WindowWidth;

            //Get height of window
            int h = Console.WindowHeight;


            Console.WriteLine("Perimeter is {0}.", (2*w)+(2*h));
            Console.WriteLine("w is bigger than h by {0}.", w - h);
            Console.WriteLine("h goes into w {0} times.", w/h);
            Console.WriteLine("Area of window is "+ w*h);
            String i = Console.ReadLine();
        }
    }
}
