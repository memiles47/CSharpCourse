using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/*
Lecture 100: Serialization Example
*/

[Serializable()]

class Person
{
    public string fName;

    public Person(string first)
    {
        this.fName = first;
    }
}

class Program
{
    static void Main()
    {
        Person per = new Person("James");

        //Takes care of the serialization process
        BinaryFormatter binFormatter = new BinaryFormatter();

        //
        using (Stream writer = File.Create(@"c:\users\Michael\data\person.bin"))
        {
            binFormatter.Serialize(writer, per);
        }

        using (Stream reader = File.OpenRead(@"c:\users\Michael\data\person.bin"))
        {
            Person per2 = (Person)binFormatter.Deserialize(reader);
            Console.WriteLine($"First name is {per2.fName}");
        }
    }
}