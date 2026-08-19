using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    #region 1) Create a class named Student
    internal class Student
    {
        private double gpa;

        #region 2) Properties
        public int Id { get; }
        public string Name { get; set; }
        public double GPA
        {
            get { return gpa; }
            set
            {
                gpa = (value >= 0 && value <= 4) ? value : 0;
            }
        }

        #endregion

        #region 3) Constructors
        //a. Default
        public Student()
        {
            StudentsCount++;
        }
        //b. Takes 1 input (int id)
        public Student(int id) : this()
        {
            Id = id;
        }
        //c. Takes 2 inputs (int id, string name)
        public Student(int id, string name) : this(id) 
        {
            Name = name;
        }
        //d. takes 3 inputs (int id, string name, double gpa)
        public Student(int id, string name, double gpa) : this(id, name) 
        {
            GPA = gpa;
        }
        //e. Use constructor chaining (this()) 
        //// Applied in all ctors 
        #endregion

        #region 4) Instance Method
        public void Print()
        {
            Console.WriteLine($"\nID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"GPA: {GPA}");
        }
        #endregion

        #region 5) Static members
        //a.
        public static string UniversityName = "ITI";
        //b.
        public static int StudentsCount;
        #endregion

        #region 6) Static Method
        public static void PrintUniversityInfo()
        {
            Console.WriteLine($"University: {UniversityName}");
            Console.WriteLine($"Students Count: {StudentsCount}\n");
        }
        #endregion
    }
    #endregion
}
