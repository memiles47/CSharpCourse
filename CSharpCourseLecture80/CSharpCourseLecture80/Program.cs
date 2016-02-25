using System;                       //Console
using System.IO;                    //Writing Files
using System.Diagnostics;           //Open a Program
using System.Collections.Generic;   //Dictionary

/*
Lecture 80: Using Generic Dictionaries
and a Project
*/

namespace CSharpCourseLecture80
{
    class Program
    {
        static void Main(string[] args)
        {
            //A dictionary is a collection of key, value pairs
            Dictionary<string, string> dict = new Dictionary<string, string>();

            //Read input from user for Key, value
            string s = Console.ReadLine();

            while (s.ToLower() != "exit")
            {
                //split string into key and value using string array
                string[] keyVal = s.Split(new char[] { ',' });
                dict.Add(keyVal[0], keyVal[1]);

                //Read new key, value
                s = Console.ReadLine();
            }

            Program.SaveDictionary(dict);
            Process.Start(@"notepad.exe", @"c:\users\michael\data\dict.txt");
        }

        private static void SaveDictionary(Dictionary<string, string> entries)
        {
            using (StreamWriter writer = File.CreateText(@"c:\users\michael\data\dict.txt"))
            {
                foreach(var pair in entries)
                {
                    writer.WriteLine($"{pair.Key}, {pair.Value}");
                }
            }
        }
    }
}
