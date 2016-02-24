using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lecture 81: Lamda "=>" Expressions and
Lamda statements
*/

delegate double Multiply(double x, double y);
delegate double CompareFirstTwo(double x, double y);


class Program
{
    static void Main()
    {
        Multiply mult = (x, y) => (x * y);
        Console.WriteLine($"The product of 4.5 and 3.8 is {mult(4.5,3.8)}");

        CompareFirstTwo cft = (xin, yin) =>
        {
            double x = xin;
            double y = yin;

            return x > y ? x : y;
        };

        Console.WriteLine(CompareThird(cft, 10));
    }

    private static double CompareThird(CompareFirstTwo cf, double x)
    {
        return x > cf(4, 5) ? x : cf(4, 5);
    }
}