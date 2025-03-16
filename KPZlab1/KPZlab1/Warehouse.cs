using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZlab1
{
    public class Warehouse
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void ShowProducts()
        {
            foreach (var product in Products)
            {
                Console.Write($"Товар: {product.Name}, Ціна: ");
                product.Price.Display();
            }
        }
    }
}
