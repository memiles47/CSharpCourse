using System;

namespace Entity
{
    class Program
    {
        //Entry into Main program
        static void Main()
        {
            Employee[] employees = new Employee[2];

            //Input by data entry person
            string firstName;
            string lastName;
            long ssn;
            DateTime hireDate;

            for (int i = 0; i < employees.Length; i++)
            {
                //Next two line gets the First Name
                Console.Write("Enter Employee # " + (i + 1) + " First Name: ");
                firstName = Console.ReadLine().ToUpper();

                //Next two line gets the Last Name
                Console.Write("Enter Employee # " + (i + 1) + " Last Name: ");
                lastName = Console.ReadLine().ToUpper();

                //Next two line gets the Social Security Number
                Console.Write("Enter Employee # " + (i + 1) + " Social Security Number (no dashes): ");
                ssn = long.Parse(Console.ReadLine());

                //Next two line gets the Hire Date
                Console.Write("Enter Employee # " + (i + 1) + " Hire Date: ");
                hireDate = DateTime.Parse(Console.ReadLine());
                Console.Clear();

                //Makes new employee with hire date
                employees[i] = new Employee(firstName, lastName, ssn, hireDate);
            }

            foreach (Employee emp in employees)
            {
                //Displays the hire date for each employee in our array
                Console.WriteLine("Name: " + emp.GetFirstName() + " " + emp.GetLastName());
                Console.WriteLine("SSN: " + emp.GetSSN().ToString());
                Console.WriteLine("Hired on: " + emp.GetHireDate());
                Console.WriteLine("--------------------------------------------\n");
                //Console.WriteLine();
            }
        }
    }

    //Make our own type
    class Employee
    {
        //Use instance variables for Employee data
        //private means secure to the class, type is Date and Time
        //The variable name is hireDate in camel case
        private DateTime hireDate;
        private string firstName;
        private string lastName;
        private long ssn;

        public Employee(string first, string last, long social, DateTime dt)
        {
            //Sets the instance variable for the current object
            this.hireDate = dt;
            this.firstName = first;
            this.lastName = last;
            this.ssn = social;
        }

        public DateTime GetHireDate()
        {
            //Get us the hire date.
            //Secure because it only gets the hire date with no ability to change it
            return this.hireDate;
        }

        public string GetFirstName()
        {
            //Get us the first name
            return this.firstName;
        }

        public string GetLastName()
        {
            //Get us the last name
            return this.lastName;
        }

        public long GetSSN()
        {
            //Get us the first name
            return this.ssn;
        }
    }
}