using LearningLinq.Interfaces;

namespace LearningLinq.Classes
{
    internal class Company : ICompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ICategory> Categories { get; set; }

        public Company(int id, string name)
        {
            Id = id;
            Name = name;
            Categories = new();
        }

        public void AddCategory(ICategory category)
        {
            Categories.Add(category);
        }
        
        public List<IProduct> GetProductsInMultipleCategories()
        {
            return Categories.SelectMany(c => c.Products.Select(p => new { Category = c.Name, Product = p }))
                .GroupBy(cp => cp.Product)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();
        }

        public (string Name, decimal TotalValue) GetCategorieWithHighestValue()
        {
            return Categories.Select(c => new { c.Name, TotalValue = c.Products.Sum(p => p.Price) })
                .OrderByDescending(ct => ct.TotalValue)
                .Select(o => (o.Name, o.TotalValue))
                .FirstOrDefault();
        }

        public List<(string Category, decimal TotalValue)> GetCategoriesSums()
        {            
            return Categories.Select(c => (c.Name, c.Products.Sum(p => p.Price))).ToList();
        }

        public List<(string Category, int items)> GetCategoriesNumberOfProductsList()
        {
            return Categories.Select(c => (c.Name, c.Products.Count())).ToList();
        }

        public (string, decimal) GetCategoryWithHighestAvgProfit()
        {
            return Categories
                .Select(c => new
                {
                    c.Name,
                    AvgProfit = c.Products.Average(p => p.Profit)
                })
                .OrderByDescending(t => t.AvgProfit)
                .Select(t => (t.Name, t.AvgProfit))
                .FirstOrDefault();
        }

        public List<(IProduct, List<ICategory>)> GetProductCategoriesList()
        {
            return Categories.SelectMany(c => c.Products.Select(p => new { Category = c, Product = p }))
                    .GroupBy(cp => cp.Product)
                    .Select(g => (g.Key, Values: g.Select(cp => cp.Category).ToList()))
                    .ToList();
        }
    }
}
