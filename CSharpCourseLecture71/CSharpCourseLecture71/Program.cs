using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lecture 71: Conditional Functions
*/

class Trace
{
    #region[Conditional Region]
    [Conditional("DEBUG")]
    public static void Message(string traceMessage)
    {
        Console.WriteLine("[TRACE] - " + traceMessage);
    }
    #endregion
}

class Program
{
    static void Main(string[] args)
    {
        Trace.Message("Main Is Starting");

        if (args.Length == 0)
        {
            Console.WriteLine("No arguments have been passed into program");
        }
        else
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}] is [{args[i]}]");
            }
        }

        Trace.Message("Main Is Ending");
    }
}
