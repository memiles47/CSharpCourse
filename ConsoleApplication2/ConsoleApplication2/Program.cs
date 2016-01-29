using System;

namespace Entity
{
    //Make our own type
    class Employee
    {
        //Use instance variables
        //private means secure to the class, type is Date and Time
        private DateTime hireDate;

        public Employee(DateTime dt)
        {
            //Sets the instance variable for the current object
            this.hireDate = dt;
        }

    }
}