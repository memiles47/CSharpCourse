using System;

//Define Type (Class)
class AccountHolder
{
    //Private instance variable
    private int id;

    //For values that are shared, use static. Every account holder will have the same rate
    public static double rate = 0.05;

    //AccountHolder constructor
    public AccountHolder(int accountID)
    {
        //Sets the instance variable
        //You don't have to set the rate because it was set in the class definition
        this.id = accountID;
    }

    public int GetID()
    {
        return this.id;
    }

    static void Main()
    {
        AccountHolder[] ahs = new AccountHolder[3]
        {
            new AccountHolder(1), new AccountHolder(2), new AccountHolder(3)
        };

        foreach (AccountHolder member in ahs)
        {
            Console.WriteLine("Member ID is " + member.GetID());
        }
    }
}