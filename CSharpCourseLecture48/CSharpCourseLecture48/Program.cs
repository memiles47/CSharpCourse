using System;

enum Months { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12 };

class Truck
{
    //Instance variables of class
    private DateTime purchaseDate;
    private string bodyColor;

    public Truck(string paintColor, DateTime dateOfPurchase)
    {
        this.purchaseDate = dateOfPurchase;
        this.bodyColor = paintColor;
    }

    public DateTime PurchaseDate
    {
        get
        {
            return this.purchaseDate;
        }
    }

    public string BodyColor
    {
        set
        {
            this.bodyColor = value;
        }
    }
}

class UseTruck
{
    static void Main()
    {
        Console.Write("How many days ago did you purchase the truck?>");
        int days = int.Parse(Console.ReadLine());

        Truck tr = new Truck("Blue", DateTime.Now.Subtract(TimeSpan.FromDays(days)));

        Console.WriteLine("Repainted to: " + (tr.BodyColor = "Red"));
        Console.WriteLine("Purchase Month: " + (Months)tr.PurchaseDate.Month);
        Console.WriteLine("Purchase Year: " + tr.PurchaseDate.Year);
    }
}