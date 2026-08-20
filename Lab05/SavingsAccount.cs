namespace Lab05
{
    internal class SavingsAccount : BankAccount
    {
        //b. Override withdraw method
        public SavingsAccount(string name, double balance) : base(name, balance) { }
        public override void Withdraw(double amount)
        {
            if(Balance - amount >= 1000)
            {
                Balance -= amount;
                Console.WriteLine($"Success withdrew. New balance = {Balance}");
            }
            else
            {
                Console.WriteLine($"Error: Withdrawal rejected. Savings accounts must maintain a 1,000 EGP minimum balance.");
            }
        }
    }
}
