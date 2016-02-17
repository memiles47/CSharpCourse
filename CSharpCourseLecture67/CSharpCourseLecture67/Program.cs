using System;

/*
Lecture 67: Turning Objects into Arrays
with indexes
*/

class Axis
{
    //Array is needed to us in definition of indexer
    public int[] axis = new int[10];

    public Axis()
    {
        for (int i = 0; i < axis.Length; i++)
        {
            //Fill array with values of i
            axis[i] = i;
        }
    }

    //Indexer allows us to go through
    //an array using an object
    public int this[int index]
    {
        get
        {
            return axis[index];
        }
    }
}

class Program
{
    static void Main()
    {
        //For a horizontal number line
        Axis xAxis = new Axis();

        //For a vertical number line
        Axis yAxis = new Axis();

        //For loop is set so we can count down from highest
        //to lowest
        for (int i = yAxis.axis.Length-1; i > 0; i--)
        {
            Console.WriteLine($"{yAxis[i]}\n");
        }
        
        //For loop is set so we can count up from lowest
        //to highest
        for (int i = 0; i < xAxis.axis.Length; i++)
        {
            Console.Write($"{xAxis[i]}    ");
        }
        Console.WriteLine();
    }
}