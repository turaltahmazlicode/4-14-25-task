using ConsoleApp.Models;
using ConsoleApp.Services;

namespace ConsoleApp;

internal static class Program
{
    static void Main(string[] args)
    {
        /*ProductService productService = new ProductService();
        productService.AddProduct(new Product
        {
            Id = Guid.NewGuid(),
            Name = "Product1",
            Category = "Category1",
            Price = 60,
            Stock = 10
        });
        productService.AddProduct(new Product
        {
            Id = Guid.NewGuid(),
            Name = "Product2",
            Category = "Category1",
            Price = 40,
            Stock = 0
        });
        productService.AddProduct(new Product
        {
            Id = Guid.NewGuid(),
            Name = "Product3",
            Category = "Category2",
            Price = 80,
            Stock = 5
        });
        productService.AddProduct(new Product
        {
            Id = Guid.NewGuid(),
            Name = "Product4",
            Category = "Category2",
            Price = 20,
            Stock = 15
        });
        productService.AddProduct(new Product
        {
            Id = Guid.NewGuid(),
            Name = "Product5",
            Category = "Category3",
            Price = 100,
            Stock = 2
        });
        var products = productService.GetAllProducts();*/
    }

    /// <summary>
    /// Butun qiymeti 50 manatdan yuxari olan mehsullari filterleyin.
    /// </summary>
    static IEnumerable<Product> GetPriceBiggerThan50(IEnumerable<Product> products)
    {
        return products.Where(p => p.Price > 50);
    }

    /// <summary>
    /// Ekranda ancaq mehsullarin adini ve qiymetini gosterin
    /// </summary>
    static void DisplayNameAndPrice(List<Product> products)
    {
        products.ForEach(p => Console.WriteLine($"Name: {p.Name}, Price: {p.Price}"));
    }

    /// <summary>
    /// Butun mehsullarin total qiymetini tapin.
    /// </summary>
    static decimal GetTotalValue(IEnumerable<Product> products)
    {
        return products.Sum(p => p.Price * p.Stock);
    }

    /// <summary>
    /// Butun mehsullarin stockunun 0-dan yuxari olub olmadigini yoxlayin.
    /// </summary>
    static IEnumerable<Product> GetProductsWithStock(IEnumerable<Product> products)
    {
        return products.Where(p => p.Stock > 0);
    }

    /// <summary>
    /// En bahali mehsulu tapin
    /// </summary>
    static Product GetMostExpenciveProductPrice(IEnumerable<Product> products)
    {
        return products.MaxBy(p => p.Price);
    }

    /// <summary>
    /// Mehsullari qiymeti azalan sira ile duzun
    /// </summary>
    static IEnumerable<Product> DescOrderByPrice(List<Product> products)
    {
        return products.OrderByDescending(p => p.Price);
    }

    /// <summary>
    /// Mehsullari kategoriyasina gore qruplashdirin ve her kategoriyada nece mehsul var gosterin
    /// </summary>I
    static void GroupByCategoryAndShowHowMuchProduct(IEnumerable<Product> products)
    {
        foreach (var item in products.GroupBy(p => p.Category))
            Console.WriteLine("{1} product in {0}", item.Key, item.Count());
    }
}