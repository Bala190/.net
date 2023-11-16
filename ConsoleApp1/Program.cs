using System;

public class BankAccount
{
 
    private decimal balance;

    
    public void Deposit(decimal amount)
    {
        
        balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
    }

    
    public void Withdraw(decimal amount)
    {
        
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    
    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
       
        BankAccount myAccount = new BankAccount();

        
        myAccount.Deposit(1000);
        myAccount.Withdraw(500);

      
        decimal currentBalance = myAccount.GetBalance();
        Console.WriteLine($"Current balance: {currentBalance:C}");
    }
}
