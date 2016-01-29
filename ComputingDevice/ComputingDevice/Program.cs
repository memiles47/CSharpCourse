using System;


namespace ComputingDevice
{
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

        public double Divide(double x, double y)
        {
            if (y != 0)
            {
                //Return division result
                return x / y;
            }
            else
            {
                //Return 0 if divide by zero
                return 0;
            }
        }

        static void Main(string[] args)
        {
            //Obtain user name
            Console.Write("Session User:>");
            string user = Console.ReadLine();

            //Make new calculator object/class
            Calculator newCalc = new Calculator(user);

            //Read values entered by user separated by a comma
            Console.Write("Enter two values separated by a comma:>");
            string tempInput = Console.ReadLine();

            //put separated string into array of strings
            string[] input = tempInput.Split(new char[] { ',' });

            //Add input values
            Console.WriteLine("The sum is: " + newCalc.Add(double.Parse(input[0]), double.Parse(input[1])));
        }
    }
}