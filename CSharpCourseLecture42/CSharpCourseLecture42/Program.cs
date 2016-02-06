using System;

//Dynamic keyword flexible and very powerful

class DynamicCalc
{
    public dynamic Add(dynamic x, dynamic y)
    {
        return x + y;
    }

    public dynamic Divide(dynamic x, dynamic y)
    {
        //Ternary operator
        return y != 0 ? x / y : "ERROR: Divide by zero\n";
    }
}

class Program
{
    static void Main()
    {
        DynamicCalc myCalc = new DynamicCalc();

        Console.WriteLine("Sum is: " + myCalc.Add(4,5));
        Console.WriteLine("Quotient is: " + myCalc.Divide(4,0));
    }
}