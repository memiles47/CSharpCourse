using System;

/*
Lecture 77: Create and Use a Generic
Class
*/

//Generic classes can operate
//on different data types with equal ease

class GenericSwapper<T>
{
    //Declare instance variables
    public T x;
    public T y;
    
    //Create the class contstructor
    public GenericSwapper(T val1, T val2)
    {
        //Set instance values
        this.x = val1;
        this.y = val2;
    }

    //Switch method
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