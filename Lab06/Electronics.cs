using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Electronics : IStoredItem
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int WarrantyMonths { get; set; }
        #endregion

        #region Constructors
        public Electronics()
        {
            Id = 0;
            Name = "Unknown";
            Price = 0;
            WarrantyMonths = 0;
        }

        public Electronics(int id, string name, double price, int warrantyMonths)
        {
            Id = id;
            Name = name;
            Price = price;
            WarrantyMonths = warrantyMonths;
        }

        #endregion

        #region Methods
        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Price: {Price}");
        }
        public override string ToString()
        {
            return $"Electronics: {Name}, Price: {Price}, Warranty: {WarrantyMonths} months";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Electronics other)
            {
                return Id == other.Id;
            }
            return false;
        }
        #endregion    
    }
}
