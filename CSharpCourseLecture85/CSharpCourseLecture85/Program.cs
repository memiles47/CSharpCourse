using System;                     //Console
using System.Collections.Generic; //Generic Lists and dictionaries
using System.Linq;                //Allow searches

/*
Lecture 85: Search through generic
lists with linq
*/

class Program
{
    static void Main()
    {
        List<double> myValues = new List<double>();
        double sTemp = 0;

        //Ask for values to add to myValues
        Console.WriteLine("Enter values: ");
        string s = Console.ReadLine();

        //Continue to read and add values to myValues until "exit" is entered
        while (s.ToLower() != "exit")
        {
            //Add values to myValues list usint TryParse and Ternary
            myValues.Add(double.TryParse(s, out sTemp)? sTemp :0);

            //Read new value until "exit" is entered
            s = Console.ReadLine();
        }

        //Search the myValues list for the given criteria
        var values = from num in myValues where (num >= 0 && num <= 10) select num;

        //Clear screan and begin to write those values to the console
        Console.Clear();
        Console.Write("Matching values: ");

        //Iterate through the list
        foreach (var d in values)
        {
            //Write the values selected in line separated by a comma
            Console.Write($"{d}, ");
        }

        //End the list of values and place cursor down two lines
        Console.Write("List complete...\n\n");
    }
}