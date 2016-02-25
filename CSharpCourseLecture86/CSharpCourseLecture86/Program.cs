using System;                       //Console
using System.Collections.Generic;   //Lists, dictionaries and ienumerable
using System.Linq;                  //Enables queries in lists
using System.Text;
using System.Threading.Tasks;

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

        //Find sum of values where each number is more than 5
        //1) Scan list
        //2) Compare list to find values greater than 5
        //3) sum

        //Collect the compare value from user
        Console.Write("Enter the compare value: ");
        double compareAgainst = double.TryParse(Console.ReadLine(), out dTemp) ? dTemp : 0;

        Console.Write($"Sum of values greater than {compareAgainst} is => " );

        //Do the following only if a valid number is entered (numeric and greater than 0)
        while (compareAgainst != 0)
        {
            Console.Write($"{values.Where(x => x > compareAgainst).Sum()}.\n\n");
            compareAgainst = 0;
        }

    }
}