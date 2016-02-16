using System;

class Vector
{
    //Instance Variables
    private double x;
    private double y;
    private double z;

    public Vector(double xComp, double yComp, double zComp)
    {
        this.x = xComp;
        this.y = yComp;
        this.z = zComp;
    }

    public static Vector operator + (Vector vect1, Vector vect2)
    {
        return new Vector(vect1.x + vect2.x, vect1.y + vect2.y, vect1.z + vect2.z);
    }

    public static Vector operator - (Vector vect1, Vector vect2)
    {
        return new Vector(vect1.x - vect2.x, vect1.y - vect2.y, vect1.z - vect2.z);
    }

    public override string ToString()
    {
        //Create an overridden ToString method using the $ constructor for writing strings
        return $"<{x},{y},{z}>";
    }
}

class Program
{
    static void Main()
    {
        //Create two new vectors
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(4, 5, 6);

        //Add the two vectors using the overloaded operator +
        Vector sum = v1 + v2;

        //Subtract the two vectors using the overloaded operator -
        Vector difference = v1 - v2;

        //Print to the console the vector sum using the $ constructor
        Console.WriteLine($"Sum is: {sum.ToString()}");

        //Assignment for the overridden - operator
        Console.WriteLine($"Difference is: {difference.ToString()}");
    }
}