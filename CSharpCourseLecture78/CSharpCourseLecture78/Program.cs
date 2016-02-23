using System;
using System.Collections.Generic;

/*
Lecture 78: List<T> With Predefined
Types and ForEach
*/

class Program
{
    static void Case(string p)
    {
        Console.WriteLine(p.ToLower());
    }

    static void Main()
    {
        //Creates list of strings with no defined size
        List<string> myWords = new List<string>();

        string s = Console.ReadLine();
        while(s.ToLower() != "exit")
        {
            myWords.Add(s);
            s = Console.ReadLine();
        }

        myWords.ForEach(Case);
        myWords.Reverse();
        myWords.ForEach(Case);
    }
}