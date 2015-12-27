//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt for user input
            Console.WriteLine("Enter String");
            string s = Console.ReadLine();

            //If conditional statement (== is for comparison, = is for assignment
            if (s == "")
            {
                Console.WriteLine("Please enter a string");
            }
            else
            {
                Console.WriteLine("Your string is {0} characters long.", s.Length);
                Console.WriteLine("Could have entered {0} characters more.",
                    Console.WindowWidth - s.Length);
            }
        }
    }
}
