//using xxx brings in external features
using System;

//Namespace is the outer most level of grouping
namespace ComputingDevices
{
    class Calculator        //Declare a type
    {
        //Entry point into the program
        static void Main(string[] args)
        {
            //Declare an object of type Calculator
            Calculator myCalc;          //Instance of the class
            myCalc = new Calculator();  //Make the Calculator object
        }

        //Make a method that makes objects of type Calculator
        //Has the name constructor
        //public means you can get to this code from anywhere
        public Calculator()
        {
            Console.WriteLine("Runs when objects of type Calculator are created");
        }
    }
}
