using Georgia;

namespace Georgia
{
    class Product
    {
        int price = 0;
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }
        public Product(int price)
        {
            this.Price = price;
        }
    }
}
internal class Program
{
    static void Main()
    {
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            Product product = new Product(input);
            Console.WriteLine(product.Price);
        }
    }
}
