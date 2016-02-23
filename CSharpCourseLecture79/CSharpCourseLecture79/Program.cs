using System;
using System.Collections.Generic;
using System.IO;

/*
Lecture 79: Build a Custom Type
Database With Generics
*/

class Vehicle
{
    private string color;
    private string manufacturer;
    private int numberOfCylinders;
    private string vehicleType;


    public Vehicle(string col, string manuf, int cyliners, string type)
    {
        this.color = col;
        this.manufacturer = manuf;
        this.numberOfCylinders = cyliners;
        this.vehicleType = type;
    }

    public static void SaveVehicleToDisk(Vehicle v)
    {
        //Base Path of the file to save usually get from user in a form
        string basePath = @"c:\users\michael\data\";

        if (File.Exists(basePath + "veh.txt"))
        {
            using (StreamWriter writer = File.AppendText(basePath + "veh.txt"))
            {
                writer.WriteLine(v.color);
                writer.WriteLine(v.manufacturer);
                writer.WriteLine(v.numberOfCylinders);
                writer.WriteLine(v.vehicleType);
            }
        }
        else
        {
            using(StreamWriter writer = File.CreateText(basePath + "veh.txt"))
            {
                writer.WriteLine(v.color);
                writer.WriteLine(v.manufacturer);
                writer.WriteLine(v.numberOfCylinders);
                writer.WriteLine(v.vehicleType);
            }
        }
    }

    static void Main()
    {
        int tempCyl = 0;
        List<Vehicle> vehs = new List<Vehicle>();

        Console.Write("Enter color or \"Exit\" quit:>");
        string col = Console.ReadLine();

        Console.Write("Enter Manufacturer:>");
        string manuf = Console.ReadLine();

        Console.Write("Enter Number of Cylinders:>");
        int cylinders = int.TryParse(Console.ReadLine(), out tempCyl) ? tempCyl : 0;

        Console.Write("Enter Type of vehicle:>");
        string type = Console.ReadLine();

        while (col.ToLower() != "exit")
        {
            vehs.Add(new Vehicle(col, manuf, cylinders, type));

            Console.Clear();
            Console.Write("Enter color or \"Exit\" quit:>");
            col = Console.ReadLine();

            Console.Write("Enter Manufacturer:>");
            manuf = Console.ReadLine();

            Console.Write("Enter Number of Cylinders:>");
            cylinders = int.TryParse(Console.ReadLine(), out tempCyl) ? tempCyl : 0;

            Console.Write("Enter Type of vehicle:>");
            type = Console.ReadLine();
        }
        vehs.ForEach(SaveVehicleToDisk);
    }
}