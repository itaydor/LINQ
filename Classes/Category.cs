using LearningLinq.Interfaces;

namespace LearningLinq.Classes
{
    internal class Category : ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IProduct> Products { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            Products = new();
        }

        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }
    }
}
