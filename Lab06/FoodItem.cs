using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class FoodItem : IStoredItem
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ExpirationDate { get; set; }
        #endregion

        #region Constructors
        public FoodItem()
        {
            Id = 0;
            Name = "Unknown";
            Price = 0;
            ExpirationDate = "Not mentioned";
        }
        public FoodItem(int id, string name, double price, string expirationDate)
        {
            Id = id;
            Name = name;
            Price = price;
            ExpirationDate = expirationDate;
        }
        #endregion

        #region Methods
        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Price: {Price}");
        }
        public override string ToString()
        {
            return $"Food: {Name}, Price: {Price}, Expiration Date: {ExpirationDate}";
        }
        public override bool Equals(object? obj)
        {
            return obj is FoodItem other ? Id == other.Id : false;
        }
        #endregion    
    }
}
