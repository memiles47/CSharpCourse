using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Truck
{
    private string manufacturer;
    private double msrp;

    public Truck(string make, double price)
    {
        this.manufacturer = make;
        this.msrp = price;
    }

    //Expose price value in Trucks
    public double Price
    {
        get
        {
            return this.msrp;
        }
    }
}

class Dealer
{
    private Truck[] trucks;
    private int truckCount;
    //private double totalMsrp = 0.0;

    public void AddTrucks(Truck[] trks)
    {
        this.trucks = trks;
        this.truckCount = trks.Length;
    }

    public int TruckCount
    {
        get
        {
            return this.truckCount;
        }
    }

    public double TotalMSRP()
    {
        //Initialize beginning value otherwise value could start with a random vale
        double totalMsrp = 0.0;

        foreach (Truck tr in this.trucks)
        {
            totalMsrp += tr.Price;
        }

        return totalMsrp;
    }
}

class Program
{
    static void Main()
    {
        Dealer dlr = new Dealer();

        dlr.AddTrucks(new Truck[] { new Truck("Ford", 20000.00), new Truck("Honda", 35900.00), new Truck("Dodge", 45000.00) });

        Console.WriteLine($"Truck Count: {dlr.TruckCount}\nTotal Value: {dlr.TotalMSRP():c}");
    }
}
