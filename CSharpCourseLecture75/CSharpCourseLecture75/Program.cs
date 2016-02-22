using System;
using System.IO;

/*
Display all the files and
folders in a directory
*/

class Program
{
    static void Main()
    {
        //Store forlders and files inside of an array of strings
        string[] files = Directory.GetFiles(@"c:\users\Michael\Data");
        string[] folders = Directory.GetDirectories(@"C:\users");

        foreach (string f in files)
        {
            Console.WriteLine($"File {Path.GetFileName(f)} is located in {Path.GetDirectoryName(f)}");
        }

        foreach (string f in folders)
        {
            Console.WriteLine($"The directory is {f.ToString()}");
        }
    }
}