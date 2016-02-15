//This time and from now on I will be leaving all the using statements in
//Name space for lists is in System.Collections.Generic
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ComputingDevice
{
    //Create instance variables for our class
    private string name;

    //Create a constructor for our class
    public ComputingDevice(string nam)
    {
        //Set an instance variable
        this.name = nam;
    }

    //Create virtual function
    public virtual void AccetpInput()
    {
        Console.WriteLine("Configuring common tasks...");
    }
}

//Create new class(s) inheriting from ComputingDevice class
class Laptop : ComputingDevice
{
    public Laptop(string name) : base(name) { }
    public override void AccetpInput()
    {
        base.AccetpInput();
        Console.WriteLine("Configuring LapTop...");
    }
}

class Tablet : ComputingDevice
{
    public Tablet(string name) : base(name) { }
    public override void AccetpInput()
    {
        base.AccetpInput();
        Console.WriteLine("Configuring Tablet...");
    }
}

class Program
{
    static void Main()
    {
        List<ComputingDevice> myList = new List<ComputingDevice>();

        //Storing different kinds of objects in a base typed list
        myList.Add(new Tablet("My Surface Pro 3"));
        myList.Add(new Laptop("My Surface Book"));

        //The fact that method calls are correctly resolved at runtime
        foreach (ComputingDevice cd in myList)
        {
            cd.AccetpInput();
        }
    }
}