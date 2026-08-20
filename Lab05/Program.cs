namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testing Part 1 - Student
            Console.WriteLine("======= Part 1 : Student =======\n");

            //a. Create an array of Person named people
            //b. Add different types of objects to it
            Person[] people = new Person[]
            {
                new Student(1, "Nour", 3.9),
                new Doctor(2, "Tamer", "Computer Science"),
                new Employee(3, "Mahmoud", "AI Engineer")
            };

            //c. Loop through the array 
            Console.WriteLine("== Persons Info ==");

            foreach (Person p in people)
            {
                p.Print();
            }

            //d. 
            Console.WriteLine("\n== Testing Method Hiding (new keyword) ==");
            Student gs1 = new GraduatedStudent(4, "Eman", 3.8);
            GraduatedStudent gs2 = new GraduatedStudent(5, "Diab", 3.6);

            //call Study method and notice the difference
            Console.Write("\nStudent reference => ");
            gs1.Study();

            Console.Write("\nGraduated reference => ");
            gs2.Study();
            #endregion

            #region Testing Part 2 - BankAccount
            Console.WriteLine("\n======= Part 2 : Bank Account =======");

            //a. Try to instantiate the abstract class BankAccount directly and observe the compiler error.
            //BankAccount bankAccount = new BankAccount(); //// ERROR: Cannot create an instance of the abstract type or interface 'BankAccount'

            //b.Create a SavingsAccount object and a CurrentAccount object with initial balances.
            SavingsAccount savings = new SavingsAccount("Ahmed", 5000);
            CurrentAccount current = new CurrentAccount("Hashem", 2000);

            //c.Test your validation logic:
            //Try to set negative balance
            Console.WriteLine("\n== Negative Balance Test ==\n");
            SavingsAccount invalid = new SavingsAccount("Mostafa", -500);
            savings.Balance = -100; //Testing update safety

            //Attempt withdrawal violating 1000 minimum
            Console.WriteLine("\n== Savings Account Withdrawals ==\n");
            savings.Withdraw(3500); 
            savings.Withdraw(600);

            //Valid withdrawal with 5 EGP fee
            Console.WriteLine("\n== Current Account Withdrawals ==\n");
            current.Withdraw(500);
            current.Withdraw(2000);

            //d.Call BankAccount.PrintTotalAccounts() to display the total number of bank accounts created
            BankAccount.PrintTotalAccount();
            #endregion
        }
    }
}
