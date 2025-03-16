using System;
using System.Collections.Generic;
using System.Text;
using KPZlab1;

namespace Kpzlab1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Введіть назву товару: ");
            string name = Console.ReadLine();

            Console.Write("Введіть цілу частину ціни: ");
            int wholePart = int.Parse(Console.ReadLine());

            Console.Write("Введіть копійки: ");
            int cents = int.Parse(Console.ReadLine());

            Product product1 = new Product(name, new Money(wholePart, cents));

            Warehouse warehouse = new Warehouse();
            warehouse.AddProduct(product1);

            Reporting reporting = new Reporting();
            reporting.GenerateInventoryReport(warehouse);

            Console.Write("\nНа скільки зменшити ціну? ");
            int reduceAmount = int.Parse(Console.ReadLine());
            product1.ReducePrice(reduceAmount);

            reporting.GenerateInventoryReport(warehouse);

            Console.ReadLine();
        }
    }
}

