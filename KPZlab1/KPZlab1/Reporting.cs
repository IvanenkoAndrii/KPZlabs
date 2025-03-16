using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZlab1
{
    public class Reporting
    {
        public void GenerateInventoryReport(Warehouse warehouse)
        {
            Console.WriteLine("Звіт по складу:");
            warehouse.ShowProducts();
        }
    }
}
