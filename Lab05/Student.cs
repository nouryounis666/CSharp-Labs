namespace Lab05
{
    //a.
    internal class Student : Person
    {
        private double gpa;

        public double GPA
        {
            get { return gpa; }
            set
            {
                gpa = (value >= 0 && value <= 4) ? value : 0;
            }
        }

        //c.
        #region Constructors
        // Default
        public Student() : base()
        {
            StudentsCount++;
        }
        // Takes 1 input 
        public Student(int id) : this(id, "Unknown")
        {
        }
        // Takes 2 inputs 
        public Student(int id, string name) : base(id, name)
        {
            StudentsCount++;
        }
        // Takes 3 inputs 
        public Student(int id, string name, double gpa) : this(id, name)
        {
            GPA = gpa;
        }
        #endregion

        //d. Override Print()
        public override void Print()
        {
            Console.WriteLine($"\nID: {Id}\nName: {Name}\nGPA: {GPA}");
        }
        // Virtual method
        public virtual void Study()
        {
            Console.WriteLine("Student is studying.");
        }

        // Static members
        public static string UniversityName = "ITI";
        public static int StudentsCount;

        //Static Method
        public static void PrintUniversityInfo()
        {
            Console.WriteLine($"University: {UniversityName}");
            Console.WriteLine($"Students Count: {StudentsCount}\n");
        }
    }
}
