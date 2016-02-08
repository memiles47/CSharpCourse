using System;

class Swapper
{
    public void Swap(ref double x, ref double y)
    {
        // Copy x into temp, then copy y into x, then temp (x) into y completing the swap
        double temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        Swapper switcher = new Swapper();

        var first = 10.5; var second = 10.6;

        switcher.Swap(ref first, ref second);
        Console.WriteLine("First = " + first + "\nSecond = " + second);
    }
}