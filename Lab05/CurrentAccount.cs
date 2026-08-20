using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab05
{
    internal class CurrentAccount : BankAccount
    {
        public CurrentAccount(string name, double balance) : base(name, balance) { }

        //Override Withdraw method
        public override void Withdraw(double amount)
        {
            double totalDeduction = amount + 5;

            if (Balance >= totalDeduction)
            {
                Balance -= totalDeduction;
                Console.WriteLine($"Successful withdrawal. New balance = {Balance}");
            }
            else
            {
                Console.WriteLine("Error: Withdrawal failed");
            }
        }
    }
}
