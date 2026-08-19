using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lab04
{
    #region 1) Design a class named BankAccount
    internal class BankAccount
    {
        private double balance;
        #region 2) Properties
        //a
        public string AccountHolder { get; set; }

        //b
        public double Balance 
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine($"Error: Invalid balance for {AccountHolder}. Balance cannot be negative.");
                }
            } 
        }
        #endregion

        #region 3) Constructors
        public BankAccount()
        {
            TotalAccount++;
            AccountHolder = "Unknown";
            Balance = 0;
        }
        public BankAccount(string accountHolder, double openingBalance) : this()
        {
            AccountHolder = accountHolder;
            Balance = openingBalance;
        }
        #endregion

        #region 4) Static Field
        public static int TotalAccount;
        #endregion

        #region 5) Static Method
        public static void PrintTotalAccount()
        {
            Console.WriteLine($"\nTotal number of accounts: {TotalAccount}");
        }
        #endregion
    }
    #endregion
}
