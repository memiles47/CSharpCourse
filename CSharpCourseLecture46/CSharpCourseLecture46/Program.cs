using System;

//Make namespace for grouping related items
namespace Vehicles
{
    //Base class
    class Vehicle
    {
        //Constructor for the class Vehicle
        public Vehicle()
        {
            Console.Write("I can take you places ");
        }
    }

    class RaceCar : Vehicle
    {
        //Constructor for the class RaceCar
        public RaceCar()
        {
            Console.WriteLine("very fast!");
        }
    }

    class MiniVan : Vehicle
    {
        public MiniVan()
        {
            Console.WriteLine("with 10 kids inside!");
        }
    }

    class UseVehicles
    {
        static void Main()
        {
            RaceCar rc = new RaceCar();
            MiniVan mv = new MiniVan();
        }
    }
}