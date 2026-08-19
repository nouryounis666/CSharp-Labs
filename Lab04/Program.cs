using System.Collections.Generic;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testing Part 1 - Student
            Console.WriteLine("======= Part 1 : Student =======\n");

            //a. Create 3 Student objects
            Student s1 = new Student(1, "Nour", 4.0);
            Student s2 = new Student(2, "Tamer", 3.91);
            Student s3 = new Student(3, "Mahmoud", 3.82);

            //b. Print all students
            Console.WriteLine("== Student Info ==");
            s1.Print();
            s2.Print();
            s3.Print();

            //c. Print the total number of students
            Console.WriteLine("\n== University Info ==\n");
            Student.PrintUniversityInfo();
            #endregion

            #region Testing Part 2 - BankAccount
            Console.WriteLine("======= Part 2 : Bank Account =======\n");

            //a.Create at least 2 accounts
            BankAccount b1 = new BankAccount("Nour", 6000);
            BankAccount b2 = new BankAccount("Tamer", 8000);
            BankAccount b3 = new BankAccount("Mahmoud", 10000);

            //b.Try to set a negative balance and confirm it’s rejected
            Console.Write("Trying to set a negative balance => ");
            BankAccount b4 = new BankAccount("Eman", -500);

            //c.Print the total number of accounts
            BankAccount.PrintTotalAccount();

            Console.WriteLine("\n== Accounts Info ==\n");
            Console.WriteLine($"{b1.AccountHolder}= {b1.Balance}");
            Console.WriteLine($"{b2.AccountHolder}= {b2.Balance}");
            Console.WriteLine($"{b3.AccountHolder}= {b3.Balance}");
            Console.WriteLine($"{b4.AccountHolder}= {b4.Balance}");

            #endregion
        }
    }
}
