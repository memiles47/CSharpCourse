//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run in continuous loop until exited by user input
            while (true)
            {
                //Output to console for user input at cursor position 0,0
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Type \"Exit\" to quit or \"Go\" to continue");

                //Get Input
                string choice = Console.ReadLine();

                //Look at user input and react
                if (choice.ToLower() == "exit")
                {
                    break;
                }
                else if (choice.ToLower() == "go")
                {
                    Console.WriteLine("Enter \"X\" coordinate");

                    //Get input and make sure input is numerical
                    //Make sure it is not outside the window 'X' size
                    int xTemp;
                    int xCoord = int.TryParse(Console.ReadLine(), out xTemp) ? xTemp : 0;
                    int xCoordFinal = (0 <= xCoord && xCoord < Console.WindowWidth) ? xCoord : 0;

                    Console.WriteLine("Enter \"Y\" coordinate");

                    //Get input and make sure input is numerical
                    //Make sure it is not outside the window 'Y' size
                    int yTemp;
                    int yCoord = int.TryParse(Console.ReadLine(), out yTemp) ? yTemp : 0;
                    int yCoordFinal = (0 <= yCoord && yCoord < Console.WindowHeight) ? yCoord : 0;

                    //Clear console window, position cursor at user coordinates and type 'X'
                    Console.Clear();
                    Console.SetCursorPosition(xCoordFinal, yCoordFinal);
                    Console.WriteLine("X");
                }
            }
        }
    }
}
