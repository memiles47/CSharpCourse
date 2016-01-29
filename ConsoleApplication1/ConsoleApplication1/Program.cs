using System;

namespace ResourceManipulator
{
    class WindowManipulator
    {
        public WindowManipulator() {;}

        public void ResizeWindowHeight(int newHeight)
        {
            if (0 < newHeight && newHeight <= Console.LargestWindowHeight)
            {
                Console.WindowHeight = newHeight;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            WindowManipulator WinManip = new WindowManipulator();

            int tempHeight;
            int height;
            Console.WriteLine("Max window height: {0}",Console.LargestWindowHeight);

            while (true)
            {
                Console.Write("Enter new window height: ");
                height = int.TryParse(Console.ReadLine(), out tempHeight) ? tempHeight : 0;

                WinManip.ResizeWindowHeight(height);
            }
            
        }
    }
}