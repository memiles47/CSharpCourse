using System;

class program
{
    static void Main()
    {
        while (true)
        {
            //Accept input from user for number of rows in array
            Console.WriteLine("Please enter values (1-10) for Row and Column in custom array");
            Console.WriteLine("Enter \"Quit\" to end program");
            Console.Write("Rows: ");
            string rowInput = Console.ReadLine();
            if (rowInput.ToLower() == "quit")       //Check for Quit
            {
                break;
            }

            Console.Write("Columns: ");
            string colInput = Console.ReadLine();
            if (colInput.ToLower() == "quit")       //Check for Quit
            {
                break;
            }

            //Parse input in to integer]
            int rows, cols;
            int numberRows = int.TryParse(rowInput, out rows) ? rows : 0;
            int numberColumns = int.TryParse(colInput, out cols) ? cols : 0;
            
            //Check for valid entries,
            if (numberColumns == 0 || numberColumns > 10 || numberRows == 0 || numberRows > 10)
            {
                Console.WriteLine("Please enter values between 1 and 10");
                Console.Write("Press any key to continue...");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            else
            {
                //Make an array and reserve memory for same
                //This array can store 15 entries (3 * 5)
                //3 is the number of rows and 5 is the number of columns
                string[,] matrix = new string[numberRows, numberColumns];

                //Line below is used for going over rows
                for (int rowNumber = 0; rowNumber < matrix.GetLength(0); rowNumber++)
                {
                    //Line below is used for going over columns within a row
                    for (int colunmNumber = 0; colunmNumber < matrix.GetLength(1); colunmNumber++)
                    {
                        //Inside array, store address of each cell
                        matrix[rowNumber, colunmNumber] = "[" + rowNumber + ", " + colunmNumber + "]";
                        Console.Write(matrix[rowNumber, colunmNumber] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}