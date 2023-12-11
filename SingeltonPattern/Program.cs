using System;
using SingeltonPattern;

class Program
{
    static void Main(string[] args)
    {
        var accountManager = BankAccountManager.GetSingletonInstance();
        accountManager.Deposit(1500);
        Console.WriteLine("balance after paying deposit: " + accountManager.GetBalance());

        bool success = accountManager.Withdraw(50);
        if (success)
        {
            Console.WriteLine("transaction successful. Cuurrent balance: " + accountManager.GetBalance());
        }
        else
        {
            Console.WriteLine("insufficient balance failed transaction");
        }
    }
}
