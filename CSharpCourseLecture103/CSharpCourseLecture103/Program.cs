using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseLecture103
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            for (int i = data.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
