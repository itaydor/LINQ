

namespace LearningLinq.Interfaces
{
    internal interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        decimal Profit { get; set; }
    }
}
