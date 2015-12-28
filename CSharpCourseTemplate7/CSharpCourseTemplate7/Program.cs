//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate7
{
    class Program
    {
        static void Main(string[] args)
        {
            //How many strings
            Console.WriteLine("How many turns?");
            int howMany = int.Parse(Console.ReadLine());

            //Loop counter
            int loopCounter = 1;

            //Create an empty string
            string s = "";

            while (loopCounter <= howMany)
            {
                //Store strings
                s += Console.ReadLine();

                //Increase loopCounter by 1
                loopCounter += 1;
            }
            //Print information about strings entered
            Console.WriteLine("You have entered: {0} characters.", s.Length);
            Console.WriteLine("Average length of string is: {0} characters.", (double)s.Length / howMany);
        }
    }
}
