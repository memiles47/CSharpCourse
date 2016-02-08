using System;

namespace Sample
{
    //Out type
    class Person
    {
        //Static field
        private static int personCounter = 0;

        //Object level instance variable. Varies from person to person
        private string initials = null;

        public Person(string inits)
        {
            this.initials = inits;
            personCounter++;
        }

        public static int GetPersonCount()
        {
            //Return current count of persons
            return Person.personCounter;
        }

        public string GetInitials()
        {
            return this.initials;
        }
    }

    class UsePerson
    {
        static void Main()
        {
            Console.WriteLine("Enter initials:");
            Person[] people = new Person[10];

            for (int i = 0;Person.GetPersonCount() < 10; i++)
            {
                people[i] = new Person(Console.ReadLine());
            }
        }
    }
}