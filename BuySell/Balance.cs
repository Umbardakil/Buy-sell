using System;
using System.Collections.Generic;

public class Balance
{
    public int balance { get; set; }



    // Show current balance
    public void ShowBalance()
    {
        Console.WriteLine($"Your current balance is {balance}£");
    }

    // Decrease balance

    public int DecreaseBalance(int userQuantity, int decreNum)
    {
        balance -= decreNum;
        return balance;
    }
    // Increase balance

    public int IncreaseBalance(int userQuantity, int increNum)
    {
        balance += increNum;
        return balance;
    }
}




