//Usings allow us to access external features
using System;

class Program
{
    static void Main()
    {
        int[] arr1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
        int[] arr2 = new int[3] { 2, 5, 8 };
        int[] arr3 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        //find and print the sum of the arrays to the console
        Console.WriteLine("The sum is: {0}",SumArrays(arr1, arr2, arr3));
    }

    //int here means this method returns a value of type int
    //params indicates that the number of arguments can change
    static int SumArrays(params object[] x)
    {
        int sum = 0;

        //for each allow us to grab each array in x
        foreach (int[] arr in x)    //In this context, x is and array of arrays
        {
            //This for each sums the values is that array
            foreach (int i in arr)
            {
                sum += i;
            }
        }
        return sum;
    }
}