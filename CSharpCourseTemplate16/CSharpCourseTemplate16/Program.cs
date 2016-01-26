//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array
            decimal[] prices = new decimal[2];

            //Length n means that the entries can be stored at 0 to n -1
            prices[0] = 36m;
            prices[1] = 23m;

            //Declaring, new reserves memory, {4,5} fills the memory
            int[] items = new int[2] { 4, 5 };

            //Find total price (36m * 4 + 23m * 5)
            decimal totalPrice = prices[0] * items[0] + prices[1] * prices[1];

            //Write to console
            Console.WriteLine("Total price is: {0:c}",totalPrice);

            int itemsTotal = items[0] + items[1];
            Console.WriteLine("Fraction that items of the first kind are of all the items:");
            Console.WriteLine("{0:p2}",items[0]/((double)itemsTotal));
        }
    }
}
