using System;

namespace ComputingDevice
{
    class Program
    {
        static void Main()
        {
            //Obtain user name
            Console.Write("Session User:>");
            string user = Console.ReadLine().ToUpper();
            ClearConsole();

            //Make new calculator object/class
            Calculator newCalc = new Calculator(user);

            //Read values entered by user separated by a comma
            Console.Write("Enter two values separated by a comma:>");
            string tempInput = Console.ReadLine();
            ClearConsole();

            //put separated string into array of strings
            string[] input = tempInput.Split(new char[] { ',' });

            //Obtain User desired function
            string function = UserFunction();

            switch (function)
            {
                case "A":
                    Console.WriteLine("You Chose to Add");
                    Console.WriteLine("The sum is: " + newCalc.Add(double.Parse(input[0]), double.Parse(input[1])) + "\n\n");
                    break;

                case "S":
                    Console.WriteLine("You Chose to Subtract");
                    Console.WriteLine("The difference is: " + newCalc.Subtract(double.Parse(input[0]), double.Parse(input[1])) + "\n\n");
                    break;

                case "M":
                    Console.WriteLine("You Chose to Multiply");
                    Console.WriteLine("The product is: " + newCalc.Multiply(double.Parse(input[0]), double.Parse(input[1])) + "\n\n");
                    break;

                case "D":
                    Console.WriteLine("You Chose to Divide");
                    Console.WriteLine("The quotient is: " + newCalc.Divide(double.Parse(input[0]), double.Parse(input[1])) + "\n\n");
                    break;

                case "Q":
                    Console.WriteLine("Bye");
                    break;

                default:
                    Console.WriteLine("You Chose in invalid option\nTry again...\n\n");
                    Console.ReadLine();
                    break;
            }
        }

        static string UserFunction()
        {
            //User choose Add, Subtract, Multiply or Divide
            Console.WriteLine("Please Choose function using corresponding letter");
            Console.WriteLine("<A>dd, <S>ubtract, <M>ultiply, <D>ivide or <Q>uit");
            Console.Write(">");
            string function = Console.ReadLine().ToUpper();
            ClearConsole();
            return function;
        }

        static void ClearConsole()
        {
            Console.Clear();
        }
    }

    class Calculator
    {
        public Calculator(string user)
        {
            //Specify date and time of session login
            Console.Title = user + "  Logged in  " + DateTime.Now.ToString();
        }
        //Public means code is accessible to all
        //Double means the method returns a value of type double
        //is returned to the calling code
        //Two inputs, both of type double
        public double Add(double x, double y)
        {
            //Return addition result
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            //Return subtraction result
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            //Return multiplication result
            return x *y;
        }

        public double Divide(double x, double y)
        {
            //Return Division result
            return y!=0? x / y: 0;
        }
    }
}