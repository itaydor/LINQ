// See https://aka.ms/new-console-template for more information

using LearningLinq.Classes;
using LearningLinq.Interfaces;

IProduct phone = new Product(1, "Phone", 699.99m, 150.00m);
IProduct laptop = new Product(2, "Laptop", 999.99m, 250.00m);
IProduct shirt = new Product(3, "Shirt", 29.99m, 10.00m);
IProduct jeans = new Product(4, "Jeans", 49.99m, 15.00m);
IProduct pradaJacket = new Product(4, "Prada Jacket", 2049.99m, 500.00m);
IProduct inBothCategories = new Product(5, "In Both Categories", 111.99m, 20.00m);



// Create categories and add products to them
ICategory electronics = new Category(1, "Electronics");
electronics.AddProduct(phone);
electronics.AddProduct(laptop);
electronics.AddProduct(inBothCategories);

ICategory clothing = new Category(2, "Clothing");
clothing.AddProduct(shirt);
clothing.AddProduct(jeans);
clothing.AddProduct(pradaJacket);
clothing.AddProduct(inBothCategories);

// Create a company and add categories to it
ICompany company = new Company(1, "Tech and Fashion Inc.");
company.AddCategory(electronics);
company.AddCategory(clothing);

var categorieWithHighestValue = company.GetCategorieWithHighestValue();
Console.WriteLine($"Categorie With Highest Value is {categorieWithHighestValue.Name} with Total value of {categorieWithHighestValue.TotalValue}");

var categoriesSums = company.GetCategoriesSums();
foreach (var (category, totalValue) in categoriesSums)
{
    Console.WriteLine($"Category: {category}, Total Value: {totalValue}");
}

var productsInMultipleCategories = company.GetProductsInMultipleCategories();
foreach(var product in productsInMultipleCategories)
{
    Console.WriteLine($"Product name: {product.Name} is in multiple categories.");
}

var categoriesNumberOfProductsList = company.GetCategoriesNumberOfProductsList();
foreach (var (category, items) in categoriesNumberOfProductsList)
{
    Console.WriteLine($"Category: {category}, Number of Products: {items}");
}

var categoryWithHighestAvgProfit = company.GetCategoryWithHighestAvgProfit();
Console.WriteLine($"Category with Highest Average Profit: {categoryWithHighestAvgProfit.Item1}, Average Profit: {categoryWithHighestAvgProfit.Item2}");

var productCategoriesList = company.GetProductCategoriesList();
foreach (var (product, categories) in productCategoriesList)
{
    Console.WriteLine($"Product: {product.Name}");
    foreach (var category in categories)
    {
        Console.WriteLine($" - Category: {category.Name}");
    }
}