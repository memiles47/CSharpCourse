using System;                       //Console
using System.Collections.Generic;   //Lists, dictionaries and ienumerable
using System.Linq;                  //Enables queries in lists

/*
Lecture 86: Using Lambda expressions
in linq queries
*/

class Program
{
    static void Main()
    {
        //Create integer array and initialize
        double dTemp = 0;
        int[] values = new int[] { 3, 5, 2, 8, 6, 3, 4 };

        /*
        Find sum of values where each number is more than 5
        1) Scan list
        2) Compare list to find values greater than 5
        3) sum
        */

        //Collect the compare value from user
        Console.Write("Enter the compare value: ");
        double compareAgainst = double.TryParse(Console.ReadLine(), out dTemp) ? dTemp : 0;

        //Do the following only if a valid number is entered (numeric and greater than 0)
        if (compareAgainst != 0)
        {
            Console.Write($"Sum of values greater than {compareAgainst} is => {values.Where(x => x > compareAgainst).Sum()}\n\n");

            /*
            Imagine compareAgainst = 7
            Make list of values from list until value is greater than 7
            such as:
            3 < 7, true, add to list
            5 < 7, true, add to list
            2 < 7, true, add to list
            8 < 7, false, stop
            print list to console
            */

            //Create the above list as described
            IEnumerable<int> lessThanList = values.TakeWhile(x => x < compareAgainst);

            //Write list separated by commas
            Console.Write("This list is: ");
            foreach (var item in lessThanList)
            {
                Console.Write($"{item}, ");
            }
            Console.Write($"The sum of which is: {lessThanList.Sum()}\n\n");
        }
        else
        {
            Console.WriteLine("Non-numeric value or 0 was entered...\n");
        }
    }
}