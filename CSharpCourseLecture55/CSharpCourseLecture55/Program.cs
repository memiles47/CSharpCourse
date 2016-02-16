using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//delegate is a type like 'class' is a type
//function as a function wrapper
delegate string CaseChanger(string str);

class StringUtils
{
    public static void Case(string[] arr, CaseChanger caser)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = caser(arr[i]);
        }
    }
}

class Program
{
    public static string Upper(string s)
    {
        return s.ToUpper();
    }

    public static string Lower(string s)
    {
        return s.ToLower();
    }

    static void Main()
    {
        string[] s1 = new string[] {"Hello, ", "World", "This is a great day!"};
        StringUtils.Case(s1, Upper);
        StringUtils.Case(s1, Lower);
    }
}