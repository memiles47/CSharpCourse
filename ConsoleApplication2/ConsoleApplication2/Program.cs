using System;

namespace Entity
{
    //Make our own type
    class Employee
    {
        //Use instance variables
        //private means secure to the class, type is Date and Time
        //The variable name is hireDate in camel case
        private DateTime hireDate;

        public Employee(DateTime dt)
        {
            //Sets the instance variable for the current object
            this.hireDate = dt;
        }

        public DateTime GetHireDate()
        {
            //Get us the hire date.
            //Secure because it only gets the hire date with no ability to change it
            return this.hireDate;
        }

        static void Main()
        {
            Employee[] employees = new Employee[2];

            //Input by data entry person
            DateTime hireDate;

            for (int i = 0; i < employees.Length; i++)
            {
                //Next two line gets hire date
                Console.Write("Enter Employee # " + (i + 1) + " Hire Date: ");
                hireDate = DateTime.Parse(Console.ReadLine());
                Console.Clear();

                //Makes new employee with hire date
                employees[i] = new Employee(hireDate);
            }

            foreach (Employee emp in employees)
            {
                //Displays the hire date for each employee in our array
                Console.WriteLine("Hired on: " + emp.GetHireDate());
            }
        }
    }
}