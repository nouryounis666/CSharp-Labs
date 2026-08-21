namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Electronics
            Console.WriteLine("====== Electronics ======\n");

            Electronics e1 = new Electronics(1, "Laptop", 30000, 24);
            Electronics e2 = new Electronics(1, "Different Laptop", 35000, 12);
            Electronics e3 = new Electronics(2, "Smartphone", 15000, 6);

            e1.Display();
            Console.WriteLine(e1.ToString());

            Console.WriteLine($"\nDo e1 and e2 have same IDs? => {e1.Equals(e2)}");
            Console.WriteLine($"\nDo e1 and e3 have different IDs? => {e1.Equals(e3)}");
            #endregion

            #region Food Items
            Console.WriteLine("\n====== Food Items ======\n");

            FoodItem f1 = new FoodItem(1, "Bread", 20, "25/8/2026");
            FoodItem f2 = new FoodItem(1, "Oat Bread", 30, "26/8/2026");
            FoodItem f3 = new FoodItem(2, "Pasta", 70, "27/8/2027");

            f1.Display();
            Console.WriteLine(f1.ToString());

            Console.WriteLine($"\nDo f1 and f2 have same IDs? => {f1.Equals(f2)}");
            Console.WriteLine($"\nDo f1 and f3 have different IDs? => {f1.Equals(f3)}");
            #endregion

            #region Interface Polymorphism
            Console.WriteLine("\n==== Verify that both types can be stored in an IStoredItem array ====\n");

            IStoredItem[] storedItems =
            [
                e1, e2, e3,
                f1, f2, f3
            ];

            Console.WriteLine("== Stored Items ==\n");
            foreach(IStoredItem storedItem in storedItems)
            {
                storedItem.Display();
            }
            #endregion
        }
    }
}
