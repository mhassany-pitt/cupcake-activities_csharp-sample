using System;

public class BankAccount
{
    public string Owner { get; set; }
    public int Balance { get; set; }

    public BankAccount(string owner, int balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public int Deposit(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}");
        }
        return Balance;
    }

    public int Withdraw(int amount)
    {
        if (0 < amount && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
        return Balance;
    }
}

class Program
{
    static void Main()
    {
        var account = new BankAccount("Bob", 200);
        account.Deposit(100);
        account.Withdraw(50);
        Console.WriteLine($"Balance: {account.Balance}");
    }
}
