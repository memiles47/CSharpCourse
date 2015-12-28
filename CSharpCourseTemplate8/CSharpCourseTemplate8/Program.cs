//Usings allow us to access external features
using System;

namespace CSharpCourseTemplate8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input from user and convert to decimal format from string
            Console.WriteLine("Enter Price:");
            decimal price = decimal.Parse(Console.ReadLine());  //Get Price from User

            //Get rate to calculate increase or decrease in price
            Console.WriteLine("Enter Rate:");
            decimal rate = decimal.Parse(Console.ReadLine());   //Get Rate from user

            //Give entry instructions
            Console.WriteLine("i = Increase, d = Decrease");
            char choice = (char)Console.Read();

            if (choice== 'i')
            {
                Console.WriteLine("The new price is: {0}", (price += price * rate));
            }
            else if(choice== 'd')
            {
                Console.WriteLine("The new price is: {0}", (price -= price * rate));
            }
            else
            {
                Console.WriteLine("Your choice does not match list of choices");
            }
        }
    }
}
