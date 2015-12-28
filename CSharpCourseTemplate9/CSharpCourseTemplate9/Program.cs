//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for input
            Console.WriteLine("Enter String");
            string s = Console.ReadLine();      //Read input
            string c = "";                      //Empty string used to accum. parts of s

            //Strings are indexed, for example
            //The string 'hello', 'h' is a index 0, 'e' is it index 1...'o' is at index 4
            //String with length of n, means indexes start at 0 until n-1

            for (int i = 0; i < s.Length; i++)
            {
                //Look at s and grab part of it
                //part starts at index i and is one character long
                //Example 'hello'.substring(3,1) would equal 'l' (the second 'l')
                c += s.Substring(i, 1);
                Console.WriteLine(c);
            }
        }
    }
}
