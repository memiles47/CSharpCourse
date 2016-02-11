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

class Cone : ThreeDShape
{
    //Height of cone
    private double coneHeight;

    //Radius of cone base
    private double coneBaseRadius;

    public Cone(double height, double baseRadius)
    {
        //Set instance variables inside constructor
        this.coneHeight = height;
        this.coneBaseRadius = baseRadius;
    }

    public override double GetVolume()
    {
        //Cone volume equals pi * r^2 * (h / 3)
        return Math.PI * Math.Pow(coneBaseRadius, 2) * (coneHeight / 3);
    }
}

class Cylinder : ThreeDShape
{
    //Height of cylinder
    private double cylinderHeight;

    //Radius of cylinder base
    private double cylinderBaseRadius;

    public Cylinder(double height, double baseRadius)
    {
        //Set instance variables inside constructor
        this.cylinderHeight = height;
        this.cylinderBaseRadius = baseRadius;
    }

    public override double GetVolume()
    {
        //Cylinder volume equals pi * r^2 * h
        return Math.PI * Math.Pow(cylinderBaseRadius, 2) * cylinderHeight;
    }
}

class Pyramid : ThreeDShape
{
    //Height of Pyramid
    private double pyramidHeight;

    //Length of pyramid base
    private double lengthPyramidBase;

    //Width of pyramid base
    private double widthPyramidBase;

    public Pyramid(double height, double length, double width)
    {
        //Set instance variables inside constructor
        this.pyramidHeight = height;
        this.lengthPyramidBase = length;
        this.widthPyramidBase = width;
    }

    public override double GetVolume()
    {
        //Pyramid volume equals l * w * (h / 3)
        return lengthPyramidBase * widthPyramidBase * (pyramidHeight / 3);
    }
}

class UseThreeDShape
{
    static void Main()
    {
        Console.WriteLine("Volume of Sphere: " + Math.Round(new Sphere(5).GetVolume(),2));
        Console.WriteLine("Volume of Cube: " + new Cube(5).GetVolume());
        Console.WriteLine("Volume of Cone: " + Math.Round(new Cone(10,2.5).GetVolume(),2));
        Console.WriteLine("Volume of Cylinder: " + Math.Round(new Cylinder(10, 2.5).GetVolume(),2));
        Console.WriteLine("Volume of Pyramid: " + Math.Round(new Pyramid(5, 5, 10).GetVolume(),2));
    }
}