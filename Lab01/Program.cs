namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            #region Exercise 1
            Console.WriteLine("========== Exercise 1 ==========");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"Next year you'll be {age + 1} years old.");
            #endregion

            #region Exercise 2
            Console.WriteLine("========== Exercise 2 ==========");

            Console.WriteLine("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum = {first + second}");
            Console.WriteLine($"Difference = {first - second}");
            Console.WriteLine($"Product = {first * second}");
            if (second != 0)
                Console.WriteLine($"Division = {(double)first / second}");
            else
                Console.WriteLine("Division = Cannot divide by zero");
            #endregion

            //Part 2
            #region Exercise 3
            Console.WriteLine("========== Exercise 3 ==========");

            Console.WriteLine("Enter your grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade < 0 || grade > 100)
                Console.WriteLine("Invalid grade");
            else if (grade >= 90)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade is D");
            }
            else
            {
                Console.WriteLine("Your grade is F");
            }
            #endregion

            #region Exercise 4
            Console.WriteLine("========== Exercise 4 ==========");

            Console.WriteLine("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int largest = n1;
            if (n2 > largest)
            {
                largest = n2;
            }
            if (n3 > largest)
            {
                largest = n3;
            }
            Console.WriteLine($"Largest = {largest}");
            #endregion

            //Part 3
            #region Exercise 5
            Console.WriteLine("========== Exercise 5 ==========");

            Console.WriteLine("Enter a number from 1 to 7");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            #endregion

            #region Exercise 6
            Console.WriteLine("========== Exercise 6 ==========");

            Console.Write("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result = {x + y}");
                    break;
                case "-":
                    Console.WriteLine($"Result = {x - y}");
                    break;
                case "*":
                    Console.WriteLine($"Result = {x * y}");
                    break;
                case "/":
                    if (y == 0)
                        Console.WriteLine("Error: Division by zero");
                    else
                        Console.WriteLine($"Result = {(double)x / y}");
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    break;
            }
            #endregion

            //Part 4
            #region Exercise 7
            Console.WriteLine("========== Exercise 7 ==========");

            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Exercise 8
            Console.WriteLine("========== Exercise 8 ==========");

            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication table for {num}");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
            #endregion

            #region Exercise 9
            Console.WriteLine("========== Exercise 9 ==========");

            int sum = 0;
            int n = -1;
            while (n != 0)
            {
                Console.WriteLine("Enter a number (0 to stop): ");
                n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine($"The sum of the entered numbers is: {sum}");
            #endregion

            #region Exercise 10
            Console.WriteLine("========== Exercise 10 ==========");

            string password;
            do
            {
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();

                if (password != "ITI123")
                {
                    Console.WriteLine("Incorrect password, Try again");
                }

            } while (password != "ITI123");
            Console.WriteLine("Welcome to ITI!");
            #endregion

            //Part 5
            #region Bonus
            Console.WriteLine("========== Bonus ==========");

            Random random = new Random();
            string playAgain;
            do
            {
                int numberToGuess = random.Next(1, 101);
                int guess = 0;
                int attempts = 0;
                Console.WriteLine("Guess a number (Between 1 and 100): ");
                while (guess != numberToGuess)
                {
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    attempts++;
                    if (guess > numberToGuess)
                        Console.WriteLine("Too High");
                    else if (guess < numberToGuess)
                        Console.WriteLine("Too Low");
                    else
                    {
                        Console.WriteLine("Correct!");
                        Console.WriteLine($"Number of attempts = {attempts}");
                    }
                }
                Console.Write("Do you want to play again? (y/n): ");
                playAgain = Console.ReadLine().ToLower();
            } while (playAgain == "y");
            #endregion
        }
    }
}
