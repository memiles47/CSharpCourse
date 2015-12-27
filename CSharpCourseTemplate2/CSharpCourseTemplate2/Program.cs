//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read window height
            double h1 = Console.WindowHeight;

            //Read window width
            double w1 = Console.WindowWidth;

            //Compute variable
            double ratioD = h1 / w1;

            Console.WriteLine("h1 divided by w1 is {0}.", ratioD);
            Console.WriteLine("");

            //Read window height as int
            int h2 = Console.WindowHeight;

            //Read window width as int
            int w2 = Console.WindowWidth;

            //Compute variable as int
            int ratioI = h2 / w2;

            Console.WriteLine("h2 divided by w2 is {0}.", ratioI);
        }
    }
}
