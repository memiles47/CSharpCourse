using System;
using CompServices;

/*
Lecture 73: Create a Dynamic Link
Librry and Reference it
*/

namespace CSharpCourseLecture73
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new Calculator object
            Caluclator calc = new Caluclator();

            //Use methods within the Calculator object
            Console.WriteLine(calc.Add(4, 5));
            Console.WriteLine(calc.Divide(10, 5));
            Console.WriteLine(calc.Divide(4, 0));
        }
    }
}