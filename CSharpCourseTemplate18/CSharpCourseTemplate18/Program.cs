//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate18
{
    class Program
    {
        //Simple types like integers are passed by value
        //in these types, original stat in original variable is not changed
        //static means you can call this code by name
        //void mean no value is returned to the calling code
        //name of function 'Increment'
        //ref decimal old passed by reference, type of data is decimal
        //old is the name of the parameter. Parameters are place holders thru which
        //we pass values into functions
        static void Increment(ref decimal old)
        {
            old = old * 1.1m;
        }

        static void Main(string[] args)
        {
            decimal[] prices = new decimal[3] { 45m, 35m, 67m };

            //Call function for each value in array
            Increment(ref prices[0]);
            Increment(ref prices[1]);
            Increment(ref prices[2]);

            //Display prices array using foreach loop
            foreach (decimal d in prices)
            {
                Console.WriteLine("{0:c}",d);
            }
        }
    }
}
