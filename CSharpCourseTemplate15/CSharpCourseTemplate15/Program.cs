using System;
class Program
{
    //define function to print message

    //static mean you can call the function directly
    //void means nothing is returned to calling code
    //name of function is PrintMessage
    static void PrintMessage()
    {
        //define body of function
        Console.WriteLine("Message from PrintMessage()...");
    }

    static void Main()
    {
        //Get decision form user
        string userInput = Console.ReadLine();

        if (userInput == "Run")
        {
            //Call function
            PrintMessage();
        }
        else
        {
            Console.WriteLine("No message printed");
        }
    }
}