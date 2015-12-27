//Usings allow us to access external features
using System;

namespace Sample
{
    class Program
    {
        //Entry point into program
        static void Main()
        {
            //Font color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Enter Session Name");
            Console.Title = Console.ReadLine();
            Console.WriteLine("Enter First Value");

            //Read Input from line
            //double.Parse converts to numerical value
            double inputFirst = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Value");

            //Read Input from line
            //doubleParse converts to numerical value
            double inputSecond = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum is {0} ", inputFirst + inputSecond);
            Console.WriteLine("Difference is {0} ", inputFirst - inputSecond);
        }
    }
}