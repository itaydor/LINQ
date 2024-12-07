using LearningLinq.Interfaces;

namespace LearningLinq.Classes
{
    internal class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Profit { get; set; }

        public Product(int id, string name, decimal price, decimal profit)
        {
            Id = id;
            Name = name;
            Price = price;
            Profit = profit;
        }
    }
}

