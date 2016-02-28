using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

/*
Lecture 86: Use LINQ with XML
*/

namespace CSharpCourseLecture86a
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement userFile = XElement.Load(@"F:\Udemy\VisualStudio\CSharpCourse\CSharpCourseLecture86a\CSharpCourseLecture86a\users.xml");

            IEnumerable<string> deskTopUser = 

                //An impeded query, look inside the document and get each user
                from eachuser in userFile.Descendants("user")

                //Get full name of each user
                select (string)eachuser.Attribute("fullname");

            foreach (string name in deskTopUser)
            {
                Console.WriteLine($"The name is {name}");
            }
        }
    }
}
