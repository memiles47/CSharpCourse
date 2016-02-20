using System;
using System.IO;

/*
Lecture 72: Nullable Data Type and
Nammed Parametrs
*/

class Author
{
    //Instance variables for author
    string name;
    decimal? salary;
    bool? published;

    public Author(string fullName, decimal? sal, bool? pub)
    {
        this.name = fullName;
        this.salary = sal;
        this.published = pub;
    }

    //Save to disk with function or method
    public void WriteAuthorToDisk(string path)
    {
        using(StreamWriter writer = File.CreateText(@path))
        {
            writer.WriteLine(this.name);
            writer.WriteLine(this.salary);
            writer.WriteLine(this.published);
        }
    }
}

class Program
{
    static void Main()
    {
        Author aut = new Author(pub: null, sal: 54500M, fullName: "Bubba Jones");

        //Prompt user for path
        Console.Write("Enter Path:>");

        //Read path in
        string s = Console.ReadLine();

        //Write author to disk
        aut.WriteAuthorToDisk(s);
    }
}