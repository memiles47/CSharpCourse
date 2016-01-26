//Several can be used to represent the same locations in memory
using System;

class program
{
    static void Main()
    {
        //Create array
        double[] arr = new double[10];

        //Fill array with random numbers
        for (int i = 0; i < arr.Length; i++)
        {
            //This generates random values between 0 and 1
            arr[i] = new Random(DateTime.Now.Millisecond).NextDouble();

            //Round values stored in the array
            arr[i] = Math.Round(arr[i], 3);

            //Display values stored in the array
            Console.WriteLine("The value is: " + arr[i]);
        }
        Console.WriteLine("-------------------------------------------------");

        //Assign arr to arr2
        //Two different names point to the same memory location
        double[] arr2 = arr;

        //Reverse array arr2
        Array.Reverse(arr2);

        //Display reversed array
        for (int i = 0; i < arr2.Length; i++)
        {
            //Display values stored in array location
            Console.WriteLine("The value is: " + arr[i]);
        }
    }
}