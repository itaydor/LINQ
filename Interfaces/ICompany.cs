
using LearningLinq.Classes;

namespace LearningLinq.Interfaces
{
    internal interface ICompany
    {
        int Id { get; set; }
        string Name { get; set; }
        List<ICategory> Categories { get; set; }

        void AddCategory(ICategory category);

        List<IProduct> GetProductsInMultipleCategories();

        (string Name, decimal TotalValue) GetCategorieWithHighestValue();

        List<(string Category, decimal TotalValue)> GetCategoriesSums();
        
        List<(string Category, int items)> GetCategoriesNumberOfProductsList();
        
        (string, decimal) GetCategoryWithHighestAvgProfit();

        List<(IProduct, List<ICategory>)> GetProductCategoriesList();
    }
}
