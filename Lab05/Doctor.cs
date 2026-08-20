namespace Lab05
{
    //a. Inherit from Person
    internal class Doctor : Person
    {
        //b. Property
        public string SubjectName { get; set; }

        //c. Constructors
        public Doctor() : base()
        {
            SubjectName = "Unassigned";
        }
        public Doctor(int id, string name, string subjectName) : base(id, name)
        {
            SubjectName = subjectName;
        }

        //d. Methods
        public override void Print()
        {
            Console.WriteLine($"\nID: {Id}\nName: {Name}\nSubject Name: {SubjectName}");
        }
    }
}
