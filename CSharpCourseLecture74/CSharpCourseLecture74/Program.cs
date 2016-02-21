using System;
using ComputingServices.ArithmeticServices;
using ComputingServices.FinanceServices;

/*
Lecture 74: Fully Qualified Names
*/

class Program
{
    static void Main()
    {
        Console.WriteLine($"Sum of 4 and 5 is {BasicMath.Add(4, 5)}");
        Console.WriteLine($"This interest amount is {FinanceMath.FindInterest(0.05, 56788)}");
    }
}