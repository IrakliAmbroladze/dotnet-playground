using Georgia;

namespace Georgia
{
    class Product
    {
        public const string Currency = "GEL";
        public readonly string Name;
        public Product(string name)
        {
            Name = name;
        }
    }
}
internal class Program
{
    static void Main()
    {
        Product product = new Product("Car");
        Console.WriteLine(Product.Currency);

        Console.WriteLine(product.Name);
    }
}
