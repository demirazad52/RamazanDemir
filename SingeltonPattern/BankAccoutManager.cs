using System;
namespace SingeltonPattern
{
    public class BankAccountManager
    {
       
        
            private static BankAccountManager instance;

            private double balance;





            private BankAccountManager() { }

            public static BankAccountManager GetSingletonInstance()
            {
                if (instance == null
                {
                    instance = new BankAccountManager();
                }
                return instance;
            }

            public void Deposit(double amount)
            {
                balance += amount;
            }

            public bool Withdraw(double amount)
            {











 if (balance >= amount)
                {
                    balance -= amount;
                    return true;
                }
                return false;
            }

          public double GetBalance()
            {
                return balance;
            }
        }


    }



