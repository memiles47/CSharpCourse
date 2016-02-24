using System;

/*
Lecture 82: Func<> Notation for
Lamda Expressions and dynamic
variables
*/

class Program
{
    private static Func<dynamic, dynamic, int, dynamic> Add = (xin, yin, round) => Math.Round(xin + yin, round);

    private static Func<dynamic, dynamic, int, dynamic> Divid = (xin, yin, round) => Math.Round(yin != 0 ? xin / yin : 0, round);

    static void Main()
    {
        Console.WriteLine($"The sum is: {Add(4.5, 4.55, 2)}\n");
        Console.WriteLine($"The dividend is: {Divid(4.5, 6.79, 3)}");
    }
}