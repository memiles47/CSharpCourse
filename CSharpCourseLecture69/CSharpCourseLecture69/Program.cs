using System;
using System.IO;

/*
Lecture 69: Controlling low level
access with Using Statements
*/

/*
Using statement to access low level resources
replacement for try/catch/finally
make a resource, use it, and dispose of resource
*/

class Program
{
    static void Main()
    {
        using (StreamWriter writer = File.CreateText(@"E:\misc\log.txt"))
        {
            string s = Console.ReadLine();
            while(s.ToUpper() != "EXIT")
            {
                writer.Write(s + "\n");
                s = Console.ReadLine();
            }
            Console.Clear();
        }

        using(StreamReader reader = File.OpenText(@"E:\misc\log.txt"))
        {
            string lineToPrint;
            while ((lineToPrint = reader.ReadLine()) != null)
            {
                Console.WriteLine(lineToPrint);
            }
            Console.WriteLine();
        }
    }
}