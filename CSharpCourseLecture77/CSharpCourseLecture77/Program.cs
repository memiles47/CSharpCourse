using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lecture 77: Create and Use a Generic
Class
*/

//Generic classes can operate
//on different data types with equal ease

class GenericSwapper<T>
{
    public T x;
    public T y;

    public GenericSwapper(T val1, T val2)
    {
        //Set instance values
        this.x = val1;
        this.y = val2;
    }

    public void Switch()
    {
        T temp = this.x;
        this.x = this.y;
        this.y = temp;
    }

}

class SwapUser
{
    static void Main()
    {
        //Create new GenericSWapper object using string as the argument type
        GenericSwapper<String> genSwap1 = new GenericSwapper<string>("Hello", "World");

        //Create new GenericSwa;;er object uinsg double as the argument type
        GenericSwapper<double> genSwap2 = new GenericSwapper<double>(1.2, 2.3);

        genSwap1.Switch();
        Console.WriteLine($"The Value of x is {genSwap1.x}\nThe value of y is {genSwap1.y}");

        //Seperate the two with a blank line
        Console.WriteLine();

        genSwap2.Switch();
        Console.WriteLine($"The Value of x is {genSwap2.x}\nThe value of y is {genSwap2.y}");
    }
}