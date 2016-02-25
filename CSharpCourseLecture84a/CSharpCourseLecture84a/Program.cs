using System;
using System.Data.SqlClient;

/*
Lecture 84a: Write Code for
Connecting to Databases
*/

class Program
{
    static void Main()
    {
        string connectionString = @"Data Source=DESKTOP-KQOJ5JJ\SQLEXPRESS;Initial Catalog=Sample;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Select all data from the people table
        string command = "Select * from dbo.People";

        //We are accessing a low level process that needs to be disposed of properly
        using (SqlConnection  dbaseConnection = new SqlConnection(connectionString))
        {
            //Use try, catch because there is no guarantee the connection will succeed
            try
            {
                //Open the database connection
                dbaseConnection.Open();

                //Send the sql command to the open database connection
                SqlCommand sqlcomm = new SqlCommand(command, dbaseConnection);

                //Another low level process that needs to be disposed of properly
                using (SqlDataReader reader = sqlcomm.ExecuteReader())
                {
                    //Read each record
                    while (reader.Read())
                    {
                        //Write each record to the console
                        Console.WriteLine($"{reader[0]}, {reader[1]}, {reader[2]}");
                    }
                }
            }
            catch (Exception ex)
            {
                //Print exception message if connection failed
                Console.WriteLine(ex.Message);
            }
        }
    }
}