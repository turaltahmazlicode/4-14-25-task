using ConsoleApp.Models;

namespace ConsoleApp.Services;

class ProductService
{
    private readonly List<Product> _products = new List<Product>();
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public List<Product> GetAllProducts()
    {
        return _products;
    }
    public Product GetProductById(Guid id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }
}
