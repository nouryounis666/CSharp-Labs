namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercises test

            #region Exercise 1
            int a = 10;
            int b = 20;
            Console.WriteLine($"Integers before swap: {a}, {b}");

            Swap(ref a, ref b);
            Console.WriteLine($"Integers after swap: {a}, {b}");
            #endregion

            #region Exercise 2
            Console.Write("Enter number of seconds: ");
            int totalSeconds = Convert.ToInt32(Console.ReadLine());

            Time(totalSeconds, out int hours, out int minutes, out int seconds);
            Console.WriteLine($"Hours : {hours}");
            Console.WriteLine($"Minutes : {minutes}");
            Console.WriteLine($"Seconds : {seconds}");
            #endregion

            #region Exercise 3
            Employee emp1;
            emp1.Id = 1;
            emp1.Name = "Nour";
            emp1.Salary = 6000;
            emp1.Department = Department.IT;

            Employee emp2;
            emp2.Id = 2;
            emp2.Name = "Tamer";
            emp2.Salary = 8000;
            emp2.Department = Department.HR;

            Console.WriteLine($"Employee_ID: {emp1.Id}, Name: {emp1.Name}, Salary: {emp1.Salary}, Department: {emp1.Department}");
            Console.WriteLine($"Employee_ID: {emp2.Id}, Name: {emp2.Name}, Salary: {emp2.Salary}, Department: {emp2.Department}");
            #endregion

            #region Exercise 4
            //3 a
            Student[] students = new Student[5];

            //3 b
            students[0] = new Student { Name = "Nour", Age = 20, Grade = Grade.Excellent };
            students[1] = new Student { Name = "Mahmoud", Age = 25, Grade = Grade.VeryGood };
            students[2] = new Student { Name = "Eman", Age = 20, Grade = Grade.Good };
            students[3] = new Student { Name = "Ahmed", Age = 21, Grade = Grade.Pass };
            students[4] = new Student { Name = "Malak", Age = 19, Grade = Grade.Fail };

            Console.WriteLine("Students Data: ");
            for (int i = 0; i < students.Length; i++)
            {
                PrintStudent(students[i]);
            }

            Console.WriteLine("\nWrong method");

            //Won't work bec structs are value types
            Console.WriteLine("Changing Student Age: ");
            ChangeAge(students[4], 22);
            PrintStudent(students[4]);

            Console.WriteLine("\nCorrect method");

            //Will work bec we used ref
            Console.WriteLine("Changing Student Age: ");
            ChangeAge(ref students[4], 22);
            PrintStudent(students[4]);

            #endregion

            #endregion
        }

        #region Exercise 1
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Exercise 2
        static void Time(int totalSeconds, out int hours, out int minutes, out int seconds)
        {
            hours = totalSeconds / 3600;
            minutes = (totalSeconds % 3600) / 60;
            seconds = (totalSeconds % 3600) % 60;
        }
        #endregion

        #region Exercise 4
        //4
        static void PrintStudent(Student student)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }
        //5
        static void ChangeAge(Student student, int newAge)
        {
            student.Age = newAge;
        }
        //6 
        /** 4) Method PrintStudent will work
        but
            5) Method ChangeAge won't work until adding ref before the struct bec it is a value type
        **/

        //new change age method
        static void ChangeAge(ref Student student, int newAge)
        {
            student.Age = newAge;
        }
        #endregion
    }
    #region Exercise 3 (enum, struct)
    //1
    enum Department
    {
        HR,
        IT,
        Sales,
        Marketing
    }
    //2
    struct Employee
    {
        public int Id;
        public string Name;
        public double Salary;
        public Department Department;
    }
    #endregion

    #region Exercise 4 (enum, struct)
    //1
    enum Grade
    {
        Fail,
        Pass,
        Good,
        VeryGood,
        Excellent
    }
    //2
    struct Student
    {
        public string Name;
        public int Age;
        public Grade Grade;
    }
    #endregion
}
