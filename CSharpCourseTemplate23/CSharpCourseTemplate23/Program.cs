//Usings allow us to access external features
using System;

//Enumerations allow us to create lists of named constants
//Monday, Tuesday...

enum Days
{
    //To enumerate means to list
    //Behind the scene each name represents a number
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

class Program
{
    static void Main()
    {
        //Input from user, get day of week
        Console.Write("Enter day of week: ");
        string dayOfWeek = Console.ReadLine();

        switch (dayOfWeek)
        {
            case "Monday":

                //(int)Days.Monday means represent Monday a the underlying numerical value
                Console.WriteLine("{0} Days.",(int)Days.Monday - (int)Days.Monday);
                break;

            case "Tuesday":
                Console.WriteLine("{0} Days.", (int)Days.Tuesday - (int)Days.Monday);
                break;

            case "Wednesday":
                Console.WriteLine("{0} Days.", (int)Days.Wednesday - (int)Days.Monday);
                break;

            case "Thursday":
                Console.WriteLine("{0} Days.", (int)Days.Thursday - (int)Days.Monday);
                break;

            case "Friday":
                Console.WriteLine("{0} Days.", (int)Days.Friday - (int)Days.Monday);
                break;

            case "Saturday":
                Console.WriteLine("{0} Days.", (int)Days.Saturday - (int)Days.Monday);
                break;

            case "Sunday":
                Console.WriteLine("{0} Days.", (int)Days.Sunday - (int)Days.Monday);
                break;
        }
    }
}