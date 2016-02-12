using System;
using System.Collections.Generic; //New namespace for getting lists. Lists allow us to collect without knowing in advance how many items

class Student
{
    //An array for storing student grades
    private int[] grades;

    //Class constructor
    public Student(int[] marks)
    {
        //Set the instance variable
        this.grades = marks;
    }

    //Method to calculate the average grade
    public double GetAverageGrade()
    {
        int sum = 0;

        foreach (int gr in this.grades)
        {
            sum += gr;
        }

        //Sum of values divided by number of values
        return sum / this.grades.Length;
    }
}

class Program
{
    static void Main()
    {
        //Prompt data entry person
        Console.WriteLine("Enter Grades:>");

        //Use list for collecting grades
        List<int> values = new List<int>();

        string s;   //Input from user
        int mark;   //Attempted conversion result

        //Spin, asking for input
        while (true)
        {
            //Input from user
            s = Console.ReadLine();

            //Attempt to convert to integer
            if (int.TryParse(s,out mark))
            {
                values.Add(mark);
            }
            else if (s.ToUpper() == "EXIT")
            {
                //Present if user wants to quit
                break;
            }
            else
            {
                //Continues the loop in case some garbage is entered
                continue;
            }
        }

        //Make Student with a list converted to array form
        Student st = new Student(values.ToArray());

        //Compute average grade for student
        Console.Clear();
        Console.WriteLine($"Average Grade is: {st.GetAverageGrade()}");
    }
}
