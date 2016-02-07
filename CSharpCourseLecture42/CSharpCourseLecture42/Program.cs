using System;

//Dynamic keyword flexible and very powerful

class DynamicCalc
{
    public dynamic Add(dynamic x, dynamic y)
    {
        return x + y;
    }

    public dynamic Subtract(dynamic x, dynamic y)
    {
        return x - y;
    }

    public dynamic Multiply(dynamic x, dynamic y)
    {
        return x * y;
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

        Console.Write("Please enter Value 1:> ");
        double valueOne = double.Parse(Console.ReadLine());
        Console.Write("Please enter Value 2:> ");
        double valueTwo = double.Parse(Console.ReadLine());

        string function = SelectFunction();

        switch (function)
        {
            case "A":
                Console.Clear();
                Console.Write("You have elected to Add and " + "\nthe sum is: ");
                Console.WriteLine(myCalc.Add(valueOne, valueTwo));
                break;

            case "S":
                Console.Clear();
                Console.Write("You have elected to Subtract and " + "\nthe difference is: ");
                Console.WriteLine(myCalc.Subtract(valueOne, valueTwo));
                break;

            case "M":
                Console.Clear();
                Console.Write("You have elected to Multiply and " + "\nthe product is: ");
                Console.WriteLine(myCalc.Multiply(valueOne, valueTwo));
                break;

            case "D":
                Console.Clear();
                Console.Write("You have elected to Divide and " + "\nthe quotient is: ");
                Console.WriteLine(myCalc.Divide(valueOne, valueTwo));
                break;

            case "Q":
                Console.Clear();
                Console.WriteLine("You have elected to Quit - Bye!");
                break;
        }
    }

    static string SelectFunction()
    {
        Console.WriteLine("Please select a function or quit by selecting a letter");
        Console.Write("<A>dd, <S>ubtract, <M>ultiply, <D>ivide or <Q>uit:>");
        return Console.ReadLine().ToUpper();
    }
}