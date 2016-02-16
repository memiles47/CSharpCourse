using System;

namespace CSharpCourseLecture53
{
    class Truck
    {
        private string make;
        public Truck(string manuf)
        {
            this.make = manuf;
        }
    }

    class Dealer
    {
        private Truck[] trucks;
        private int truckCount;

        public void AddTrucks(Truck[] trks)
        {
            this.trucks = trks;
            this.truckCount += trks.Length;
        }

        public int TruckCount
        {
            get
            {
                return this.truckCount;
            }
        }   
    }

    class Program
    {
        static void Main()
        {
            Dealer dlr = new Dealer();

            dlr.AddTrucks(new Truck[] {new Truck("Ford"), new Truck("Honda"), new Truck("Dodge") });

            Console.WriteLine($"Truck Count: {dlr.TruckCount}");
        }
    }
}
