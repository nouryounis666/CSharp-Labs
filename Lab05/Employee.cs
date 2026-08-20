namespace Lab05
{
    //a. Inherit from Person
    internal class Employee : Person
    {
        //b. Property
        public string Department { get; set; }

        //c. Constructors 
        public Employee() : base()
        {
            Department = "Unassigned";
        }
        public Employee(int id, string name, string department) : base(id, name)
        {
            Department = department;
        }

        //d. Override Print()
        public override void Print()
        {
            Console.WriteLine($"\nID: {Id}\nName: {Name}\nDepartment: {Department}");
        }
    }
}
