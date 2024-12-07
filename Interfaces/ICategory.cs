
namespace LearningLinq.Interfaces
{
    internal interface ICategory
    {
        int Id { get; set; }
        string Name { get; set; }
        List<IProduct> Products { get; set; }

        void AddProduct(IProduct product);
    }
}
