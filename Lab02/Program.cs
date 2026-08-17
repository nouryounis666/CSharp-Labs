namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test Exercises
            //Exercise 1
                //Calculator();

            //Exercise 2
                //Print();

            //Exercise 3
                //EmailVerification();

            //Exercise 4
                //FiveNames();

            //Exercise 5
                //EvenOrOdd();

            //Exercise 6
                //ArrayCalculations();
            #endregion

            #region Part 1 - Methods
            //Exercise 1 
            static void Calculator()
            {
                Console.Write("Enter first number: ");
                double first = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double second = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n1- Add");
                Console.WriteLine("2- Subtract");
                Console.WriteLine("3- Multiply");
                Console.WriteLine("4- Divide\n");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                double result;

                switch (choice)
                {
                    case 1:
                        result = Add(first, second);
                        break;
                    case 2:
                        result = Subtract(first, second);
                        break;
                    case 3:
                        result = Multiply(first, second);
                        break;
                    case 4:
                        if (second != 0)
                        {
                            result = Divide(first, second);
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        return;
                }
                Console.WriteLine($"Result = {result}");

                static double Add(double first, double second)
                {
                    return first + second;
                }
                static double Subtract(double first, double second)
                {
                    return first - second;
                }
                static double Multiply(double first, double second)
                {
                    return first * second;
                }
                static double Divide(double first, double second)
                {
                    return first / second;
                }
            }
            #endregion

            #region Part 2 - String
            //Exercise 2 
            static void Print()
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Original name: {name}");
                Console.WriteLine($"Uppercase: {name.ToUpper()}");
                Console.WriteLine($"Lowercase: {name.ToLower()}");
                Console.WriteLine($"Length: {name.Length}");
                Console.WriteLine($"Trimmed Name: {name.Trim()}");

            }
            //Exercise 3
            static void EmailVerification()
            {
                Console.WriteLine("Enter an email: ");
                string email = Console.ReadLine();

                if (email.EndsWith("@gmail.com")){
                    Console.WriteLine("Valid Gmail");
                }
                else
                {
                    Console.WriteLine("Invalid Gmail");
                }
            }
            //Exercise 4
            static void FiveNames()
            {
                string[] names = new string[5];

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write($"Enter name {i + 1}: ");
                    names[i] = Console.ReadLine();
                }

                Console.WriteLine("\nNames in Uppercase:");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i].ToUpper());
                }
            }
            #endregion

            #region Part 3 - Array Basics
            //Exercise 5
            static void EvenOrOdd()
            {
                int[] numbers = new int[5];
                Console.WriteLine("Enter 5 integers to check their parity\n");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\nParity Check:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine($"{numbers[i]} is Even");
                    }
                    else
                    {
                        Console.WriteLine($"{numbers[i]} is Odd");
                    }
                }
            }

            //Exercise 6
            static void ArrayCalculations()
            {
                int[] numbers = new int[5];
                Console.WriteLine("Enter 5 integers for calculations:\n");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($"\nSum = {numbers.Sum()}");
                Console.WriteLine($"Average = {numbers.Average()}");
                Console.WriteLine($"Largest Number = {numbers.Max()}");
                Console.WriteLine($"Minimum Number = {numbers.Min()}");
            }
            #endregion
        }
    }
}
