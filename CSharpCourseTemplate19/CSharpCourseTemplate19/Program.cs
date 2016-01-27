//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate19
{
    class Program
    {
        static void Main(string[] args)
        {
            //'out' variables are declared but not initialized here in Main()
            string funcDesc; double interestRate;
            decimal amt;

            //Ternary operator working for us again....
            //If successful conversion to user form, return amt
            //otherwise return default value of 0.0
            decimal finAmount = decimal.TryParse(Console.ReadLine(), out amt) ? amt : 0.0m;

            //Call function
            Increment(ref finAmount, out interestRate, out funcDesc);

            Console.WriteLine("{0}", funcDesc);
            Console.WriteLine("At {0:p2}, the interest is {1:c}.", interestRate, finAmount);
        }

        //With 'out' you can return multiple values from a single function
        static void Increment(ref decimal amount, out double rate, out string description)
        {
            description = "Increment function called.";
            rate = 0.05;
            amount = amount * (decimal)rate;
        }
    }
}