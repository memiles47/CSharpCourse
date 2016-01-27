using System;

class Program
{
    static void Main()
    {
        int tempSize;   //Temporary variable for TryParse
        while (true)
        {
            //Request input values
            Console.Write("Please enter number of fees collected or \"Exit\" to quit:");
            string userInput = Console.ReadLine();
            int arraySize = int.TryParse(userInput, out tempSize) ? tempSize : 0;

            //Check if user wishes to exit the program
            if (userInput.ToLower() == "exit")
            {
                break;
            }

            //Check if user entered a non valid response (not numeric or "Exit")
            else if (arraySize == 0)
            {
                Console.Clear();
                Console.WriteLine("Enter a valid response");
                Console.Write("Press <ENTER> key to continue...");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            else
            {
                //Declare variables and array size
                decimal total;                                   //The out variable
                decimal[] arr = new decimal[arraySize];          //Declare the array

                //Fill array
                decimal tempFee;
                for (int i = 0; i < arr.Length; i++)
                {
                    bool loop = true;
                    while (loop)
                    {
                        //Get user input
                        Console.Clear();
                        Console.Write("Enter fee number {0}: ", i+1);
                        arr[i] = decimal.TryParse(Console.ReadLine(), out tempFee) ? tempFee : 0;

                        //Check if non numeric value was entered
                        if (arr[i] == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Valid fee amount");
                            Console.WriteLine("Press <ENTER> to continue...");
                            Console.ReadLine();
                            continue;
                        }
                        loop = false;
                    }
                }

                //Call array summer method/function
                ArraySummer(arr, out total);
                Console.WriteLine("The sum is: {0:c}", total);
            }
            
        }
        
    }

    //Method/function for summing the items in the array
    static void ArraySummer(decimal[] fees, out decimal total)
    {
        decimal sum = 0;        //Sum variable
        foreach (decimal fee in fees)
        {
            sum += fee;         //Create the sum of everything
        }
        total = sum;            //Return sum through the total parameter
    }
}