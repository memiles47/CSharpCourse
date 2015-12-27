//Usings allow us to access external features
using System;

class Program
{
    //Entry point into program
    static void Main()
    {
        //Every Square has four sides
        const int sidesToASquare = 4;
        const string title = "Simple Square Calculation";

        //Title the console window
        Console.Title = title;

        Console.WriteLine("Enter Side Length");
        
        //Read input from user
        string s = Console.ReadLine();          //Read String
        double sideLength = double.Parse(s);    //Convert String to Double

        //Calculate and print perimeter
        Console.WriteLine("The Perimeter is {0}.", sideLength * sidesToASquare);
    }
}