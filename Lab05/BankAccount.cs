namespace Lab05
{
    //1. Convert BankAccount to an abstract class
    abstract class BankAccount
    {
        private double balance;

        // Static Field
        public static int TotalAccount;

        // Properties
        public string AccountHolder { get; set; }
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

        #region Constructors
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

        //Abstract Method
        public abstract void Withdraw(double amount);

        //Static Method
        public static void PrintTotalAccount()
        {
            Console.WriteLine($"\nTotal number of accounts: {TotalAccount}");
        }
    }
}
