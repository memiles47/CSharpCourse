//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManipulator
{
    public class WindowManipulator
    {
        public WindowManipulator() {;}

        public void ResizeWindowHeight(int newHeight)
        {
            if (0 < newHeight)
            {
                Console.WindowHeight = newHeight;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            WindowManipulator WinManip = new WindowManipulator();

            int height;
            int tempHeight;
            //Console.WriteLine("Max height is: {0}",Console.LargestWindowHeight);

            while (true)
            {
                Console.Write("Enter Height: ");
                height = int.TryParse(Console.ReadLine(), out tempHeight) ? tempHeight : 0;

                WinManip.ResizeWindowHeight(height);
            }
        }
    }
}
