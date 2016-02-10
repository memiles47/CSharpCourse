using System;

//Abstract class
abstract class ThreeDShape
{
    //Abstract Function or Method
    //Abstract because there are many ways of finding a volume
    public abstract double GetVolume();
}

class Sphere : ThreeDShape
{
    //Distance from center to point on the surface of the sphere
    private double radius;

    public Sphere(double r)
    {
        //Set instance variable inside constructor
        this.radius = r;
    }

    public override double GetVolume()
    {
        //Sphere volume equals 4/3 * pi * r^3
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}

class Cube : ThreeDShape
{
    //Length of cube side
    private double edge;

    public Cube(double edgeLength)
    {
        //Set instance variable inside constructor
        this.edge = edgeLength;
    }

    public override double GetVolume()
    {
        //Cube volume equals edge cubed
        return Math.Pow(edge, 3);
    }
}

class UseThreeDShape
{
    static void Main()
    {
        Console.WriteLine("Volume of Sphere: " + Math.Round(new Sphere(5).GetVolume(),2));
        Console.WriteLine("Volume of Cube: " + new Cube(5).GetVolume());
    }
}