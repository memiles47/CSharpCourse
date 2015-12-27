//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate5
{
    class Program
    {
        static void Main(string[] args)
        {
            //short is another data type
            Console.WriteLine("Max Value of short data type {0}."
                ,short.MaxValue);

            //Create an int
            int x = 455;

            //Explicit cast
            short y = (short)x;

            //Store value of x into x
            long z = x;

            Console.WriteLine("The value of y is {0} and "
                + "the value of z is {1}.", y, z);
        }
    }
}
