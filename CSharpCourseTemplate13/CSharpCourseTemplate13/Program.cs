//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int maxChars;

                Console.WriteLine("Enter Maximum String Width.");
                Console.WriteLine("Enter 'Exit' to quit");
                Console.Write(">: ");
                string userInput = Console.ReadLine();

                if(int.TryParse(userInput, out maxChars))
                {
                    for (int x = maxChars; x > 0; x--)
                    {
                        for (int y = 0; y < x; y++)
                        {
                            Console.Write("*");
                        }
                        Console.CursorLeft = maxChars + 2;
                        Console.Write("Spaces Left: {0}", maxChars - x);
                        Console.WriteLine();
                    }
                }
                else if (userInput.ToLower() == "exit")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
