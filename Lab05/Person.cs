namespace Lab05
{
    // 1. Create an abstract class named Person
    abstract class Person
    {
        // a. Properties
        public int Id { get; }
        public string Name { get; set; }

        // b. Constructors
        public Person()
        {
            Id = 1;
            Name = "Unknown";
        }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //c. Method
        public abstract void Print();
    }
}
