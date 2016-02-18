using System;
using System.IO;

/*
Lecture 68: Writing and Reading
Files. Very simple exmple
*/

class Program
{
    static void Main()
    {
        //Create a stream writer objects (for writing text to a file)
        //this will create a new file and replace the old file if
        //one exists.
        StreamWriter sw = new StreamWriter(@"E:\misc\SampleFile.txt");

        //Read text from the console and them write same text to the file
        sw.Write(Console.ReadLine());

        //Close the stream writer object
        sw.Close();

        //Create new stream reader object to read an existing file
        StreamReader sr = new StreamReader(@"E:\misc\SampleFile.txt");

        //Write the read file to the console
        Console.WriteLine(sr.ReadLine());

        //Close the stream reader object
        sr.Close();
     }
}