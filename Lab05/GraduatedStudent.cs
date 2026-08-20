namespace Lab05
{
    //5. Create a sealed class named GraduatedStudent
    //a. Inherits from Student
    sealed class GraduatedStudent : Student
    {
        //b. Constructor
        public GraduatedStudent(int id, string name, double gpa) : base(id, name, gpa) { }

        //c. Method Hiding 
        public new void Study()
        {
            Console.WriteLine("I already graduated and looking for a job!");
        }
    }
}
